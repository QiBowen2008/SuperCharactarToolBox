﻿using IKAnalyzerNet;
using Lucene.Net.Analysis;
using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Windows.Forms;
namespace SuperTextToolBox.WordAddIn
{
    public partial class frmFenci : Sunny.UI.UIForm
    {
        public frmFenci()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sd = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(0));
                richTextBox1.Text = sd.ReadToEnd();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string testString = richTextBox1.Text;                  //获取字符串
            string slen = testString.Length.ToString();             //获取字符串长度
            IKAnalyzer ika = new IKAnalyzer();
            TextReader r = new StringReader(testString);
            TokenStream ts = ika.TokenStream("TestField", r);
            int m = 0;
            long begin = DateTime.Now.Ticks;
            for (Token t = ts.Next(); t != null; t = ts.Next())
            {
                m++;                                                 //显示每项分词结果的序列号、起始字符数、结尾字符数
                richTextBox3.Text += m + ")" + (t.StartOffset() + "," + t.EndOffset() + " = " + t.TermText()) + "\r\n";
            }
            int end = (int)((DateTime.Now.Ticks - begin) / 10000);
            richTextBox3.Text += ("长度：" + slen + " 耗时： " + (end) + "ms" + " 分词个数：" + m + " 效率(词/秒)：" + ((int)(m * 1.0f / (end) * 1000))) + "\r\n";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox3.Text))
            {
                MessageBox.Show("请先分词");
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
                        sw.Write(richTextBox3.Text);
                        sw.Flush();
                        sw.Close();
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(richTextBox3.Text);
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
                        sw.Write(richTextBox3.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void frmFenci_Load(object sender, EventArgs e)
        {
            Selection sel = Globals.ThisAddIn.Application.Selection;
            richTextBox1.Text = sel.Text;
        }
    }
}
