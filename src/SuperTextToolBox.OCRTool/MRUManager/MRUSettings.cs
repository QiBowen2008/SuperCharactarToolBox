using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Serialization;

/*
using RuFramework.Config;
namespace RuConfig
{
    public partial class Form1 : Form
    {
         AppSettings appSettings = new AppSettings();
        
        public Form1()
        {
            InitializeComponent();
            // Select the config data path
            //                                          ConfigManager.GetAppDataPath(AppDataPath.Local);
            //                                          ConfigManager.GetAppDataPath(AppDataPath.Common);
            //                                          ConfigManager.GetAppDataPath(AppDataPath.ExePath);
            //                                          ConfigManager.GetAppDataPath(AppDataPath.Roaming);
            // Default read data = ConfigManager.Read(ConfigManager.GetAppDataPath(AppDataPath.Roaming))
            appSettings = ConfigManager.Read(); // default Roaming
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //AppSettingsDialog appSettingsDialog = new AppSettingsDialog(appSettings, AppDataPath.Roaming);
            AppSettingsDialog appSettingsDialog = new AppSettingsDialog(appSettings); // default Roaming
            appSettingsDialog.propertyGrid.SelectedObject = appSettings;
            appSettingsDialog.ShowDialog();
            appSettings = appSettingsDialog.AppSettingsOk;

            // Property is changed in the program, you must save
            ChangeAppSettings();
         }
        private void ChangeAppSettings()
        {
            appSettings.MyString = "Property MyString changed";
            // ConfigManager.Save(appSettings, AppDataPath.Roaming);
            // or
            ConfigManager.Save(appSettings); // default Roaming
        }
    }
}
*/

namespace RuFramework.MRU
{
    [XmlType(TypeName = "MRUSettings")]
    [Serializable]
    public class MRUSettings : EventArgs
    {
        #region MRU - Do not delete
        // ********************************************************************************** //
        //  DDDD                                        TT           DD              LL                           
        //  DD  DD                                     TTTT          DD              LL                             
        //  DD   DD     OOOO       NNN    NN    OOOO    TT        DD DD     EEEE     LL                                     
        //  DD    DD   OO  OO      NNUN   NN   OO  OO   TT      DD   DD   EE    EE   LL                                     
        //  DD    DD  OO    OO     NN NN  NN  OO    OO  TT     DD    DD  EE      EE  LL                                  
        //  DD   DD   OO    OO     NN  NN NN  OO    OO  TT     DD    DD  EEEEEEEEE   LL                         
        //  DD  DD     OO  OO      NN   NNNN   OO  OO   TT      DD   DD   EE         LL                              
        //  DDDD        OOOO       NN    NNN    OOOO    TT        DD DD     EEEE     LLLL                            
        // ********************************************************************************** //
        [Category("MRU")]
        [Description("MRU Filelist, when using the MRU Manager absolutely necessary ")]
        [DisplayName("MRU Filelist")]
        // [EditorAttribute(typeof(CustomCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Browsable(true)]
        public ArrayList MRUList { set; get; }
        #endregion
    }

}
