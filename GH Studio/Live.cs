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

        Presenter presenter = new();

        public Live() {

            InitializeComponent();
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
                }
            }

            if (keyData == Keys.Left) {
                if (currentSlide > -1 && currentSlide != 0) {
                    currentSlide--;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];
                }
            }

            if (keyData == Keys.Right) {
                if (currentSlide < slides.Length - 1) {
                    currentSlide++;
                    presenter.ChangeText(slides[currentSlide]);
                    label1.Text = slides[currentSlide];
                }
            }

            if (keyData == Keys.Escape) {
                presenter.Close();
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
                    }
                }

                numberKey = "";
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
