using System;
using System.Diagnostics;
using Sunny.UI;
using System.Windows.Forms;
using System.Drawing;
namespace SuperTextToolBox
{
    public partial class frmMain : UIForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmAbout fabout = new frmAbout();
            fabout.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmTexttoWave ftexttoWave = new frmTexttoWave();
            ftexttoWave.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            // 获取当前DPI比例
            float dpiX, dpiY;
            using (Graphics g = CreateGraphics())
            {
                dpiX = g.DpiX;
                dpiY = g.DpiY;
            }
            // 根据DPI比例调整控件尺寸
            float scaleFactor = dpiX / 96f; // 96 DPI 是标准DPI
            foreach (Control control in Controls)
            {
                control.Width = (int)(control.Width * scaleFactor);
                control.Height = (int)(control.Height * scaleFactor);
                control.Left = (int)(control.Left * scaleFactor);
                control.Top = (int)(control.Top * scaleFactor);
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scaleFactor, control.Font.Style);
            }
            Height = (int)(Height * scaleFactor);
            Width = (int)(Width * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
            titleFont = new Font(titleFont.FontFamily, titleFont.Size * scaleFactor, titleFont.Style);
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            frmTranslate ftranslate = new frmTranslate();
            ftranslate.Show();
        }
        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            frmPinyin fpinyin = new frmPinyin();
            fpinyin.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmFenci fFenci = new frmFenci();
            fFenci.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SuperTextToolBox.OCRTool.exe");
            }
            catch
            {
                MessageBox.Show("必要文件丢失，请重新下载软件");
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SuperTextToolBox.WordCloudTool.exe");
            }
            catch
            {
                MessageBox.Show("必要文件丢失，请重新下载软件");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            frmCyjl cyjl = new frmCyjl();
            cyjl.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            frmSet set = new frmSet();
            set.Show();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.AutoIcon == true)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }
        private void uiButton5_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\help.chm");
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            frmTextToPic textToPic = new frmTextToPic();
            textToPic.Show();
        }
    }
}
