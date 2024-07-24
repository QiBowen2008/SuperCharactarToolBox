using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SuperWenZiToolBox
{
    public partial class frmSet : Sunny.UI.UIForm
    {
        public frmSet()
        {
            InitializeComponent();
        }
        string IniPath = Set.INIpath;
        public static string selectlang;
        public readonly static string qt = "multilingual/";
        public static string lang = "ch";
        public static string oldpath;
        public readonly static string ed = "_PP-OCRv3_rec_infer";
        private void button2_Click(object sender, EventArgs e) => Close();

        public static object CopyFolder(string sourceFolder, string destFolder)
        {
            try
            {
                //如果目标路径不存在,则创建目标路径
                if (!Directory.Exists(destFolder))
                {
                    Directory.CreateDirectory(destFolder);
                }
                //得到原文件根目录下的所有文件
                string[] files = Directory.GetFiles(sourceFolder);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    string dest = Path.Combine(destFolder, name);
                    File.Copy(file, dest, true);//复制文件
                }
                //得到原文件根目录下的所有文件夹
                string[] folders = Directory.GetDirectories(sourceFolder);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    CopyFolder(folder, dest);//构建目标路径,递归复制文件
                }
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        private void frmSet_Load(object sender, EventArgs e)
        {
            moveable = false;
            textBox2.Text = IniManager.getString("Set", "FileSavePath", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            string autosave = IniManager.getString("Set", "AutoSave", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Set.INIpath);
            if (autosave == "False")
                uiCheckBox2.Checked = false;
            else
                uiCheckBox2.Checked = true;
            
        }
        public  string[] oldpaths = new string[8];
        public  string[] oldfiles = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
            if (uiCheckBox2.Checked == true)
                IniManager.writeString("Set", "AutoSave", "True", IniPath);
            else
                IniManager.writeString("Set", "AutoSave", "False", IniPath);
            Properties.Settings.Default.AutoIcon = uiCheckBox1.Checked;
            if (uiComboBox1.Text != "" && uiComboBox2.Text != "")
            {
                Properties.Settings.Default.TranslateAppID = uiComboBox1.Text;
                Properties.Settings.Default.TranslateApiKey = uiComboBox2.Text;
            }
            else
            {
                MessageBox.Show("未设置Appid和Apikey，将无法使用翻译功能");
            }
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                uiComboBox2.Focus();
            }
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                uiButton1.Focus();
            }
        }
       
     
        public void DownloadFile(string URL, string filename, ProgressBar prog, Label label1)
        {

        }
        public void DownloadFile(string URL,string filename)
        {

        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://developer.aliyun.com/article/1174048");
        public static bool moveable;
        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}