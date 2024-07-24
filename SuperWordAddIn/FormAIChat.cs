using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SuperWenZiToolBox 
{
    public partial class frmAIChat : Sunny .UI .UIForm 
    {
        public frmAIChat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当前消息气泡起始位置
        /// </summary>
        private int top = 0;

        /// <summary>
        /// 当前消息气泡高度
        /// </summary>
        private int height = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = AITool. GetAnswer(textBox1.Text).answer;
            string windowsFormattedResult = tmp.Replace("\n", Environment.NewLine);
            try
            {
                AddReceiveMessage(windowsFormattedResult);
            }
            catch(Exception ex)
            {
                AddReceiveMessage(ex.Message); 
            }
        }

        /// <summary>
        /// 显示接收消息
        /// </summary>
        /// <param name="model"></param>
        private void AddReceiveMessage(string content)
        {
            textBox2.Text = content;
        }

        // <summary>
        /// 更新界面，显示发送消息
        /// </summary>

        private void Form1_Load(object sender, EventArgs e)
        {
            if (AITool.type == "AI生成内容")
            {

            }
        }
    }

}
