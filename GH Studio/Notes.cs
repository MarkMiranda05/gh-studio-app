using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH_Studio {

    public partial class Notes : Form {

        public static string SelectedNote = "";

        public Notes() {

            InitializeComponent();
        }

        private void Notes_Load(object sender, EventArgs e) {

            string fontString = File.ReadAllText(Constant.bibleFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;
            fontDialog1.Font = font;

            RefreshNotes();
        }

        private void addButton_Click(object sender, EventArgs e) {

            SelectedNote = String.Empty;

            AddNote addNote = new();
            addNote.ShowDialog();

            RefreshNotes();
        }

        private void updateButton_Click(object sender, EventArgs e) {

            if (listBox1.SelectedIndex != -1) {
                SelectedNote = listBox1.GetItemText(listBox1.SelectedItem);

                AddNote addNote = new();
                addNote.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {

            if (listBox1.SelectedIndex != -1) {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "GH Studio Warning", buttons);

                if (result == DialogResult.Yes) {
                    string noteToBeDeleted = Path.Combine(Constant.notesPath, listBox1.SelectedItem + ".ghlive");
                    if (File.Exists(noteToBeDeleted)) {
                        File.Delete(noteToBeDeleted);

                        RefreshNotes();
                    }
                }
            }
        }

        private void changeFontButton_Click(object sender, EventArgs e) {

            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                FontConverter cvt = new();
                string? stringFont = cvt.ConvertToString(fontDialog1.Font);

                TextWriter txt = new StreamWriter(Constant.noteFontStyleFile);
                txt.Write(stringFont);
                txt.Close();
            }

            fontDialog1.Dispose();
        }

        private void selectButton_Click(object sender, EventArgs e) {

            if (listBox1.SelectedIndex >= 0) {
                TextWriter txt = new StreamWriter(Constant.selectedNoteFile);
                txt.Write(listBox1.SelectedItem);
                txt.Close();

                int presenterScreenNo = Int32.Parse(File.ReadAllText(Constant.presenterScreenFile));
                Screen[] screens = Screen.AllScreens;

                Form openedForm = Application.OpenForms["NotePresenter"];
                NotePresenter notePresenter = new();

                if (presenterScreenNo >= 0 && presenterScreenNo < screens.Length) {
                    if (openedForm != null) {
                        openedForm.Close();
                    }

                    notePresenter.WindowState = FormWindowState.Normal;
                    notePresenter.Location = Screen.AllScreens[presenterScreenNo].WorkingArea.Location;
                    notePresenter.WindowState = FormWindowState.Maximized;
                    notePresenter.Show();
                } else {
                    if (openedForm != null) {
                        openedForm.Close();
                    }

                    notePresenter.WindowState = FormWindowState.Maximized;
                    notePresenter.Show();
                }
            }
        }

        private void RefreshNotes() {

            listBox1.Items.Clear();
            string[] noteTitles = Directory.GetFiles(Constant.notesPath, "*.ghlive");
            foreach (string noteTitle in noteTitles) {
                listBox1.Items.Add(Path.GetFileName(noteTitle).Replace(".ghlive", String.Empty));
            }
            listBox1.Sorted = true;
        }
    }
}
