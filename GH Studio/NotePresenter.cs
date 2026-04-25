using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GH_Studio {

    public partial class NotePresenter : Form {

        private static string[] contents = Array.Empty<string>();

        private static int currentPosition = 0;

        public NotePresenter() {

            InitializeComponent();
        }

        private void NotePresenter_Load(object sender, EventArgs e) {

            currentPosition = 0;

            string noteTitle = Path.Combine(Constant.notesPath, File.ReadAllText(Constant.selectedNoteFile) + ".ghlive");
            string lyrics = File.ReadAllText(noteTitle);
            contents = lyrics.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string fontString = File.ReadAllText(Constant.noteFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;
            label1.Font = font;

            label1.Text = contents[0];
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            if (keyData == Keys.Left) {
                if (currentPosition > -1 && currentPosition != 0) {
                    currentPosition--;
                    label1.Text = contents[currentPosition];
                }
            }

            if (keyData == Keys.Right) {
                if (currentPosition < contents.Length - 1) {
                    currentPosition++;
                    label1.Text = contents[currentPosition];
                }
            }

            if (keyData == Keys.Escape) {
                this.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
