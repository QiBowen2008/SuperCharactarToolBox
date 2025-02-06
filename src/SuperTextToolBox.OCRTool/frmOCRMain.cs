using System;
using System.IO;
using System.Drawing;
using Sunny.UI;
using System.Windows.Forms;
using PaddleOCRSharp;
using System.Diagnostics;
using OfficeOpenXml;
using System.Collections.Generic;

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
                uiDataGridView1.Rows.Add(imagePath, "待转换");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                if (control is UIDataGridView uidatagridview)
                {
                    uidatagridview.RowTemplate.Height = (int)(uidatagridview.RowTemplate.Height * scaleFactor);
                    foreach (DataGridViewColumn dataGridViewColumn in uidatagridview.Columns)
                    {
                        dataGridViewColumn.Width = (int)(dataGridViewColumn.Width * scaleFactor);
                    }
                }
                if(control is UIComboBox comboBox)
                {
                    comboBox.ItemHeight = (int)(comboBox.ItemHeight * scaleFactor);
                }
            }
            Height = (int)(Height * scaleFactor);
            Width = (int)(Width * scaleFactor);
            titleHeight = Convert.ToInt32(titleHeight * scaleFactor);  
            uiComboBox1.Text = "中英文精简（自带）";
        }

        private string OCR(string imagepath, string type, string path)
        {
            try
            {
                string modelPathroot = Application.StartupPath + "\\OCRModel";
                OCRModelConfig config = new OCRModelConfig();
                StructureModelConfig xlsxconfig = new StructureModelConfig();
                toolStripStatusLabel1.Text = "识别中";

                //使用默认中英文V3模型

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
                    ocrResult = engine.DetectText(path);
                    string result;
                    if (ocrResult != null)
                    {
                        result = ocrResult.Text;
                    }
                    else
                    {
                        result = "图片中无可识别文本";
                    }
                    engine.Dispose();
                    return result;
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
                        return "Successfully Saved";
                    }
                    catch
                    {
                        MessageBox.Show("保存为xlsx失败，已经为您保存好html格式，修复可以试试在控制面板找到程序和功能-打开或关闭Windows功能，打开NetFramwork3.5");
                        toolStripStatusLabel1.Text = "未完全成功";
                        return "ERROR!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误，请检查是否下载了指定的模型，错误信息" + ex.Message);
                toolStripStatusLabel1.Text = "错误";
                return "ERROR!";
            }

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "图片|*.png;*.jpg;*.jpeg;*.tiff;*.bmp";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            uiButton3.Enabled = true;
            foreach (string filename in ofd.FileNames)
            {
                uiDataGridView1.Rows.Add(filename, "待转换");
            }
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
            uiButton3.Enabled = false;
            if (uiCheckBox1.Checked == true)
            {
                folderBrowserDialog1.ShowDialog();
            }
            for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = uiDataGridView1.Rows[i];
                if (uiCheckBox1.Checked == true)
                {
                    string eachresult = OCR(canshu.path, uiComboBox2.Text, (string)row.Cells["FileName"].Value);
                    DateTime now = DateTime.Now;
                    // 将时间转换为毫秒级的时间戳
                    long milliseconds = now.Ticks / TimeSpan.TicksPerMillisecond;
                    string outputFilePath = Path.Combine(folderBrowserDialog1.SelectedPath, milliseconds.ToString() + ".txt");
                    StreamWriter sw = new StreamWriter(outputFilePath);
                    sw.Write(eachresult);
                    sw.Flush();
                    sw.Dispose();
                }
                else
                {
                    textBox1.Text = textBox1.Text + OCR(canshu.path, uiComboBox2.Text, (string)row.Cells["FileName"].Value);
                }
                row.Cells["Status"].Value = "转换成功";
            }
        }
    }
}
