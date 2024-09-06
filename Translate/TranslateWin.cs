using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate
{
    public partial class TranslateWin : Form
    {
        string sourceLanguage;
        string targetLanguage;
       
        public TranslateWin(string sourceLanguage, string targetLanguage)
        {
           
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            this.sourceLanguage = sourceLanguage;
            this.targetLanguage = targetLanguage;

            int width = getLineWidth(sourceLanguage);
            txt1.Width = width;
            int width2 = getLineWidth(targetLanguage);
            txt2.Width = width2;
             
            int height = getLineHeight(sourceLanguage);
            txt1.Height = height;
            int height2 = getLineHeight(targetLanguage);
            txt2.Height = height2;

            txt1.Text = sourceLanguage;
            txt2.Text = targetLanguage;
          


            


        }

        private void TranslateWin_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }


        public int getLineWidth(string txt)
        {
            int textWidth = TextRenderer.MeasureText(txt, txt1.Font).Width;
            return textWidth; //this is the number of lines required, to adjust the height of the RichTextBox I need to multiply it by 15, which is the font's height.
        }
        public int getLineHeight(string txt)
        {
            int textHeight = TextRenderer.MeasureText(txt, txt1.Font).Height;
            return textHeight; //this is the number of lines required, to adjust the height of the RichTextBox I need to multiply it by 15, which is the font's height.
        }
    }
}
