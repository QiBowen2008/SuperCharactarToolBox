// Add Most Recently Used Files (MRU) List to Windows Applications
// from Adib Saad
// https://www.codeproject.com/Articles/407513/Add-Most-Recently-Used-Files-MRU-List-to-Windows-A
// Changed, stored not in the registry but in an XML file
// from Klaus Ruttkowski
// Provided as vsix file
/*
1) Set the desired location of the MRU file in public class MRUManager
   private MRUDataPath mruDataPath = MRUDataPath.Roaming; // MRUDataPath { Local, Roaming, Common, ExePath };

2) Create Class Form1
3) Insert Event Form1_Load
4) Insert ToolStrip with menu top Item "File" and sub items
    a) "Open"
    b) "Recent"
5) Insert the following code in the corresponding places.

using System.IO;
using RuFramework.MRU;

namespace RuMRUManager
{
    public partial class Form1 : Form
    {
        private MRUManager mruManager;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Init MRUManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.mruManager = new MRUManager(this.recentToolStripMenuItem,      // Recent menu		
                                            this.MRU_Open);                     // MRU Funtion open cliced.			
        }
 		
        private void openToolStripMenuItem_Click(object obj, EventArgs evt)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            string fileName = openFileDlg.FileName;

            //Now give it to the MRUManager
            this.mruManager.AddRecentFile(fileName);
            // Common function to open the file
            Open(fileName);
        }
        /// <summary>
        /// if Open from MRUList
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="evt"></param>
        private void MRU_Open(object obj, EventArgs evt)
        {
            string fileName = (obj as ToolStripItem).Text;
            if (!File.Exists(fileName))
            {
                // Recent file not exist
                this.mruManager.RemoveRecentFile(fileName);
                MessageBox.Show(fileName + " not exist, Item deleded.");
                return;
            }
            // Common function to open the file
            Open(fileName);
        }
        /// <summary>
        /// Common function to open the file
        /// </summary>
        /// <param name="fileName">filename</param>
        private void Open(string fileName)
        {
            MessageBox.Show("Open: " + fileName);
            // TODO: Your file open
        }
      }
}
*/
/// <summary>
/// RuMRUManager 1.2 (Change from 1.0 only affects installation also on Visual Studio 2022)
/// </summary>
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RuFramework.MRU
{
    public class MRUManager
    {
        #region MRUManager
        // MRUDataPath for select the save path of mru file
        private enum MRUDataPath { Local, Roaming, Common, ExePath };

        // Set the desired location of the MRU file
        private MRUDataPath mruDataPath = MRUDataPath.Roaming;

        #region Public members
        /// <summary>
        /// Init the MRUManager
        /// </summary>
        /// <param name="parentMenuItem">Recent Menu Item</param>
        /// <param name="onRecentFileClick">Event to click resent menu item</param>
        public MRUManager(ToolStripMenuItem parentMenuItem, Action<object, EventArgs> onRecentFileClick)
        {
            mruSettings = Read(mruDataPath); // Default = MRUAppDataPath.Roaming
            mruSettings.MRUList = mruList;

            if (parentMenuItem == null || onRecentFileClick == null)
                throw new ArgumentException("Bad argument.");

            this.ParentMenuItem = parentMenuItem;
            this.OnRecentFileClick = onRecentFileClick;
            this._refreshRecentFilesMenu();
        }
        /// <summary>
        /// Remove recent menu Item
        /// </summary>
        /// <param name="fileNameWithFullPath">file name</param>
        public void RemoveRecentFile(string fileNameWithFullPath)
        {
            Remove(fileNameWithFullPath);
            _refreshRecentFilesMenu();
        }
        /// <summary>
        /// Add recent menu item
        /// </summary>
        /// <param name="fileNameWithFullPath">file name</param>
        public void AddRecentFile(string fileNameWithFullPath)
        {
            Remove(fileNameWithFullPath);
            /*
			// if array has maximum length, remove last element
			if (mruList.Count == maxNumberOfFiles)
				mruList.RemoveAt(maxNumberOfFiles - 1);
			*/
            // add new file name to the start of array
            mruList.Insert(0, fileNameWithFullPath);
            MRUSettings mruSettings = new MRUSettings();
            mruSettings = Read(mruDataPath); // Default = MRUAppDataPath.Roaming
            mruSettings.MRUList = mruList;
            Save(mruSettings, mruDataPath); // Default = MRUAppDataPath.Roaming
            this._refreshRecentFilesMenu();
        }

        #endregion
        #region Private members
        MRUSettings mruSettings = new MRUSettings();            // MRU-file
        private ArrayList mruList;                              // MRU list (file names)
        private ToolStripMenuItem ParentMenuItem;               // Recent menu item
        private Action<object, EventArgs> OnRecentFileClick;    // Event to clear MRU-file an recent menu items

        /// <summary>
        /// Event to clear MRU-file an recent menu items
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="evt"></param>
        private void _onClearRecentFiles_Click(object obj, EventArgs evt)
        {
            try
            {
                Remove();
                this.ParentMenuItem.DropDownItems.Clear();
                this.ParentMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// Refresh recent menu items
        /// </summary>
        private void _refreshRecentFilesMenu()
        {
            ToolStripItem tSI;
            try
            {
                // Hier wird die Liste aus der MRU-Datei gefüllt
                mruSettings = Read(mruDataPath);
                mruList = mruSettings.MRUList;

                if (mruList == null)
                {
                    // Es ist kein Eintrag vorhanden, daktiviere Menu
                    this.ParentMenuItem.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot open recent MRU-file:\n" + ex.ToString());
                return;
            }

            // lösche alle Einträge
            this.ParentMenuItem.DropDownItems.Clear();

            // durchlaufe alle Einträge 
            foreach (string mruItem in mruList)
            {
                if (mruItem == null) continue;
                tSI = this.ParentMenuItem.DropDownItems.Add(mruItem);
                tSI.Click += new EventHandler(this.OnRecentFileClick);
            }

            if (this.ParentMenuItem.DropDownItems.Count == 0)
            {
                this.ParentMenuItem.Enabled = false;
                return;
            }
            // füge Separator ein
            this.ParentMenuItem.DropDownItems.Add("-");
            // Füge Eintrag zum Löschen ein
            tSI = this.ParentMenuItem.DropDownItems.Add("Clear list");
            // und den Event
            tSI.Click += new EventHandler(this._onClearRecentFiles_Click);
            // Enable das Menü
            this.ParentMenuItem.Enabled = true;
        }
        #endregion
        #endregion
        #region MRUData

        /// <summary>
        /// Get MRU-Path depending on Local, Roaming, Common or ExePath
        /// Default is Roaming
        /// </summary>
        /// <param name="mruDataPath"></param>
        /// <returns>Filename with path</returns>
        private string GetAppDataPath(MRUDataPath mruDataPath = MRUDataPath.Roaming)
        {
            string ConfigPath = null;
            try
            {
                switch (mruDataPath)
                {
                    case MRUDataPath.Local:
                        // C:\users\UserName\AppData\Local\ProductName\ProductName\ProductVersion\ProductName.Config
                        ConfigPath = Application.LocalUserAppDataPath + "\\" + Application.ProductName + ".mru";
                        break;
                    case MRUDataPath.Roaming:
                        // C:\users\UserName\AppData\Roaming\ProductName\ProductName\ProductVersion\ProductName.Config
                        ConfigPath = Application.UserAppDataPath + "\\" + Application.ProductName + ".mru";
                        break;
                    case MRUDataPath.Common:
                        // C:\ProgramData\ProductName\ProductName\ProductVersion\ProductName.Config
                        ConfigPath = Application.CommonAppDataPath + "\\" + Application.ProductName + ".mru";
                        break;
                    case MRUDataPath.ExePath:
                        // ProductSaveDirectory\ProductName.Config, only PortableApps
                        ConfigPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + Application.ProductName + ".mru";
                        break;
                    default: // Roaming
                        ConfigPath = Application.UserAppDataPath + "\\" + Application.ProductName + ".mru";
                        break;
                }
                return ConfigPath;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Read MRU data by Path to MRU-file or default by roaming
        /// </summary>
        /// <param name="ConfigPath">Config file name or nothig, default roaming</param>
        /// <returns>Config data</returns>
        private MRUSettings Read(MRUDataPath mruDataPath)
        {
            MRUSettings appSettings = new MRUSettings();
            try
            {
                string ConfigPath = GetAppDataPath(mruDataPath);
                Regex r = new Regex(@"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$");
                if (r.IsMatch(ConfigPath))
                {

                    using (FileStream fileStream = new FileStream(ConfigPath.ToString(), FileMode.Open))
                    {
                        var serializer = new XmlSerializer(typeof(MRUSettings));
                        appSettings = (MRUSettings)serializer.Deserialize(fileStream);
                        fileStream.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error: Bad finename");

                }
            }
            catch (Exception ex)
            {
                Save(appSettings, mruDataPath);
                MessageBox.Show(ex.Message + " but is new created!");
            }
            return appSettings;
        }
        /// <summary>
        /// Save config data with Path to MRU-file
        /// </summary>
        /// <param name="appSettings">Config data</param>
        /// <param name="ConfigPath">Config file name or nothig, default roaming</param>
        private void Save(MRUSettings mruAppSettings, MRUDataPath mruDataPath)
        {
            string ConfigPath = GetAppDataPath(mruDataPath);
            try
            {
                if (ConfigPath == null) ConfigPath = Application.UserAppDataPath + "\\" + Application.ProductName + ".config";
                Regex r = new Regex(@"^(([a-zA-Z]\:)|(\\))(\\{1}|((\\{1})[^\\]([^/:*?<>""|]*))+)$");
                if (r.IsMatch(ConfigPath))
                {
                    using (StreamWriter streamWriter = new StreamWriter(ConfigPath))
                    {
                        using (XmlWriter xmlWriter = XmlWriter.Create(streamWriter))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(MRUSettings));
                            serializer.Serialize(xmlWriter, mruAppSettings);
                        }
                        streamWriter.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write file to disk. Original error: " + ex.InnerException.InnerException.Message);
            }
        }
        /// <summary>
        /// Remove file name from MRU-file.
        /// Call this function when File - Open operation failed.
        /// </summary>
        /// <param name="file">File Name</param>
        private void Remove(string file)
        {
            int i = 0;
            if (mruList != null)
            {
                IEnumerator myEnumerator = mruList.GetEnumerator();

                while (myEnumerator.MoveNext())
                {
                    if ((string)myEnumerator.Current == file)
                    {
                        mruList.RemoveAt(i);
                        Save(mruSettings, mruDataPath); // Default = MRUAppDataPath.Roaming

                        break;
                    }

                    i++;
                }
            }
        }
        /// <summary>
        /// Remove all file name from the MRU-file
        /// </summary>
        private void Remove()
        {
            IEnumerator myEnumerator = mruList.GetEnumerator();
            mruList.Clear();
            MRUSettings mruSettings = new MRUSettings();
            mruSettings = Read(mruDataPath); // Default = MRUAppDataPath.Roaming
            mruSettings.MRUList = mruList;
            Save(mruSettings, mruDataPath); // Default = MRUAppDataPath.Roaming
        }
        #endregion
    }
}
