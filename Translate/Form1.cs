
using DeepL;
using DeepL.Model;
using GTranslate.Translators;
using Microsoft.VisualBasic;
using Polly;
using System.Text.RegularExpressions;
using TesseractOCR;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using Image = System.Drawing.Image;

namespace Translate
{
    public partial class Form1 : Form
    {


        KeyboardHook hook = new KeyboardHook();
        public Form1()
        {
            InitializeComponent();
            // notifyIcon.ShowBalloonTip(1000);

            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(button3_Click);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(global::ModifierKeys.Alt, Keys.Capital);


        }












        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            dropDown.SelectedIndex = 1;
            cBToLanguage.SelectedIndex = 7;
            cBFromLanguage.SelectedIndex = 26;

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized
            //hide it from the task bar
            //and show the system tray icon (represented by the NotifyIcon control)
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control == true)
            // {
            //    button3.PerformClick();
            //  }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private async void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
            {
                string targetLanguageTxt = await Translate(richTextBox1.Text);

                richTextBox1.Text = "\n" + targetLanguageTxt;
            }
            
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SnippingTool snippingTool = new SnippingTool();
                Image bmp = CaptureScreen(snippingTool);



                if (bmp != null)
                {
                    string sourceLanguageTxt = ReadImg(bmp);
                    string targetLanguageTxt = await Translate(sourceLanguageTxt);
                    richTextBox1.Text = sourceLanguageTxt + "\n";
                    pictureBox1.Image = bmp;

                    TranslateWin translateWin = new TranslateWin(sourceLanguageTxt, targetLanguageTxt);
                    translateWin.Location = MousePosition;


                    translateWin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);

            }

        }



        private Image CaptureScreen(SnippingTool snippingTool)
        {
            Image img = snippingTool.Snip();
            return img;
        }


        private string ReadImg(Image img)
        {
            TesseractOCR.Enums.Language language = checkOCRLanguage();

            img.Save("./a.TIFF");
            var engine = new Engine("./tessdata", language, TesseractOCR.Enums.EngineMode.LstmOnly);
            var image = TesseractOCR.Pix.Image.LoadFromFile("./a.TIFF");
            File.Delete("./a.TIFF");
            var page = engine.Process(image);
            var text = page.Text;

            return text;
        }
        private async Task<string> Translate(string text)
        {
            string result = "";
            switch (dropDown.SelectedIndex)
            {

                case 0:
                    result = await DeepLTranslate(text);
                    break;
                case 1:
                    result = await GoogleTranslate(text);
                    break;
                case 2:
                    result = await MicrosoftTranslate(text);
                    break;
                case 3:
                    result = await BingTranslate(text);
                    break;
                case 4:
                    result = await YandexTranslate(text);
                    break;
            }

            return result;
        }




        private async Task<string> DeepLTranslate(string text)
        {
            string language = checkLanguage();
            // language = checkLanguageDeepL(language);
            var authKey = File.ReadAllText(@"./tol.txt");
            var translator = new Translator(authKey);
            var translatedText = await translator.TranslateTextAsync(text, LanguageCode.English, language);
            return translatedText.Text;

        }
        private async Task<string> GoogleTranslate(string text)
        {
            string language = checkLanguage();
            GoogleTranslator translator = new GoogleTranslator();
            var result = await translator.TranslateAsync(text, language);
            return result.Translation;
        }
        private async Task<string> MicrosoftTranslate(string text)
        {
            string language = checkLanguage();
            MicrosoftTranslator translator = new MicrosoftTranslator();
            var result = await translator.TranslateAsync(text, language);
            return result.Translation;
        }
        private async Task<string> BingTranslate(string text)
        {
            string language = checkLanguage();
            BingTranslator translator = new BingTranslator();
            var result = await translator.TranslateAsync(text, language);
            return result.Translation;
        }
        private async Task<string> YandexTranslate(string text)
        {
            string language = checkLanguage();
            YandexTranslator translator = new YandexTranslator();
            var result = await translator.TranslateAsync(text, language);
            return result.Translation;
        }

        private void SaveImg()
        {

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            //if(saveFileDialog.ShowDialog() == DialogResult.OK)
            // {
            //bmp.Save(saveFileDialog.FileName);
            // }

        }
        private void SaveTxt()
        {
            // File.WriteAllText(@"C:\Users\ayman\Downloads\output.txt", text);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"./tol.txt"))
            {
                MessageBox.Show("Error : File Exists , Please Delete Api");
            }
            else
            {
                string text = Interaction.InputBox("Please Write Key from DeepL API", "API KEY");
                MessageBox.Show(text);
                File.WriteAllText(@"./tol.txt", text);
            }



            //MessageBox.Show("Write Your Key API","warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"./tol.txt"))
            {
                File.Delete(@"./tol.txt");
                MessageBox.Show("File Deleted");
            }
            else
            {
                MessageBox.Show("Error : File Exists ");
            }

        }



        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBFromLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private TesseractOCR.Enums.Language checkOCRLanguage()
        {


            int la = cBFromLanguage.SelectedIndex + 1;
            TesseractOCR.Enums.Language language;
            foreach (TesseractOCR.Enums.Language lang in Enum.GetValues(typeof(TesseractOCR.Enums.Language)))
            {
                if (la == (int)lang)
                {
                    return language = lang;
                }
            }
            return TesseractOCR.Enums.Language.English;
        }
        private string checkLanguage()
        {
            string la = cBToLanguage.SelectedItem.ToString();
            return la;
        }
        private static string checkLanguageDeepL(string languagename)
        {
            return languagename switch
            {

                "Arabic" => "ar",
                "Bulgarian" => "bg",
                "Czech" => "cs",
                "Danish" => "da",
                "German" => "de",
                "Greek" => "el",
                "English" => "en",
                "enn" => "en-GB",
                "en" => "en-US",
                "Spanish" => "es",
                "Estonian" => "et",
                "Finnish" => "fi",
                "French" => "fr",
                "Hungarian" => "hu",
                "Indonesian" => "id",
                "Italian" => "it",
                "Japanese" => "ja",
                "Korean" => "ko",
                "Lithuanian" => "lt",
                "Latvian" => "lv",
                "Norwegian" => "nb",
                "Dutch" => "nl",
                "Polish" => "pl",
                "Portuguese" => "pt",
                "PortugueseBrazilian" => "pt-BR",
                "PortugueseEuropean" => "pt-PT",
                "Romanian" => "ro",
                "Russian" => "ru",
                "Slovak" => "sk",
                "Slovenian" => "sl",
                "Swedish" => "sv",
                "Turkish" => "tr",
                "Ukrainian" => "uk",
                "Chinese" => "zh",
                "zh" => "zh",
                _ => ""
            };
        }

        private void cBToLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }


}
