﻿using Chinese;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace SuperTextToolBox
{
    public partial class frmPinyin : Sunny.UI.UIForm
    {
        public frmPinyin()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sd = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(0));
                richTextBox1.Text = sd.ReadToEnd();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先转换");
            }
            else
            {
                saveFileDialog1.Filter = "文本文档 | *.txt";
                string autosave = IniManager.getString("Set", "AutoSave", "", Set.INIpath);
                if (autosave == "True")
                {
                    string filesavepath = IniManager.getString("Set", "FileSavePath", "", Set.INIpath);
                    if (filesavepath != "")
                    {
                        string nowtime = DateTime.Now.ToShortTimeString().ToString();
                        StreamWriter sw = new StreamWriter(filesavepath + "\\" + Guid.NewGuid().ToString() + ".txt");
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(textBox1.Text);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                        sw.Write(textBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("请输入文本");
            }
            else
            {
                toolStripStatusLabel1.Text = "正在转换";
                textBox1.Text = Pinyin.GetString(richTextBox1.Text, PinyinFormat.Phonetic);
                toolStripStatusLabel1.Text = "转换成功";
            }
        }

        private void frmPinyin_Load(object sender, EventArgs e)
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
            Height = (int)(385 * scaleFactor);
            Width = (int)(508 * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);
        }
    }
}