using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OCRAddin
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {if (args.Length >= 1)
            {
                canshu.path = args[0];
                canshu.fromword = true;
            }
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OCRFull());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

    }
    public static class canshu
    {
        public static string path;
        public static string ocrtype;
        public static bool fromword;
    }
}
