using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SuperTextToolBox
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
    public static class IniManager
    {
        /// <summary>
        /// 获取值
        /// </summary>
        /// <param name="section">段落名</param>
        /// <param name="key">键名</param>
        /// <param name="defval">读取异常是的缺省值</param>
        /// <param name="retval">键名所对应的的值，没有找到返回空值</param>
        /// <param name="size">返回值允许的大小</param>
        /// <param name="filepath">ini文件的完整路径</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(
            string section,
            string key,
            string defval,
            StringBuilder retval,
            int size,
            string filepath);

        /// <summary>
        /// 写入
        /// </summary>
        /// <param name="section">需要写入的段落名</param>
        /// <param name="key">需要写入的键名</param>
        /// <param name="val">写入值</param>
        /// <param name="filepath">ini文件的完整路径</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(
            string section,
            string key,
            string val,
            string filepath);


        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="section">段落名</param>
        /// <param name="key">键名</param>
        /// <param name="def">没有找到时返回的默认值</param>
        /// <param name="filename">ini文件完整路径</param>
        /// <returns></returns>
        public static string getString(string section, string key, string def, string filename)
        {
            StringBuilder sb = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, sb, 1024, filename);
            return sb.ToString();
        }

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="section">段落名</param>
        /// <param name="key">键名</param>
        /// <param name="val">写入值</param>
        /// <param name="filename">ini文件完整路径</param>
        public static void writeString(string section, string key, string val, string filename)
        {
            WritePrivateProfileString(section, key, val, filename);
        }
    }
    public static class Set
    {
        public static string INIpath = Application.StartupPath + "\\config.ini";
        public static string FileSavePath = IniManager.getString("Set", "FileSavePath", null, INIpath);
    }
}
