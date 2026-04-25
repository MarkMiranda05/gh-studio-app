using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH_Studio {

    public partial class AddNote : Form {

        public AddNote() {

            InitializeComponent();
        }

        private void AddNote_Load(object sender, EventArgs e) {

            string selectedNote = Notes.SelectedNote;

            if (selectedNote == String.Empty) {
                titleTextBox.Text = String.Empty;
                contentTextBox.Text = String.Empty;
            } else {
                string textFile = Path.Combine(Constant.notesPath, selectedNote + ".ghlive");
                string text = File.ReadAllText(textFile);

                titleTextBox.Text = selectedNote;
                contentTextBox.Text = text;
            }
        }

        private void saveButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(titleTextBox.Text)) {
                MessageBox.Show("Title can't be empty.", "GH Studio Warning", MessageBoxButtons.OK);
            } else if (string.IsNullOrEmpty(contentTextBox.Text)) {
                MessageBox.Show("Contents can't be empty.", "GH Studio Warning", MessageBoxButtons.OK);
            } else {
                string formattedNoteTitle = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titleTextBox.Text.Trim().ToLower());
                string noteTitle = formattedNoteTitle + ".ghlive";
                string notePath = Path.Combine(Constant.notesPath, noteTitle);

                if (!File.Exists(notePath)) {
                    TextWriter txt = new StreamWriter(notePath);
                    txt.Write(contentTextBox.Text);
                    txt.Close();

                    this.Close();
                } else {
                    DialogResult result = MessageBox.Show("Save changes?", "GH Studio Warning", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes) {
                        TextWriter txt = new StreamWriter(notePath);
                        txt.Write(contentTextBox.Text);
                        txt.Close();

                        this.Close();
                    }
                }
            }
        }
    }
}
