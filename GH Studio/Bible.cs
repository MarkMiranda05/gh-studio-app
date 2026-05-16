using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GH_Studio {

    public partial class Bible : Form {

        private readonly Dictionary<string, int> bibleDictionary = new();

        private static string[] chapters = Array.Empty<string>();
        private static string[] verses = Array.Empty<string>();

        private static int bookID;
        private static int currentChapter;
        private static int currentVerse = 0;
        private static int maxChapter;

        private static string numberKey = "";

        private Boolean isLive = false;

        BiblePresenter biblePresenter = new();

        public Bible() {

            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {

            currentVerse = listBox2.SelectedIndex;
            
            if (isLive) {
                displayText();
            }
        }

        private void Bible_Load(object sender, EventArgs e) {

            isLive = false;

            // Setting of Font Style
            string fontString = File.ReadAllText(Constant.bibleFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;
            fontDialog1.Font = font;

            // Setting of Font Color
            string colorString = File.ReadAllText(Constant.bibleFontColorFile);
            Color color = Color.FromName(colorString);
            label4.ForeColor = color;
            colorDialog1.Color = color;

            // Setting of Background Image
            string bgImage = File.ReadAllText(Constant.bibleBgImageFile);
            if (bgImage == String.Empty) {
                panel2.BackgroundImage = null;
            } else {
                panel2.BackgroundImage = new Bitmap(bgImage);
            }

            versionComboBox.SelectedIndex = 0;

            bookComboBox.Items.Clear();
            bookComboBox.Items.AddRange(Constant.bibleBooks);

            if (bibleDictionary.Count < 1) {
                for (int i = 0; i < 66; i++) {
                    bibleDictionary.Add(Constant.bibleBooks[i], Constant.bibleChapters[i]);
                }
            }

            bookComboBox.SelectedIndex = 0;
        }

        private void goButton_Click(object sender, EventArgs e) {

            isLive = true;

            if (versionComboBox.SelectedIndex >= 0 && bookComboBox.SelectedIndex >= 0) {
                int presenterScreenNo = Int32.Parse(File.ReadAllText(Constant.presenterScreenFile));
                Screen[] screens = Screen.AllScreens;

                Form openedForm = Application.OpenForms["BiblePresenter"];
                if (openedForm != null) {
                    openedForm.Close();
                }

                if (biblePresenter.IsDisposed) {
                    biblePresenter = new();
                }

                if (presenterScreenNo >= 0 && presenterScreenNo < screens.Length) {
                    biblePresenter.WindowState = FormWindowState.Normal;
                    biblePresenter.Location = Screen.AllScreens[presenterScreenNo].WorkingArea.Location;
                    biblePresenter.WindowState = FormWindowState.Maximized;
                    biblePresenter.Show();
                    this.Focus();

                    displayText();
                } else {
                    biblePresenter.WindowState = FormWindowState.Maximized;
                    biblePresenter.Show();
                    this.Focus();

                    displayText();
                }
            }

            panel1.Focus();
        }

        private void changeFontButton_Click(object sender, EventArgs e) {

            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                FontConverter cvt = new();
                string? stringFont = cvt.ConvertToString(fontDialog1.Font);

                TextWriter txt = new StreamWriter(Constant.bibleFontStyleFile);
                txt.Write(stringFont);
                txt.Close();
            }

            fontDialog1.Dispose();
        }

        private void changeColorButton_Click(object sender, EventArgs e) {

            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                label4.ForeColor = colorDialog1.Color;

                TextWriter txt = new StreamWriter(Constant.bibleFontColorFile);
                txt.Write(colorDialog1.Color.Name);
                txt.Close();
            }

            colorDialog1.Dispose();
        }

        private void changeBackgroundButton_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new()) {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.gif;*.bmp;*.jpg;*.jpeg,*.png)|*.GIF;*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    panel2.BackgroundImage = new Bitmap(dlg.FileName);

                    TextWriter txt = new StreamWriter(Constant.bibleBgImageFile);
                    txt.Write(dlg.FileName);
                    txt.Close();
                }
            }
        }

        private void removeBackgroundButton_Click(object sender, EventArgs e) {

            panel2.BackgroundImage = null;

            TextWriter txt = new StreamWriter(Constant.bibleBgImageFile);
            txt.Write(String.Empty);
            txt.Close();
        }

        private void bookComboBox_SelectedValueChanged(object sender, EventArgs e) {

            chapterComboBox.Items.Clear();

            string selectedBook = bookComboBox.GetItemText(bookComboBox.SelectedItem).Trim();

            int chapterCount = bibleDictionary[selectedBook];

            for (int i = 1; i <= chapterCount; i++) {
                chapterComboBox.Items.Add(i);
            }

            chapterComboBox.SelectedIndex = 0;
        }

        private string readResourceFile(string filename, int bookID) {

            StringBuilder stringBuilder = new();

            try {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GH_Studio.Resources." + filename + ".txt");
                var streamReader = new StreamReader(stream);

                while (!streamReader.EndOfStream) {
                    var line = streamReader.ReadLine();

                    if (line.StartsWith(Constant.bibleBooks[bookID])) {
                        stringBuilder.AppendLine(line);
                    }
                }

                return stringBuilder.ToString();
            } catch {
                return String.Empty;
            } finally {
                stringBuilder.Clear();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            if (keyData == Keys.Escape) {
                isLive = false;
                biblePresenter.Close();
            }

            if (keyData == Keys.D1 || keyData == Keys.NumPad1) {
                numberKey += "1";
            }

            if (keyData == Keys.D2 || keyData == Keys.NumPad2) {
                numberKey += "2";
            }

            if (keyData == Keys.D3 || keyData == Keys.NumPad3) {
                numberKey += "3";
            }

            if (keyData == Keys.D4 || keyData == Keys.NumPad4) {
                numberKey += "4";
            }

            if (keyData == Keys.D5 || keyData == Keys.NumPad5) {
                numberKey += "5";
            }

            if (keyData == Keys.D6 || keyData == Keys.NumPad6) {
                numberKey += "6";
            }

            if (keyData == Keys.D7 || keyData == Keys.NumPad7) {
                numberKey += "7";
            }

            if (keyData == Keys.D8 || keyData == Keys.NumPad8) {
                numberKey += "8";
            }

            if (keyData == Keys.D9 || keyData == Keys.NumPad9) {
                numberKey += "9";
            }

            if (keyData == Keys.D0 || keyData == Keys.NumPad0) {
                numberKey += "0";
            }

            if (keyData == Keys.Enter) {
                if (!numberKey.Equals("")) {
                    int numKey = Int32.Parse(numberKey);

                    if (verses.Length >= numKey && numKey != 0) {
                        currentVerse = numKey - 1;

                        listBox2.SelectedIndex = currentVerse;

                        displayText();
                    }
                }

                numberKey = "";
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void displayText() {

            string selectedChapter = " " + currentChapter + ":";
            biblePresenter.ChangeText(verses[currentVerse].Replace(Constant.bibleBooks[bookID] + selectedChapter, ""));

            string selectedBook = bookComboBox.GetItemText(bookComboBox.SelectedItem).Trim();
            biblePresenter.ChangeHeader(selectedBook + " " + currentChapter);

            label4.Text = verses[currentVerse].Replace(Constant.bibleBooks[bookID] + selectedChapter, "");
        }

        private void chapterComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            isLive = false;

            string chapterBox = chapterComboBox.GetItemText(chapterComboBox.SelectedItem).Trim();

            int version = versionComboBox.SelectedIndex;
            string selectedChapter = " " + chapterBox + ":";

            bookID = bookComboBox.SelectedIndex;
            currentChapter = Int32.Parse(chapterBox);
            maxChapter = chapterComboBox.Items.Count;

            string book;
            if (version == 0) {
                book = readResourceFile("WEB", bookID);
            } else if (version == 1) {
                book = readResourceFile("KJV", bookID);
            } else {
                book = readResourceFile("TAG", bookID);
            }

            chapters = book.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            List<string> bibleVerses = new();

            foreach (string chapter in chapters) {
                if (chapter.StartsWith(Constant.bibleBooks[bookID] + selectedChapter)) {
                    bibleVerses.Add(chapter);
                }
            }

            verses = bibleVerses.ToArray();
            listBox2.DataSource = bibleVerses;
        }
    }
}
