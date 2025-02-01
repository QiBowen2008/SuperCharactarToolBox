using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.PowerPoint;

namespace SuperTextToolBox.PowerPointAddIn
{
    public partial class frmEachToOne : Sunny.UI.UIForm
    {
        public frmEachToOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadlist();
            AddNewItem();
        }
        List<string> tmp;
        public void AddNewItem()
        {
            List<string> newArray = new List<string>(openFileDialog1.FileNames.Length + (openFileDialog1.FileName.Length / 2));
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                newArray.Add(openFileDialog1.FileNames[i]);
                newArray.Add("C:\\Users\\qdqy\\Desktop\\HELP.docx");
                tmp = newArray;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void loadlist()
        {
            listBox1.Items.Clear();
            openFileDialog1.ShowDialog();
            listBox1.Items.AddRange(openFileDialog1.FileNames);
        }
        public void CopyContentAndMerge()
        {

            saveFileDialog1.ShowDialog();

            string outputFileName = saveFileDialog1.FileName;
            // 获取当前Word应用程序实例
            // 1. 在指定位置新建一个空白docx文档，命名为文档2
            Microsoft.Office.Interop.PowerPoint.Application wordApp = Globals.ThisAddIn.Application;

            Presentation  doc2 = wordApp.Presentations .Add();
            string doc2Path = saveFileDialog1.FileName;
            doc2.SaveAs(doc2Path, PpSaveAsFileType.ppSaveAsDefault);
            // 2. 打开文档1，复制文档全部内容到剪切板
            Presentation doc1;
            foreach (string filename in tmp)
            {

            }
            // 6. 保存并关闭文档2
            doc2.Save();
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            CopyContentAndMerge();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex > 0)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex - 1, selectedItem);
                listBox1.SetSelected(selectedIndex - 1, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count - 1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(selectedIndex);
                listBox1.Items.Insert(selectedIndex + 1, selectedItem);
                listBox1.SetSelected(selectedIndex + 1, true);
            }
        }

        private void frmeachtoone_Load(object sender, EventArgs e)
        {

        }
    }
}
