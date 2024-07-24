namespace SuperWenZiToolBox
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.splitButton3 = this.Factory.CreateRibbonSplitButton();
            this.button12 = this.Factory.CreateRibbonButton();
            this.button13 = this.Factory.CreateRibbonButton();
            this.button14 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.splitButton1 = this.Factory.CreateRibbonSplitButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.splitButton2 = this.Factory.CreateRibbonSplitButton();
            this.button16 = this.Factory.CreateRibbonButton();
            this.button17 = this.Factory.CreateRibbonButton();
            this.button18 = this.Factory.CreateRibbonButton();
            this.button15 = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group4.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "万能文字工具箱";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.button3);
            this.group1.Items.Add(this.button4);
            this.group1.Items.Add(this.button5);
            this.group1.Items.Add(this.button9);
            this.group1.Items.Add(this.button11);
            this.group1.Items.Add(this.splitButton3);
            this.group1.Label = "文字处理";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.button6);
            this.group2.Label = "文字游戏";
            this.group2.Name = "group2";
            // 
            // group4
            // 
            this.group4.Items.Add(this.splitButton1);
            this.group4.Items.Add(this.label1);
            this.group4.Label = "AI工具";
            this.group4.Name = "group4";
            // 
            // label1
            // 
            this.label1.Label = "由通义千问提供支持";
            this.label1.Name = "label1";
            // 
            // group3
            // 
            this.group3.Items.Add(this.button7);
            this.group3.Items.Add(this.button8);
            this.group3.Label = "选项";
            this.group3.Name = "group3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::SuperWordAddIn.Properties.Resources.iBV1;
            this.button1.Label = "OCR";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.SuperTip = "OCR识别，支持图片转文字，转xlsx";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.OCRText);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = global::SuperWordAddIn.Properties.Resources.Jln;
            this.button2.Label = "翻译";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.SuperTip = "需要再设置里输入百度翻译Api信息";
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Image = global::SuperWordAddIn.Properties.Resources.Ftj;
            this.button3.Label = "文字朗读";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.SuperTip = "利用System.Speech离线朗读";
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button4.Image = global::SuperWordAddIn.Properties.Resources.d5b2b10e_d147_4157_8091_5103d29f0804;
            this.button4.Label = "中文分词";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button5.Image = global::SuperWordAddIn.Properties.Resources.jhffhdhdfhd;
            this.button5.Label = "文字转拼音";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button9.Image = global::SuperWordAddIn.Properties.Resources._76b154fe9c0c5a49b37da3d5a21fe25a;
            this.button9.Label = "词云生成";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            // 
            // button11
            // 
            this.button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button11.Image = global::SuperWordAddIn.Properties.Resources.iBV222;
            this.button11.Label = "语种识别";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            this.button11.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button11_Click);
            // 
            // splitButton3
            // 
            this.splitButton3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.splitButton3.Image = global::SuperWordAddIn.Properties.Resources.MORE;
            this.splitButton3.Items.Add(this.button12);
            this.splitButton3.Items.Add(this.button13);
            this.splitButton3.Items.Add(this.button14);
            this.splitButton3.Label = "更多功能";
            this.splitButton3.Name = "splitButton3";
            // 
            // button12
            // 
            this.button12.Label = "图片压缩";
            this.button12.Name = "button12";
            this.button12.ShowImage = true;
            // 
            // button13
            // 
            this.button13.Label = "文档合并";
            this.button13.Name = "button13";
            this.button13.ShowImage = true;
            this.button13.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Label = "文档提取页面";
            this.button14.Name = "button14";
            this.button14.ShowImage = true;
            // 
            // button6
            // 
            this.button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button6.Image = global::SuperWordAddIn.Properties.Resources.cyjl;
            this.button6.Label = "成语接龙";
            this.button6.Name = "button6";
            this.button6.ShowImage = true;
            this.button6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button6_Click);
            // 
            // splitButton1
            // 
            this.splitButton1.Items.Add(this.button10);
            this.splitButton1.Items.Add(this.splitButton2);
            this.splitButton1.Items.Add(this.button15);
            this.splitButton1.Label = "AI工具";
            this.splitButton1.Name = "splitButton1";
            // 
            // button10
            // 
            this.button10.Label = "AI解读文档";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            // 
            // splitButton2
            // 
            this.splitButton2.Items.Add(this.button16);
            this.splitButton2.Items.Add(this.button17);
            this.splitButton2.Items.Add(this.button18);
            this.splitButton2.Label = "AI文档优化";
            this.splitButton2.Name = "splitButton2";
            // 
            // button16
            // 
            this.button16.Label = "缩写";
            this.button16.Name = "button16";
            this.button16.ShowImage = true;
            // 
            // button17
            // 
            this.button17.Label = "扩写";
            this.button17.Name = "button17";
            this.button17.ShowImage = true;
            // 
            // button18
            // 
            this.button18.Label = "继续写";
            this.button18.Name = "button18";
            this.button18.ShowImage = true;
            // 
            // button15
            // 
            this.button15.Label = "AI生成内容";
            this.button15.Name = "button15";
            this.button15.ShowImage = true;
            // 
            // button7
            // 
            this.button7.Label = "设置";
            this.button7.Name = "button7";
            this.button7.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Label = "关于";
            this.button8.Name = "button8";
            this.button8.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button8_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton splitButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button12;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button13;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button14;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button16;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button17;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button18;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button15;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
