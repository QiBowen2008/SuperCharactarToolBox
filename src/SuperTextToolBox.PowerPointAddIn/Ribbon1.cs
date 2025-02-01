using Microsoft.Office.Tools.Ribbon;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace SuperTextToolBox.PowerPointAddIn
{
    public partial class Ribbon1
    {
        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            frmTranslate ftranslate = new frmTranslate();
            ftranslate.Show();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {

            frmTexttoWave ftexttoWave = new frmTexttoWave();
            ftexttoWave.Show();
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            frmFenci fFenci = new frmFenci();
            fFenci.Show();
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            frmPinyin fpinyin = new frmPinyin();
            fpinyin.Show();
        }

        private void button7_Click(object sender, RibbonControlEventArgs e)
        {
            frmSet set = new frmSet();
            set.Show();
        }

        private void button8_Click(object sender, RibbonControlEventArgs e)
        {
        }

        private void SavePic()
        {
            if (Clipboard.ContainsImage())
            {
                try
                {
                    // 获取剪贴板中的图片
                    Image clipboardImage = Clipboard.GetImage();

                    // 定义要保存图片的路径
                    string savePath = Path.GetTempPath(); // 修改为你需要的路径
                    string fileName = "ClipboardImage_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";


                    // 保存图片到指定路径
                    string fullPath = Path.Combine(savePath, fileName);
                    clipboardImage.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
                    Process.Start("SuperTextToolBox.OCRTool.exe", fullPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void StraghtOpen()
        {
            Process.Start("SuperTextToolBox.OCRTool.exe");
        }

        private void button6_Click(object sender, RibbonControlEventArgs e)
        {
            frmCyjl cyjl = new frmCyjl();
            cyjl.Show();
        }

        private void button13_Click(object sender, RibbonControlEventArgs e)
        {
            frmEachToOne test = new frmEachToOne();
            test.Show();
        }

        private void splitAI_Click(object sender, RibbonControlEventArgs e)
        {
            TaskPaneShared.taskPane.Visible = true;
        }

        private void btnSaveAsPDF_Click(object sender, RibbonControlEventArgs e)
        {
            frmWordToPDF wordToPDF = new frmWordToPDF();
            wordToPDF.Show();
        }

        private void btnMassivePrint_Click(object sender, RibbonControlEventArgs e)
        {
            frmMassivePrint massivePrint = new frmMassivePrint();
            massivePrint.Show();
        }

        private void button9_Click(object sender, RibbonControlEventArgs e)
        {
            frmWordCloud wordCloud = new frmWordCloud();
            wordCloud.Show();
        }
    }
    public static class TaskPaneShared
    {
        public static Microsoft.Office.Tools.CustomTaskPane taskPane;
    }
}



