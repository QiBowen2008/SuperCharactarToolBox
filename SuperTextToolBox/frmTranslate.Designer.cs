namespace SuperTextToolBox
{
    partial class frmTranslate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new Sunny.UI.UITextBox();
            this.textBox1 = new Sunny.UI.UITextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar2 = new Sunny.UI.UITrackBar();
            this.trackBar1 = new Sunny.UI.UITrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new Sunny.UI.UIComboBox();
            this.comboBox2 = new Sunny.UI.UIComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new Sunny.UI.UIComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ucExt1 = new Sunny.UI.UIButton();
            this.ucExt2 = new Sunny.UI.UIButton();
            this.ucExt3 = new Sunny.UI.UIButton();
            this.ucExt4 = new Sunny.UI.UIButton();
            this.ucExt5 = new Sunny.UI.UIButton();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(55, 79);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.richTextBox1.ShowText = false;
            this.richTextBox1.Size = new System.Drawing.Size(391, 179);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.richTextBox1.Watermark = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(55, 305);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(5);
            this.textBox1.ShowText = false;
            this.textBox1.Size = new System.Drawing.Size(391, 184);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBox1.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "原文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "翻译结果";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文档|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文档|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(55, 506);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(391, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频调节";
            // 
            // trackBar2
            // 
            this.trackBar2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trackBar2.Location = new System.Drawing.Point(260, 28);
            this.trackBar2.Maximum = 10;
            this.trackBar2.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(113, 36);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Text = "uiTrackBar2";
            this.trackBar2.Value = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trackBar1.Location = new System.Drawing.Point(70, 34);
            this.trackBar1.Maximum = 10;
            this.trackBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(118, 31);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Text = "uiTrackBar1";
            this.trackBar1.Value = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "语速";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "音量";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(654, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 20);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel2.Text = "字数：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel3.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(47, 20);
            this.toolStripStatusLabel4.Text = "/2000";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = null;
            this.comboBox1.FillColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboBox1.Items.AddRange(new object[] {
            "ara",
            "alb",
            "arg",
            "aym",
            "oss",
            "ori",
            "pl",
            "bak",
            "bel",
            "bul",
            "bem",
            "bal",
            "bho",
            "chv",
            "dan",
            "sha",
            "log",
            "ru",
            "fra",
            "san",
            "fao",
            "gla",
            "hkm",
            "guj",
            "grn",
            "kor",
            "hak",
            "hau",
            "kir",
            "cat",
            "kab",
            "kah",
            "cos",
            "kli",
            "kas",
            "lat",
            "lag",
            "lin",
            "ruy",
            "roh",
            "may",
            "mg",
            "mah",
            "mau",
            "mlt",
            "nor",
            "afr",
            "pt",
            "pus",
            "nya",
            "jp",
            "srd",
            "srp",
            "epo",
            "slo",
            "som",
            "th",
            "tam",
            "tel",
            "ukr",
            "ven",
            "spa",
            "hu",
            "hil",
            "nno",
            "sna",
            "sun",
            "en",
            "it",
            "ina",
            "ibo",
            "arm",
            "zh",
            "yue",
            "zul",
            "gle",
            "arq",
            "amh",
            "aze",
            "est",
            "orm",
            "per",
            "baq",
            "ber",
            "sme",
            "bli",
            "ice",
            "tso",
            "de",
            "tet",
            "fil",
            "fri",
            "kon",
            "kal",
            "gra",
            "nl",
            "ht",
            "glg",
            "cs",
            "kan",
            "cor",
            "cre",
            "hrv",
            "kok",
            "lao",
            "lav",
            "lug",
            "kin",
            "ro",
            "bur",
            "mal",
            "mai",
            "mao",
            "hmn",
            "nea",
            "sot",
            "pan",
            "twi",
            "swe",
            "sm",
            "sol",
            "nob",
            "swa",
            "tr",
            "tgl",
            "tua",
            "wln",
            "wol",
            "heb",
            "fry",
            "los",
            "nqo",
            "ceb",
            "",
            "hi",
            "vie",
            "ach",
            "ido",
            "iku",
            "cht",
            "zaz",
            "jav",
            "oci",
            "aka",
            "asm",
            "ast",
            "oji",
            "bre",
            "pot",
            "pam",
            "ped",
            "bis",
            "bos",
            "tat",
            "div",
            "fin",
            "ful",
            "ups",
            "geo",
            "eno",
            "hup",
            "mot",
            "frn",
            "kau",
            "xho",
            "cri",
            "que",
            "kur",
            "rom",
            "lim",
            "ltz",
            "lit",
            "loj",
            "mar",
            "mac",
            "glv",
            "ben",
            "nbl",
            "nep",
            "pap",
            "chr",
            "sec",
            "sin",
            "sk",
            "src",
            "tgk",
            "tir",
            "tuk",
            "wel",
            "urd",
            "el",
            "sil",
            "haw",
            "snd",
            "syr",
            "id",
            "yid",
            "ing",
            "yor",
            "ir",
            "wyw",
            "frm"});
            this.comboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox1.Location = new System.Drawing.Point(473, 79);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.SymbolSize = 24;
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "en";
            this.comboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox1.Watermark = "";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = null;
            this.comboBox2.FillColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboBox2.Items.AddRange(new object[] {
            "ara",
            "alb",
            "arg",
            "aym",
            "oss",
            "ori",
            "pl",
            "bak",
            "bel",
            "bul",
            "bem",
            "bal",
            "bho",
            "chv",
            "dan",
            "sha",
            "log",
            "ru",
            "fra",
            "san",
            "fao",
            "gla",
            "hkm",
            "guj",
            "grn",
            "kor",
            "hak",
            "hau",
            "kir",
            "cat",
            "kab",
            "kah",
            "cos",
            "kli",
            "kas",
            "lat",
            "lag",
            "lin",
            "ruy",
            "roh",
            "may",
            "mg",
            "mah",
            "mau",
            "mlt",
            "nor",
            "afr",
            "pt",
            "pus",
            "nya",
            "jp",
            "srd",
            "srp",
            "epo",
            "slo",
            "som",
            "th",
            "tam",
            "tel",
            "ukr",
            "ven",
            "spa",
            "hu",
            "hil",
            "nno",
            "sna",
            "sun",
            "en",
            "it",
            "ina",
            "ibo",
            "arm",
            "zh",
            "yue",
            "zul",
            "gle",
            "arq",
            "amh",
            "aze",
            "est",
            "orm",
            "per",
            "baq",
            "ber",
            "sme",
            "bli",
            "ice",
            "tso",
            "de",
            "tet",
            "fil",
            "fri",
            "kon",
            "kal",
            "gra",
            "nl",
            "ht",
            "glg",
            "cs",
            "kan",
            "cor",
            "cre",
            "hrv",
            "kok",
            "lao",
            "lav",
            "lug",
            "kin",
            "ro",
            "bur",
            "mal",
            "mai",
            "mao",
            "hmn",
            "nea",
            "sot",
            "pan",
            "twi",
            "swe",
            "sm",
            "sol",
            "nob",
            "swa",
            "tr",
            "tgl",
            "tua",
            "wln",
            "wol",
            "heb",
            "fry",
            "los",
            "nqo",
            "ceb",
            "",
            "hi",
            "vie",
            "ach",
            "ido",
            "iku",
            "cht",
            "zaz",
            "jav",
            "oci",
            "aka",
            "asm",
            "ast",
            "oji",
            "bre",
            "pot",
            "pam",
            "ped",
            "bis",
            "bos",
            "tat",
            "div",
            "fin",
            "ful",
            "ups",
            "geo",
            "eno",
            "hup",
            "mot",
            "frn",
            "kau",
            "xho",
            "cri",
            "que",
            "kur",
            "rom",
            "lim",
            "ltz",
            "lit",
            "loj",
            "mar",
            "mac",
            "glv",
            "ben",
            "nbl",
            "nep",
            "pap",
            "chr",
            "sec",
            "sin",
            "sk",
            "src",
            "tgk",
            "tir",
            "tuk",
            "wel",
            "urd",
            "el",
            "sil",
            "haw",
            "snd",
            "syr",
            "id",
            "yid",
            "ing",
            "yor",
            "ir",
            "wyw",
            "frm"});
            this.comboBox2.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox2.Location = new System.Drawing.Point(473, 149);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBox2.Size = new System.Drawing.Size(137, 28);
            this.comboBox2.SymbolSize = 24;
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "zh";
            this.comboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox2.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "源语言";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "目标语言";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(471, 199);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 20);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "查看语言字母列表";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "领域选择";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = null;
            this.comboBox3.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBox3.FillColor = System.Drawing.Color.White;
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboBox3.Items.AddRange(new object[] {
            "普通",
            "it",
            "finance",
            "machinery",
            "senimed",
            "novel",
            "academic",
            "aerospace",
            "wiki",
            "news",
            "law",
            "contract"});
            this.comboBox3.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboBox3.Location = new System.Drawing.Point(474, 571);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBox3.Size = new System.Drawing.Size(136, 28);
            this.comboBox3.SymbolSize = 24;
            this.comboBox3.TabIndex = 21;
            this.comboBox3.Text = "普通";
            this.comboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox3.Watermark = "";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(471, 542);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(169, 20);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "查看数字对应列表";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ucExt1
            // 
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.BackColor = System.Drawing.Color.White;
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.ForeColor = System.Drawing.Color.White;
            this.ucExt1.Text = "翻译";
            this.ucExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucExt1.Font = new System.Drawing.Font("微软雅黑", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt1.Location = new System.Drawing.Point(473, 245);
            this.ucExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt1.Name = "ucExt1";
            this.ucExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucExt1.Size = new System.Drawing.Size(137, 29);
            this.ucExt1.TabIndex = 23;
            this.ucExt1.TabStop = false;
            this.ucExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt1.TipsText = "";
            this.ucExt1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucExt2
            // 
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.BackColor = System.Drawing.Color.White;
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.ForeColor = System.Drawing.Color.White;
            this.ucExt2.Text = "打开文本文档";
            this.ucExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt2.FillColor = System.Drawing.Color.Gold;
            this.ucExt2.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt2.Location = new System.Drawing.Point(474, 296);
            this.ucExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt2.Name = "ucExt2";
            this.ucExt2.RectColor = System.Drawing.Color.Gold;
            this.ucExt2.Size = new System.Drawing.Size(136, 29);
            this.ucExt2.TabIndex = 24;
            this.ucExt2.TabStop = false;
            this.ucExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt2.TipsText = "";
            this.ucExt2.Click += new System.EventHandler(this.button4_Click);
            // 
            // ucExt3
            // 
            this.ucExt3.BackColor = System.Drawing.Color.White;
            this.ucExt3.BackColor = System.Drawing.Color.White;
            this.ucExt3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt3.ForeColor = System.Drawing.Color.White;
            this.ucExt3.Text = "保存翻译结果";
            this.ucExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt3.FillColor = System.Drawing.Color.DodgerBlue;
            this.ucExt3.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt3.Location = new System.Drawing.Point(473, 350);
            this.ucExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt3.Name = "ucExt3";
            this.ucExt3.RectColor = System.Drawing.Color.DodgerBlue;
            this.ucExt3.Size = new System.Drawing.Size(137, 29);
            this.ucExt3.TabIndex = 25;
            this.ucExt3.TabStop = false;
            this.ucExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt3.TipsText = "";
            this.ucExt3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ucExt4
            // 
            this.ucExt4.BackColor = System.Drawing.Color.White;
            this.ucExt4.BackColor = System.Drawing.Color.White;
            this.ucExt4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt4.ForeColor = System.Drawing.Color.White;
            this.ucExt4.Text = "朗读结果";
            this.ucExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt4.FillColor = System.Drawing.Color.LimeGreen;
            this.ucExt4.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt4.Location = new System.Drawing.Point(473, 404);
            this.ucExt4.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt4.Name = "ucExt4";
            this.ucExt4.RectColor = System.Drawing.Color.LimeGreen;
            this.ucExt4.Size = new System.Drawing.Size(137, 29);
            this.ucExt4.TabIndex = 26;
            this.ucExt4.TabStop = false;
            this.ucExt4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt4.TipsText = "";
            this.ucExt4.Click += new System.EventHandler(this.button7_Click);
            // 
            // ucExt5
            // 
            this.ucExt5.BackColor = System.Drawing.Color.White;
            this.ucExt5.BackColor = System.Drawing.Color.White;
            this.ucExt5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt5.ForeColor = System.Drawing.Color.White;
            this.ucExt5.Text = "保存结果音频";
            this.ucExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucExt5.FillColor = System.Drawing.Color.BlueViolet;
            this.ucExt5.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucExt5.Location = new System.Drawing.Point(473, 460);
            this.ucExt5.Margin = new System.Windows.Forms.Padding(0);
            this.ucExt5.Name = "ucExt5";
            this.ucExt5.RectColor = System.Drawing.Color.BlueViolet;
            this.ucExt5.Size = new System.Drawing.Size(137, 29);
            this.ucExt5.TabIndex = 26;
            this.ucExt5.TabStop = false;
            this.ucExt5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucExt5.TipsText = "";
            this.ucExt5.Click += new System.EventHandler(this.button8_Click);
            // 
            // frmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(654, 652);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.ucExt5);
            this.Controls.Add(this.ucExt4);
            this.Controls.Add(this.ucExt3);
            this.Controls.Add(this.ucExt2);
            this.Controls.Add(this.ucExt1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTranslate";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "翻译";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 641, 596);
            this.Load += new System.EventHandler(this.frmTranslate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Sunny.UI.UITextBox richTextBox1;
        private Sunny.UI.UITextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private Sunny.UI.UIComboBox comboBox1;
        private Sunny.UI.UIComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UIComboBox comboBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Sunny.UI.UIButton ucExt1;
        private Sunny.UI.UIButton ucExt2;
        private Sunny.UI.UIButton ucExt3;
        private Sunny.UI.UIButton ucExt4;
        private Sunny.UI.UIButton ucExt5;
        private Sunny.UI.UITrackBar trackBar2;
        private Sunny.UI.UITrackBar trackBar1;
    }
}