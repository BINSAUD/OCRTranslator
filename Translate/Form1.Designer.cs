namespace Translate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aPIKeyToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dropDown = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            cBFromLanguage = new ComboBox();
            cBToLanguage = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(571, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(46, 51, 73);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(367, 247);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 51, 73);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(417, 67);
            button2.Name = "button2";
            button2.Size = new Size(93, 71);
            button2.TabIndex = 3;
            button2.Text = "Translate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(404, 161);
            button3.Name = "button3";
            button3.Size = new Size(125, 70);
            button3.TabIndex = 4;
            button3.Text = "ScreenShoot";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "Veni";
            notifyIcon.BalloonTipTitle = "Title";
            notifyIcon.ContextMenuStrip = contextMenuStrip1;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Translate";
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(46, 51, 73);
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.None;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(102, 26);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = Color.White;
            closeToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            closeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            closeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(101, 22);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(53, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Transparent;
            fileToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, aPIKeyToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            fileToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(45, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.FromArgb(46, 51, 73);
            exitToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            exitToolStripMenuItem.ImageTransparentColor = Color.FromArgb(46, 51, 73);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aPIKeyToolStripMenuItem
            // 
            aPIKeyToolStripMenuItem.BackColor = Color.FromArgb(46, 51, 73);
            aPIKeyToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            aPIKeyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem });
            aPIKeyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            aPIKeyToolStripMenuItem.ImageTransparentColor = Color.FromArgb(46, 51, 73);
            aPIKeyToolStripMenuItem.Name = "aPIKeyToolStripMenuItem";
            aPIKeyToolStripMenuItem.Size = new Size(181, 24);
            aPIKeyToolStripMenuItem.Text = "API Key DeepL";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.BackColor = Color.FromArgb(46, 51, 73);
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(123, 24);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.BackColor = Color.FromArgb(46, 51, 73);
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(123, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // dropDown
            // 
            dropDown.BackColor = Color.FromArgb(46, 51, 73);
            dropDown.DropDownHeight = 189;
            dropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDown.FlatStyle = FlatStyle.Flat;
            dropDown.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dropDown.ForeColor = Color.Black;
            dropDown.FormattingEnabled = true;
            dropDown.ImeMode = ImeMode.NoControl;
            dropDown.IntegralHeight = false;
            dropDown.Items.AddRange(new object[] { "DeepL Translator", "Google Translator", "Microsoft Translator", "Bing Translator", "Yandex Translator" });
            dropDown.Location = new Point(376, 13);
            dropDown.Margin = new Padding(0);
            dropDown.Name = "dropDown";
            dropDown.RightToLeft = RightToLeft.No;
            dropDown.Size = new Size(189, 28);
            dropDown.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(856, 3);
            button1.Name = "button1";
            button1.Size = new Size(39, 26);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dropDown);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 253);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(901, 3);
            button4.Name = "button4";
            button4.Size = new Size(39, 26);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // cBFromLanguage
            // 
            cBFromLanguage.BackColor = Color.FromArgb(46, 51, 73);
            cBFromLanguage.DropDownHeight = 189;
            cBFromLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cBFromLanguage.FlatStyle = FlatStyle.Flat;
            cBFromLanguage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBFromLanguage.ForeColor = Color.Black;
            cBFromLanguage.FormattingEnabled = true;
            cBFromLanguage.ImeMode = ImeMode.NoControl;
            cBFromLanguage.IntegralHeight = false;
            cBFromLanguage.Items.AddRange(new object[] { "Afrikaans", "Amharic", "Arabic", "Assamese", "Azerbaijani", "AzerbaijaniCyrilic", "Belarusian", "Bengali", "Tibetan", "Bosnian", "Breton", "Bulgarian", "CatalanValencian", "Cebuano", "Czech", "ChineseSimplified", "ChineseTraditional", "Cherokee", "Corsican", "Welsh", "Danish", "DanishFraktur", "German", "GermanFrakturContrib", "Dzongkha", "GreekModern", "English", "EnglishMiddle", "Esperanto", "Math", "Estonian", "Basque", "Faroese", "Persian", "Filipino", "Finnish", "French", "GermanFraktur", "FrenchMiddle", "WesternFrisian", "ScottishGaelic", "Irish", "Galician", "GreekAncientContrib", "Gujarati", "Haitian", "Hebrew", "Hindi", "Croatian", "Hungarian", "Armenian", "Inuktitut", "Indonesian", "Icelandic", "Italian", "ItalianOld", "Javanese", "Japanese", "JapaneseVertical", "Kannada", "Georgian", "GeorgianOld", "Kazakh", "CentralKhmer", "KirghizKyrgyz", "Kurmanji", "Korean", "KoreanVertical", "KurdishArabicScript", "Lao", "Latin", "Latvian", "Lithuanian", "Luxembourgish", "Malayalam", "Marathi", "Macedonian", "Maltese", "Mongolian", "Maori", "Malay", "Burmese", "Nepali", "Dutch", "Norwegian", "Occitan", "Oriya", "Osd", "Panjabi", "Polish", "Portuguese", "Pushto", "Quechua", "Romanian", "Russian", "Sanskrit", "Sinhala", "Slovak", "SlovakFrakturContrib", "Slovenian", "Sindhi", "SpanishCastilian", "SpanishCastilianOld", "Albanian", "Serbian", "SerbianLatin", "Sundanese", "Swahili", "Swedish", "Syriac", "Tamil", "Tatar", "Telugu", "Tajik", "Tagalog", "Thai", "Tigrinya", "Tonga", "Turkish", "Uighur", "Ukrainian", "Urdu", "Uzbek", "UzbekCyrilic", "Vietnamese", "Yiddish", "Yoruba" });
            cBFromLanguage.Location = new Point(181, 3);
            cBFromLanguage.Margin = new Padding(0);
            cBFromLanguage.Name = "cBFromLanguage";
            cBFromLanguage.RightToLeft = RightToLeft.No;
            cBFromLanguage.Size = new Size(189, 28);
            cBFromLanguage.TabIndex = 7;
            cBFromLanguage.SelectedIndexChanged += cBFromLanguage_SelectedIndexChanged;
            // 
            // cBToLanguage
            // 
            cBToLanguage.BackColor = Color.FromArgb(46, 51, 73);
            cBToLanguage.DropDownHeight = 189;
            cBToLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cBToLanguage.FlatStyle = FlatStyle.Flat;
            cBToLanguage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cBToLanguage.ForeColor = Color.Black;
            cBToLanguage.FormattingEnabled = true;
            cBToLanguage.ImeMode = ImeMode.NoControl;
            cBToLanguage.IntegralHeight = false;
            cBToLanguage.Items.AddRange(new object[] { "aa", "ab", "ae", "af", "ak", "am", "an", "ar", "as", "av", "ay", "az", "ba", "be", "bg", "bh", "bi", "bm", "bn", "bo", "br", "bs", "ca", "ce", "ch", "co", "cr", "cs", "cu", "cv", "cy", "da", "de", "dv", "dz", "ee", "el", "en", "en-US", "en-GB", "eo", "es", "et", "eu", "fa", "ff", "fi", "fj", "fo", "fr", "fy", "ga", "gd", "gl", "gn", "gu", "gv", "ha", "he", "hi", "ho", "hr", "ht", "hu", "hy", "hz", "ia", "id", "ie", "ig", "ii", "ik", "io", "is", "it", "iu", "ja", "jv", "ka", "kg", "ki", "kj", "kk", "kl", "km", "kn", "ko", "kr", "ks", "ku", "kv", "kw", "ky", "la", "lb", "lg", "li", "ln", "lo", "lt", "lu", "lv", "mg", "mh", "mi", "mk", "ml", "mn", "mr", "ms", "mt", "my", "na", "nb", "nd", "ne", "ng", "nl", "nn", "no", "nr", "nv", "ny", "oc", "oj", "om", "or", "os", "pa", "pi", "pl", "ps", "pt", "pt-BR", "pt-PT", "qu", "rm", "rn", "ro", "ru", "rw", "sa", "sc", "sd", "se", "sg", "si", "sk", "sl", "sm", "sn", "so", "sq", "sr", "ss", "st", "su", "sv", "sw", "ta", "te", "tg", "th", "ti", "tk", "tl", "tn", "to", "tr", "ts", "tt", "tw", "ty", "ug", "uk", "ur", "uz", "ve", "vi", "vo", "wa", "wo", "xh", "yi", "yo", "za", "zh", "zu" });
            cBToLanguage.Location = new Point(571, 3);
            cBToLanguage.Margin = new Padding(0);
            cBToLanguage.Name = "cBToLanguage";
            cBToLanguage.RightToLeft = RightToLeft.No;
            cBToLanguage.Size = new Size(189, 28);
            cBToLanguage.TabIndex = 10;
            cBToLanguage.SelectedIndexChanged += cBToLanguage_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(940, 283);
            Controls.Add(cBToLanguage);
            Controls.Add(cBFromLanguage);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private NotifyIcon notifyIcon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ComboBox dropDown;
        private ToolStripMenuItem aPIKeyToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button button1;
        private Panel panel1;
        private Button button4;
        private ComboBox cBFromLanguage;
        private ComboBox cBToLanguage;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
