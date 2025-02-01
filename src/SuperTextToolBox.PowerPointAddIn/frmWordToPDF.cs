using Microsoft.Office.Interop.PowerPoint ;
using System;
using System.Windows.Forms;

namespace SuperTextToolBox.PowerPointAddIn
{
    public partial class frmWordToPDF : Sunny.UI.UIForm
    {
        public frmWordToPDF()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    uiDataGridView1.Rows.Add(filename, "待转换");
                }
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            ProcessFiles();
        }
        private void ProcessFiles()
        {
            if (!String.IsNullOrEmpty(uiTextBox1.Text))
            {
                Microsoft.Office.Interop.PowerPoint.Application wordapp = Globals.ThisAddIn.Application;
                for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = uiDataGridView1.Rows[i];
                    try
                    {


                        // 模拟文件处理
                        Microsoft.Office.Interop.PowerPoint.Presentation doc = wordapp.Presentations.Open((string)row.Cells["FileName"].Value);

                        doc.SaveAs(@uiTextBox1.Text + "/" + doc.Name + ".pdf", PpSaveAsFileType.ppSaveAsPDF);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearRows();
        }

        private void btnFolderBroswer_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                uiTextBox1.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearSelection();
        }
    }
}
