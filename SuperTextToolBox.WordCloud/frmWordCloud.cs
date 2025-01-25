﻿using JiebaNet.Analyser;
using JiebaNet.Segmenter;
using JiebaNet.Segmenter.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WordCloudSharp;
namespace SuperTextToolBox.WordCloudTool
{
    public partial class frmWordCloud : Sunny.UI.UIForm
    {
        public string maskpic = "";
        public frmWordCloud()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            toolStripStatusLabel1.Text = "生成中";
            if (radioButton1.Checked == true)
            {
                string text = textBox1.Text;
                var wordWeight = ExtractTagsWithWeight(text);
                var wordFreqs = Counter(text, wordWeight);
                CreateWordCloud1(wordFreqs);
                pictureBox1.Image = Image.FromFile("result.jpg");
                toolStripStatusLabel1.Text = "生成成功";
            }
            else
            {
                string text = textBox1.Text;
                var wordWeight = ExtractTagsWithWeight(text);
                var wordFreqs = Counter(text, wordWeight);
                CreateWordCloud2(wordFreqs, maskpic);
                pictureBox1.Image = Image.FromFile("result.jpg");
                toolStripStatusLabel1.Text = "生成成功";
            }
            uiButton3.Enabled = true;
        }
        /// <summary>
        /// 从指定文本中抽取关键词的同时得到其权重
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static WordWeightPair[] ExtractTagsWithWeight(string text)
        {
            var extractor = new TfidfExtractor();
            var wordWeight = extractor.ExtractTagsWithWeight(text, 50);
            StringBuilder sbr = new StringBuilder();
            sbr.Append("词语");
            sbr.Append(",");
            sbr.Append("权重");
            sbr.AppendLine(",");
            foreach (var item in wordWeight)
            {
                sbr.Append(item.Word);
                sbr.Append(",");
                sbr.Append(item.Weight);
                sbr.AppendLine(",");
            }
            return wordWeight.ToArray();
        }
        static KeyValuePair<string, int>[] Counter(string text, WordWeightPair[] wordWeightAry)
        {
            var segmenter = new JiebaSegmenter();
            var segments = segmenter.Cut(text);
            var freqs = new Counter<string>(segments);
            KeyValuePair<string, int>[] countAry = new KeyValuePair<string, int>[wordWeightAry.Length];
            for (int i = 0; i < wordWeightAry.Length; i++)
            {
                string key = wordWeightAry[i].Word;
                countAry[i] = new KeyValuePair<string, int>(key, freqs[key]);
            }
            StringBuilder sbr = new StringBuilder();
            sbr.Append("词语");
            sbr.Append(",");
            sbr.Append("词频");
            sbr.AppendLine(",");
            foreach (var pair in countAry)
            {
                sbr.Append(pair.Key);
                sbr.Append(",");
                sbr.Append(pair.Value);
                sbr.AppendLine(",");
            }
            return countAry;
        }
        /// <summary>
        /// 创建词云图
        /// </summary>
        /// <param name="countAry"></param>
        static void CreateWordCloud1(KeyValuePair<string, int>[] countAry)
        {
            string resultPath = "result.jpg";
            //使用蒙版图片
            //var wordCloud = new WordCloud(mask.Width, mask.Height, mask: mask, allowVerical: true, fontname: "YouYuan");
            //不使用蒙版图片
            var wordCloud = new WordCloud(1000, 1000, false, null, -1, 1, null, false);
            var result = wordCloud.Draw(countAry.Select(it => it.Key).ToList(), countAry.Select(it => it.Value).ToList());
            result.Save(resultPath);
        }
        static void CreateWordCloud2(KeyValuePair<string, int>[] countAry, string markPath)
        {
            string resultPath = "result.jpg";
            Console.WriteLine("开始生成图片，读取蒙版：" + markPath);
            Image mask = Image.FromFile(markPath);
            //使用蒙版图片
            var wordCloud = new WordCloud(mask.Width, mask.Height, mask: mask, allowVerical: true, fontname: "YouYuan");
            //不使用蒙版图片
            //var wordCloud = new WordCloud(1000, 1000,false, null,-1,1,null, false);
            var result = wordCloud.Draw(countAry.Select(it => it.Key).ToList(), countAry.Select(it => it.Value).ToList());
            result.Save(resultPath);
            Console.WriteLine("图片生成完成，保存图片：" + resultPath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("result.jpg"))
            {
                File.Delete("result.jpg");
            }
            radioButton1.Checked = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() =>
            {
                saveFileDialog1.ShowDialog();

            }
));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            File.Copy("result.jpg", saveFileDialog1.FileName, true);
            toolStripStatusLabel1.Text = "保存图片成功"; // 将出现这个异常的语句放到这里面
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread((ThreadStart)(() =>
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                }
            }
));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            textBox1.Text = sr.ReadToEnd();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("mask1s.jpg");
            maskpic = "mask1.png";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("mask2s.jpg");
            maskpic = "mask2.png";
        }
    }
}
