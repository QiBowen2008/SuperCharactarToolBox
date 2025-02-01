using Microsoft.Office.Interop.Word;
using System;
using System.Windows.Forms;

namespace SuperTextToolBox.WordAddIn
{
    public partial class frmWordToPDF : Sunny.UI.UIForm
    {
        public frmWordToPDF()
        {
            InitializeComponent();
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    uiDataGridView1.Rows.Add(filename, "待转换");
                }
            }
        }

        private void Transform_Click(object sender, EventArgs e)
        {
            ProcessFiles();
        }
        private void ProcessFiles()
        {
            if (!String.IsNullOrEmpty(uiTextBox1.Text))
            {
                Microsoft.Office.Interop.Word.Application wordapp = Globals.ThisAddIn.Application;
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    try
                    {
                        // 模拟文件处理
                        Microsoft.Office.Interop.Word.Document doc = wordapp.Documents.Open((string)row.Cells["FileName"].Value);
                        doc.SaveAs(@uiTextBox1.Text + "/" + doc.Name + ".pdf", WdSaveFormat.wdFormatPDF);
                        // 更新状态
                        row.Cells["Status"].Value = "输出成功";
                        doc.Close();
                    }
                    catch (Exception ex)
                    {
                        row.Cells["Status"].Value = "输出失败，错误信息" + ex.Message;
                    }
                }
                Focus();
            }
            else
            {
                MessageBox.Show("无效的路径");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearRows();
        }

        private void FolderBroswer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                uiTextBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearSelection();
        }
    }
}
