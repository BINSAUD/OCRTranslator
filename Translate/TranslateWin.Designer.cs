namespace Translate
{
    partial class TranslateWin
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
            txt1 = new RichTextBox();
            txt2 = new RichTextBox();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.BackColor = Color.FromArgb(46, 51, 73);
            txt1.BorderStyle = BorderStyle.None;
            txt1.Font = new Font("Traditional Arabic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt1.ForeColor = Color.WhiteSmoke;
            txt1.Location = new Point(-2, -4);
            txt1.MaximumSize = new Size(1500, 110);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 110);
            txt1.TabIndex = 0;
            txt1.Text = "";
            // 
            // txt2
            // 
            txt2.BackColor = Color.FromArgb(46, 51, 73);
            txt2.BorderStyle = BorderStyle.None;
            txt2.Font = new Font("Traditional Arabic", 24F, FontStyle.Bold);
            txt2.ForeColor = Color.WhiteSmoke;
            txt2.Location = new Point(-2, 114);
            txt2.MaximumSize = new Size(1500, 110);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 110);
            txt2.TabIndex = 1;
            txt2.Text = "";
            // 
            // TranslateWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(224, 233);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Cursor = Cursors.PanNorth;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TranslateWin";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Translate Window";
            TopMost = true;
            TransparencyKey = Color.White;
            Deactivate += TranslateWin_Deactivate;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txt1;
        private RichTextBox txt2;
    }
}