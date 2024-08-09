using System;
using System.Drawing;
using Sunny.UI;
using System.Windows.Forms;
using PaddleOCRSharp;
using System.Diagnostics;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace SuperTextToolBox.OCRTool
{
    public partial class OCRFull : UIForm
    {
        private Dictionary<string, string> langmodel;
        public OCRFull()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            langmodel = new Dictionary<string, string>
            {
                {"日文","japan" },
                {"韩文","korean" },
                {"泰卢固文","te" },
                {"卡纳达文","ka" },
                {"泰米尔文","ta"},
                {"拉丁文","latin" },
                {"阿拉伯文","arabic" },
                {"斯拉夫文","cyrillic" },
                {"梵文","devanagari" }
            };
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                string imagePath = Environment.GetCommandLineArgs()[1];
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uiComboBox1.Text = "中英文精简（自带）";
            if (canshu.fromword == true)
            {
                pictureBox1.Image = Image.FromFile(canshu.path);
            }
        }

        private void OCR(string imagepath, string type)
        {
            try
            {
                string modelPathroot = Application.StartupPath + "\\OCRModel";
                OCRModelConfig config = new OCRModelConfig();
                StructureModelConfig xlsxconfig = new StructureModelConfig();
                toolStripStatusLabel1.Text = "识别中";

                //使用默认中英文V3模型
                pictureBox1.Image = Image.FromFile(imagepath);
                xlsxconfig.table_char_dict_path = modelPathroot + @"\table_structure_dict_ch.txt";
                if (uiComboBox1.Text == "中英文精简（自带）")
                {

                    config.det_infer = modelPathroot + @"\ch_PP-OCRv4_det_infer";
                    config.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                    config.rec_infer = modelPathroot + @"\REC\ch_PP-OCRv4_rec_infer";
                    config.keys = modelPathroot + @"\ppocr_keys.txt";
                    xlsxconfig.det_infer = modelPathroot + @"\ch_PP-OCRv4_det_infer";
                    xlsxconfig.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                    xlsxconfig.rec_infer = modelPathroot + @"\REC\ch_PP-OCRv4_rec_infer";
                    xlsxconfig.keys = modelPathroot + @"\ppocr_keys.txt";
                    xlsxconfig.table_model_dir = modelPathroot + @"\ch_ppstructure_mobile_v2.0_SLANet_infer";
                }
                else if (uiComboBox1.Text == "中英文高级")
                {
                    config.det_infer = modelPathroot + @"\ch_PP-OCRv4_det_server_infer";
                    config.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                    config.rec_infer = modelPathroot + @"\REC\ch_PP-OCRv4_rec_server_infer";
                    config.keys = modelPathroot + @"\ppocr_keys.txt";
                    xlsxconfig.det_infer = modelPathroot + @"\ch_PP-OCRv4_det_server_infer";
                    xlsxconfig.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                    xlsxconfig.rec_infer = modelPathroot + @"\REC\ch_PP-OCRv4_rec_server_infer";
                    xlsxconfig.keys = modelPathroot + @"\ppocr_keys.txt";
                    xlsxconfig.table_model_dir = modelPathroot + @"\ch_ppstructure_mobile_v2.0_SLANet_infer";

                }
                else
                {
                    string selectedlang = uiComboBox1.SelectedItem as string;
                    if (langmodel.TryGetValue(selectedlang, out string outputlang))
                    {
                        config.det_infer = modelPathroot + @"\Multilingual_PP-OCRv3_det_slim_infer";
                        config.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                        config.rec_infer = modelPathroot + @"\REC\" + outputlang + "_PP-OCRv3_rec_infer";
                        config.keys = modelPathroot + @"\LangDict\" + outputlang + "_dict.txt";
                        xlsxconfig.det_infer = modelPathroot + @"\Multilingual_PP-OCRv3_det_slim_infer";
                        xlsxconfig.cls_infer = modelPathroot + @"\ch_ppocr_mobile_v2.0_cls_infer";
                        xlsxconfig.rec_infer = modelPathroot + @"\REC\" + outputlang + "_PP-OCRv3_rec_infer";
                        xlsxconfig.keys = modelPathroot + @"\LangDict\" + outputlang + "_dict.txt";
                        xlsxconfig.table_model_dir = modelPathroot + @"\ch_ppstructure_mobile_v2.0_SLANet_infer";

                    }
                }
                if (type == "图片转文字")
                {
                    OCRParameter oCRParameter = new OCRParameter();
                    //识别结果对象
                    OCRResult ocrResult = new OCRResult();
                    //建议程序全局初始化一次即可，不必每次识别都初始化，容易报错。     
                    PaddleOCREngine engine = new PaddleOCREngine(config, oCRParameter);
                    ocrResult = engine.DetectText(imagepath);
                    if (ocrResult != null)
                    {
                        textBox1.Text = ocrResult.Text;
                    }
                    engine.Dispose();
                }
                else
                {
                    StructureParameter structureParameter = new StructureParameter();
                    //初始化表格识别引擎
                    PaddleStructureEngine engine = new PaddleOCRSharp.PaddleStructureEngine(xlsxconfig, structureParameter);
                    //表格识别，返回结果是html格式的表格形式
                    string result = engine.StructureDetectFile(imagepath);

                    //添加边框线，方便查看效果
                    string css = "<style>table{ border-spacing: 0pt;} td { border: 1px solid black;}</style>";
                    result = result.Replace("<html>", "<html>" + css);

                    //保存到本地
                    string name = Path.GetFileNameWithoutExtension(imagepath);
                    if (!Directory.Exists(Environment.CurrentDirectory + "\\out"))
                    { Directory.CreateDirectory(Environment.CurrentDirectory + "\\out"); }
                    string savefile = $"{Environment.CurrentDirectory}\\out\\{name}.html";
                    File.WriteAllText(savefile, result);
                    try
                    {
                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                            var htmlTable = new HtmlAgilityPack.HtmlDocument();
                            htmlTable.LoadHtml(result);
                            var table = htmlTable.DocumentNode.SelectSingleNode("//table");
                            int row = 1, col = 1;
                            foreach (var tr in table.SelectNodes(".//tr"))
                            {
                                col = 1;
                                foreach (var td in tr.SelectNodes(".//td|.//th"))
                                {
                                    worksheet.Cells[row, col].Value = td.InnerText;
                                    col++;
                                }
                                row++;
                            }
                            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                            {
                                package.SaveAs(saveFileDialog2.FileName);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("保存为xlsx失败，已经为您保存好html格式，修复可以试试在控制面板找到程序和功能-打开或关闭Windows功能，打开NetFramwork3.5");
                        toolStripStatusLabel1.Text = "未完全成功";
                    }


                }
                toolStripStatusLabel1.Text = "成功";
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误，请检查是否下载了指定的模型，错误信息" + ex.Message);
                toolStripStatusLabel1.Text = "错误";
            }

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片|*.png;*.jpg;*.jpeg;*.tiff;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            canshu.path = ofd.FileName;
            canshu.ocrtype = uiComboBox2.Text;
            pictureBox1.Image = Image.FromFile(canshu.path);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://gitee.com/Qibowen2008/SuperTextToolBox/blob/main/models_list.md");
            }
            catch
            {
                formtip formtips = new formtip();
                formtips.Show();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请先识别");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            OCR(canshu.path, uiComboBox2 .Text );
        }
    }
}
