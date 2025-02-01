using Microsoft.Office.Interop.Word;
using Sunny.UI;
using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SuperTextToolBox.WordAddIn
{
    public partial class frmMassivePrint : Sunny.UI.UIForm
    {
        public frmMassivePrint()
        {
            InitializeComponent();
        }
        [DllImport("winspool.Drv", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool SetDefaultPrinter(string Name);
        private void frmMassivePrint_Load(object sender, EventArgs e)
        {
            PrinterSettings.StringCollection printers = PrinterSettings.InstalledPrinters;
            foreach (string printer in printers)
            {
                uiComboBox1.Items.Add(printer);
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordapp = Globals.ThisAddIn.Application;
            if (!String.IsNullOrEmpty(uiComboBox1.Text))
            {
                if (SetDefaultPrinter(uiComboBox1.Text))
                {
                    for (int i = 0; i < uiDataGridView1.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = uiDataGridView1.Rows[i];
                        try
                        {


                            // 模拟文件处理
                            Microsoft.Office.Interop.Word.Document doc = wordapp.Documents.Open((string)row.Cells["FileName"].Value);
                            doc.PrintOut(Copies: uiIntegerUpDown1.Value);

                            // 更新状态
                            row.Cells["Status"].Value = "打印成功";
                            doc.Close();
                        }
                        catch (Exception ex)
                        {
                            row.Cells["Status"].Value = "打印失败，错误信息" + ex.Message;
                        }
                    }
                }
                else
                {
                    int errorCode = Marshal.GetLastWin32Error();
                    MessageBox.Show("设置打印机错误，错误代码：" + errorCode);
                }
                Focus();
            }
            else
            {
                MessageBox.Show("无效的打印机");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            uiDataGridView1.ClearRows();
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    uiDataGridView1.Rows.Add(filename, "待打印");
                }
            }
        }
    }
}
