﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace SuperTextToolBox
{
    public partial class frmAbout : Sunny.UI.UIForm
    {
        public frmAbout() => InitializeComponent();
        private void button1_Click(object sender, EventArgs e) => Close();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/QiBowen2008/SuperTextToolBox");
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/QiBowen2008/SuperCalc-Made-of-VB6");
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/QiBowen2008/SuperFreeApi");
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/zmjack/Chinese");
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/JamesNK/Newtonsoft.Json");
        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/Chinese/0.5.0/license");
        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://licenses.nuget.org/MIT");
        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/NStandard/0.9.16/license");
        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/jieba.NET/0.42.2?_src=template");
        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://opensource.org/licenses/MIT");
        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.nuget.org/packages/WordCloudSharp/1.1.0?_src=template");
        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/AmmRage/WordCloudSharp/tree/master/license");
        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://gitee.com/kwwwvagaa/net_winform_custom_control");
        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://gitee.com/yhuse/SunnyUI");
        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://www.apache.org/licenses/LICENSE-2.0.html");
        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://licenses.nuget.org/GPL-3.0-only");
        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://licenses.nuget.org/MIT");
        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://html-agility-pack.net/");

        private void frmAbout_Load(object sender, EventArgs e)
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
            }
            Height = (int)(479 * scaleFactor);
            Width = (int)(700 * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
        }

        private void linkLabel14_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/QiBowen2008/TurtleDriver");
        }
    }
}
