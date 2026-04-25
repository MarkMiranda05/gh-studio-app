using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GH_Studio {

    public partial class AddSong : Form {

        public AddSong() {

            InitializeComponent();
        }

        private void AddSong_Load(object sender, EventArgs e) {

            string selectedSong = Live.SelectedSong;

            if (selectedSong == String.Empty) {
                titleTextBox.Text = String.Empty;
                lyricsTextBox.Text = String.Empty;
            } else {
                string textFile = Path.Combine(Constant.songsPath, selectedSong + ".ghlive");
                string text = File.ReadAllText(textFile);

                titleTextBox.Text = selectedSong;
                lyricsTextBox.Text = text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(titleTextBox.Text)) {
                MessageBox.Show("Title can't be empty.", "GH Studio Warning", MessageBoxButtons.OK);
            } else if (string.IsNullOrEmpty(lyricsTextBox.Text)) {
                MessageBox.Show("Lyrics can't be empty.", "GH Studio Warning", MessageBoxButtons.OK);
            } else {
                string formattedSongTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titleTextBox.Text.Trim().ToLower());
                string songTitle = formattedSongTitle + ".ghlive";
                string songPath = Path.Combine(Constant.songsPath, songTitle);

                if (!File.Exists(songPath)) {
                    TextWriter txt = new StreamWriter(songPath);
                    txt.Write(lyricsTextBox.Text.ToUpper());
                    txt.Close();

                    this.Close();
                } else {
                    DialogResult result = MessageBox.Show("Save changes?", "GH Studio Warning", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) {
                        TextWriter txt = new StreamWriter(songPath);
                        txt.Write(lyricsTextBox.Text.ToUpper());
                        txt.Close();

                        this.Close();
                    }
                }
            }
        }
    }
}
