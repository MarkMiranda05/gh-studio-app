using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GH_Studio {

    public partial class Live : Form {

        private static string[] playlist = Array.Empty<string>();

        private static string[] slides = Array.Empty<string>();

        private static int currentPlaylist = 0;

        private static int currentSlide = 0;

        private static string numberKey = "";

        public static string SelectedSong = "";

        List<Panel> lyricsPanels;

        List<Label> lyricsLabels;

        Presenter presenter = new();

        public Live() {

            InitializeComponent();

            lyricsPanels = new List<Panel> {
                lyrics1, lyrics2, lyrics3, lyrics4, lyrics5, lyrics6, lyrics7, lyrics8, lyrics9, lyrics10,
                lyrics11, lyrics12, lyrics13, lyrics14, lyrics15, lyrics16, lyrics17, lyrics18, lyrics19, lyrics20
            };

            lyricsLabels = new List<Label> {
                l1, l2, l3, l4, l5, l6, l7, l8, l9, l10,
                l11, l12, l13, l14, l15, l16, l17, l18, l19, l20
            };
        }

        private void Live_Load(object sender, EventArgs e) {

            // Setting of Font Style
            string fontString = File.ReadAllText(Constant.songFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;
            fontDialog1.Font = font;

            // Setting of Font Color
            string colorString = File.ReadAllText(Constant.songFontColorFile);
            Color color = Color.FromName(colorString);
            label1.ForeColor = color;
            colorDialog1.Color = color;
            UpdatePreviewLyricsConfiguration(color);

            // Setting of Background Image
            string bgImage = File.ReadAllText(Constant.songBgImageFile);
            if (bgImage == String.Empty) {
                panel2.BackgroundImage = null;
            } else {
                panel2.BackgroundImage = new Bitmap(bgImage);
            }

            RefreshAllSongs();
            RefreshPlaylist();
        }

        private void moveUpButton_Click(object sender, EventArgs e) {

            MoveSelectedItem(listBox1, -1);
            File.WriteAllLines(Constant.playlistFile, listBox1.Items.Cast<string>().ToArray());
            RefreshPlaylist();
        }

        private void moveDownButton_Click(object sender, EventArgs e) {

            MoveSelectedItem(listBox1, 1);
            File.WriteAllLines(Constant.playlistFile, listBox1.Items.Cast<string>().ToArray());
            RefreshPlaylist();
        }

        private void removeButton_Click(object sender, EventArgs e) {

            if (listBox1.SelectedIndex != -1) {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--) {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }

                File.WriteAllLines(Constant.playlistFile, listBox1.Items.Cast<string>().ToArray());
                RefreshPlaylist();
            }
        }

        private void selectButton_Click(object sender, EventArgs e) {

            if (listBox2.SelectedIndex != -1) {
                if (!listBox1.Items.Contains(listBox2.SelectedItem)) {
                    listBox1.Items.Add(listBox2.SelectedItem);

                    File.WriteAllLines(Constant.playlistFile, listBox1.Items.Cast<string>().ToArray());
                    RefreshPlaylist();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e) {

            SelectedSong = String.Empty;

            AddSong addSong = new();
            addSong.ShowDialog();

            RefreshAllSongs();
            RefreshPlaylist();
        }

        private void updateButton_Click(object sender, EventArgs e) {

            if (listBox2.SelectedIndex != -1) {
                SelectedSong = listBox2.GetItemText(listBox2.SelectedItem);

                AddSong addSong = new();
                addSong.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {

            if (listBox2.SelectedIndex != -1) {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this song?", "GH Studio Warning", buttons);

                if (result == DialogResult.Yes) {
                    listBox1.Items.Remove(listBox2.SelectedItem);
                    File.WriteAllLines(Constant.playlistFile, listBox1.Items.Cast<string>().ToArray());
                    RefreshPlaylist();

                    string fileToBeDeletedInSongList = Path.Combine(Constant.songsPath, listBox2.SelectedItem + ".ghlive");
                    if (File.Exists(fileToBeDeletedInSongList)) {
                        File.Delete(fileToBeDeletedInSongList);
                        RefreshAllSongs();
                    }
                }
            }
        }

        private void fontStyleButton_Click(object sender, EventArgs e) {

            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                FontConverter cvt = new();
                string? stringFont = cvt.ConvertToString(fontDialog1.Font);

                TextWriter txt = new StreamWriter(Constant.songFontStyleFile);
                txt.Write(stringFont);
                txt.Close();
            }

            fontDialog1.Dispose();
        }

        private void fontColorButton_Click(object sender, EventArgs e) {

            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                label1.ForeColor = colorDialog1.Color;

                TextWriter txt = new StreamWriter(Constant.songFontColorFile);
                txt.Write(colorDialog1.Color.Name);
                txt.Close();
            }

            colorDialog1.Dispose();
        }

        private void backgroundButton_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new()) {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.gif;*.bmp;*.jpg;*.jpeg,*.png)|*.GIF;*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    panel2.BackgroundImage = new Bitmap(dlg.FileName);

                    TextWriter txt = new StreamWriter(Constant.songBgImageFile);
                    txt.Write(dlg.FileName);
                    txt.Close();
                }
            }
        }

        private void removeBGButton_Click(object sender, EventArgs e) {

            panel2.BackgroundImage = null;

            TextWriter txt = new StreamWriter(Constant.songBgImageFile);
            txt.Write(String.Empty);
            txt.Close();
        }

        private void goLiveButton_Click(object sender, EventArgs e) {

            currentPlaylist = 0;
            currentSlide = 0;
            playlist = File.ReadAllLines(Constant.playlistFile);

            if (playlist != null && playlist.Length > 0) {
                string song = Path.Combine(Constant.songsPath, playlist[currentPlaylist] + ".ghlive");
                string lyrics = File.ReadAllText(song);
                slides = lyrics.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }

            int presenterScreenNo = Int32.Parse(File.ReadAllText(Constant.presenterScreenFile));
            Screen[] screens = Screen.AllScreens;

            Form openedForm = Application.OpenForms["Presenter"];
            if (openedForm != null) {
                openedForm.Close();
            }

            if (presenter.IsDisposed) {
                presenter = new();
            }

            if (presenterScreenNo >= 0 && presenterScreenNo < screens.Length) {
                presenter.WindowState = FormWindowState.Normal;
                presenter.Location = Screen.AllScreens[presenterScreenNo].WorkingArea.Location;
                presenter.WindowState = FormWindowState.Maximized;
                presenter.Show();
                this.Focus();
            } else {
                presenter.WindowState = FormWindowState.Maximized;
                presenter.Show();
                this.Focus();
            }

            if (playlist != null && playlist.Length > 0) {
                presenter.ChangeText(slides[0]);
                label1.Text = slides[0];

                ShowPreviewLyrics(slides);
            }

            panel1.Focus();
        }

        public void RefreshPlaylist() {

            if (File.Exists(Constant.playlistFile)) {
                listBox1.Items.Clear();
                string[] songTitles = File.ReadAllLines(Constant.playlistFile);
                listBox1.Items.AddRange(songTitles);
            }
        }

        public void RefreshAllSongs() {

            listBox2.Items.Clear();
            string[] songTitles = Directory.GetFiles(Constant.songsPath, "*.ghlive");
            foreach (string songTitle in songTitles) {
                listBox2.Items.Add(Path.GetFileName(songTitle).Replace(".ghlive", String.Empty));
            }
            listBox2.Sorted = true;
        }

        public void ShowPreviewLyrics(string[] latestSlides) {

            HidePreviewLyrics();

            int slideCount = latestSlides.Length;

            for (int i = 0; i < slideCount; i++) {
                lyricsPanels[i].Visible = i < slideCount;
                lyricsLabels[i].Text = latestSlides[i];
            }

            UpdateSelectedPreviewLyrics(0);
        }

        public void HidePreviewLyrics() {

            foreach (var panel in lyricsPanels) {
                panel.Visible = false;
            }
        }

        public void UpdateSelectedPreviewLyrics(int currentSlide) {

            foreach (var panel in lyricsPanels) {
                panel.BackColor = Color.Transparent;
            }

            lyricsPanels[currentSlide].BackColor = Color.Red;
        }

        public void UpdatePreviewLyricsConfiguration(Color color) {

            l1.ForeColor = color;
            l2.ForeColor = color;
            l3.ForeColor = color;
            l4.ForeColor = color;
            l5.ForeColor = color;
            l6.ForeColor = color;
            l7.ForeColor = color;
            l8.ForeColor = color;
            l9.ForeColor = color;
            l10.ForeColor = color;
            l11.ForeColor = color;
            l12.ForeColor = color;
            l13.ForeColor = color;
            l14.ForeColor = color;
            l15.ForeColor = color;
            l16.ForeColor = color;
            l17.ForeColor = color;
            l18.ForeColor = color;
            l19.ForeColor = color;
            l20.ForeColor = color;
        }

        static void MoveSelectedItem(ListBox listBox, int direction) {

            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return;

            int newIndex = listBox.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return;

            object selected = listBox.SelectedItem;

            var checkedListBox = listBox as CheckedListBox;
            var checkState = CheckState.Unchecked;
            if (checkedListBox != null)
                checkState = checkedListBox.GetItemCheckState(checkedListBox.SelectedIndex);

            listBox.Items.Remove(selected);
            listBox.Items.Insert(newIndex, selected);
            listBox.SetSelected(newIndex, true);

            checkedListBox?.SetItemCheckState(newIndex, checkState);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            if (keyData == Keys.Up) {
                if (currentPlaylist > -1 && currentPlaylist != 0) {
                    currentPlaylist--;

                    string localSong = Path.Combine(Constant.songsPath, playlist[currentPlaylist] + ".ghlive");
                    string localLyrics = File.ReadAllText(localSong);
                    slides = localLyrics.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    currentSlide = 0;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];

                    ShowPreviewLyrics(slides);
                }
            }

            if (keyData == Keys.Down) {
                if (currentPlaylist < playlist.Length - 1) {
                    currentPlaylist++;

                    string localSong = Path.Combine(Constant.songsPath, playlist[currentPlaylist] + ".ghlive");
                    string localLyrics = File.ReadAllText(localSong);
                    slides = localLyrics.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    currentSlide = 0;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];

                    ShowPreviewLyrics(slides);
                }
            }

            if (keyData == Keys.Left) {
                if (currentSlide > -1 && currentSlide != 0) {
                    currentSlide--;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];

                    UpdateSelectedPreviewLyrics(currentSlide);
                }
            }

            if (keyData == Keys.Right) {
                if (currentSlide < slides.Length - 1) {
                    currentSlide++;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];

                    UpdateSelectedPreviewLyrics(currentSlide);
                }
            }

            if (keyData == Keys.Escape) {
                presenter.Close();
                label1.Text = "GH Live";

                HidePreviewLyrics();
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

                    if (slides.Length >= numKey && numKey != 0) {
                        currentSlide = numKey - 1;

                        presenter.ChangeText(slides[currentSlide]);
                        label1.Text = slides[currentSlide];

                        UpdateSelectedPreviewLyrics(currentSlide);
                    }
                }

                numberKey = "";
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void l1_Click(object sender, EventArgs e) {

            currentSlide = 0;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l2_Click(object sender, EventArgs e) {

            currentSlide = 1;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l3_Click(object sender, EventArgs e) {

            currentSlide = 2;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l4_Click(object sender, EventArgs e) {

            currentSlide = 3;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l5_Click(object sender, EventArgs e) {

            currentSlide = 4;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l6_Click(object sender, EventArgs e) {

            currentSlide = 5;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l7_Click(object sender, EventArgs e) {

            currentSlide = 6;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l8_Click(object sender, EventArgs e) {

            currentSlide = 7;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l9_Click(object sender, EventArgs e) {

            currentSlide = 8;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l10_Click(object sender, EventArgs e) {

            currentSlide = 9;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l11_Click(object sender, EventArgs e) {

            currentSlide = 10;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l12_Click(object sender, EventArgs e) {

            currentSlide = 11;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l13_Click(object sender, EventArgs e) {

            currentSlide = 12;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l14_Click(object sender, EventArgs e) {

            currentSlide = 13;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l15_Click(object sender, EventArgs e) {

            currentSlide = 14;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l16_Click(object sender, EventArgs e) {

            currentSlide = 15;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l17_Click(object sender, EventArgs e) {

            currentSlide = 16;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l18_Click(object sender, EventArgs e) {

            currentSlide = 17;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l19_Click(object sender, EventArgs e) {

            currentSlide = 18;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }

        private void l20_Click(object sender, EventArgs e) {

            currentSlide = 19;
            presenter.ChangeText(slides[currentSlide]);
            label1.Text = slides[currentSlide];

            UpdateSelectedPreviewLyrics(currentSlide);
        }
    }
}
