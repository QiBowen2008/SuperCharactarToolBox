using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;

namespace SuperTextToolBox.WordAddIn
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
            Microsoft.Office.Interop.Word.Application wordApp = Globals.ThisAddIn.Application;

            Document doc2 = wordApp.Documents.Add();
            string doc2Path = saveFileDialog1.FileName;
            doc2.SaveAs(doc2Path, WdSaveFormat.wdFormatDocumentDefault);
            // 2. 打开文档1，复制文档全部内容到剪切板
            Document doc1;
            foreach (string filename in tmp)
            {
                doc1 = wordApp.Documents.Open(filename);
                doc1.Activate();
                doc1.Range().CopyAsPicture();
                // 3. 关闭文档1
                doc1.Close(false); // 不保存更改
                // 4. 打开文档2，粘贴剪切板内容
                doc2.Activate();
                Microsoft.Office.Interop.Word.Paragraph newParagraph = doc2.Content.Paragraphs.Add();
                Microsoft.Office.Interop.Word.Range targetRange = doc2.Range(doc2.Content.End - 1, doc2.Content.End); // 指定插入位置
                targetRange.Paste(); // 从剪切板粘贴内容到目标位置
                doc1 = null;
            }
            // 6. 保存并关闭文档2
            doc2.Save();
            doc2.Close(false);
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
