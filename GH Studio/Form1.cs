using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GH_Studio {

    public partial class Form1 : Form {

        public Form1() {

            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e) {

            if (!Directory.Exists(Constant.songsPath)) {
                Directory.CreateDirectory(Constant.songsPath);
            }

            if (!Directory.Exists(Constant.configPath)) {
                Directory.CreateDirectory(Constant.configPath);
            }

            if (!Directory.Exists(Constant.notesPath)) {
                Directory.CreateDirectory(Constant.notesPath);
            }

            if (!Directory.Exists(Constant.birthdayPath)) {
                Directory.CreateDirectory(Constant.birthdayPath);
            }

            if (!Directory.Exists(Constant.anniversaryPath)) {
                Directory.CreateDirectory(Constant.anniversaryPath);
            }

            if (!Directory.Exists(Constant.announcementPath)) {
                Directory.CreateDirectory(Constant.announcementPath);
            }

            if (!File.Exists(Constant.ghStudioBgImageFile)) {
                File.Create(Constant.ghStudioBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.ghStudioBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.playlistFile)) {
                File.Create(Constant.playlistFile).Dispose();
            }

            if (!File.Exists(Constant.presenterScreenFile)) {
                File.Create(Constant.presenterScreenFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.presenterScreenFile);
                txt.Write("1");
                txt.Close();
            }

            if (!File.Exists(Constant.selectedNoteFile)) {
                File.Create(Constant.selectedNoteFile).Dispose();
            }

            if (!File.Exists(Constant.songFontStyleFile)) {
                File.Create(Constant.songFontStyleFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.songFontStyleFile);
                txt.Write("Ebrima, 12pt, style=Bold");
                txt.Close();
            }

            if (!File.Exists(Constant.songFontColorFile)) {
                File.Create(Constant.songFontColorFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.songFontColorFile);
                txt.Write("Black");
                txt.Close();
            }

            if (!File.Exists(Constant.songBgImageFile)) {
                File.Create(Constant.songBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.songBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.bibleFontStyleFile)) {
                File.Create(Constant.bibleFontStyleFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.bibleFontStyleFile);
                txt.Write("Ebrima, 80pt");
                txt.Close();
            }

            if (!File.Exists(Constant.bibleFontColorFile)) {
                File.Create(Constant.bibleFontColorFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.bibleFontColorFile);
                txt.Write("Black");
                txt.Close();
            }

            if (!File.Exists(Constant.bibleBgImageFile)) {
                File.Create(Constant.bibleBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.bibleBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.noteFontStyleFile)) {
                File.Create(Constant.noteFontStyleFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.noteFontStyleFile);
                txt.Write("Ebrima, 80pt");
                txt.Close();
            }

            if (!File.Exists(Constant.birthdayBgImageFile)) {
                File.Create(Constant.birthdayBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.birthdayBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.anniversaryBgImageFile)) {
                File.Create(Constant.anniversaryBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.anniversaryBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.announcementFile)) {
                File.Create(Constant.announcementFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.announcementFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.ghStudioBgImageFile)) {
                File.Create(Constant.ghStudioBgImageFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.ghStudioBgImageFile);
                txt.Write(String.Empty);
                txt.Close();
            }

            if (!File.Exists(Constant.eventFontStyleFile)) {
                File.Create(Constant.eventFontStyleFile).Dispose();

                TextWriter txt = new StreamWriter(Constant.eventFontStyleFile);
                txt.Write("Ebrima, 80pt");
                txt.Close();
            }

            int presenterScreenNo = Int32.Parse(File.ReadAllText(Constant.presenterScreenFile));
            Screen[] screens = Screen.AllScreens;

            GHStudio gHStudio = new();

            if (presenterScreenNo >= 0 && presenterScreenNo < screens.Length) {
                gHStudio.WindowState = FormWindowState.Normal;
                gHStudio.Location = Screen.AllScreens[presenterScreenNo].WorkingArea.Location;
                gHStudio.WindowState = FormWindowState.Maximized;
                gHStudio.Show();
                this.Focus();
            } else {
                gHStudio.WindowState = FormWindowState.Maximized;
                gHStudio.Show();
                this.Focus();
            }
        }

        private void liveButton_Click(object sender, EventArgs e) {

            liveButton.BackColor = Color.SandyBrown;
            bibleButton.BackColor = Color.Wheat;
            notesButton.BackColor = Color.Wheat;
            announcementsButton.BackColor = Color.Wheat;

            Form biblePresenterForm = Application.OpenForms["BiblePresenter"];
            if (biblePresenterForm != null) {
                biblePresenterForm.Close();
            }

            Form notePresenterForm = Application.OpenForms["NotePresenter"];
            if (notePresenterForm != null) {
                notePresenterForm.Close();
            }

            Form announcemntPresenterForm = Application.OpenForms["AnnouncementPresenter"];
            if (announcemntPresenterForm != null) {
                announcemntPresenterForm.Close();
            }

            Live live = new();
            live.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(live);
            live.Show();
        }

        private void bibleButton_Click(object sender, EventArgs e) {

            liveButton.BackColor = Color.Wheat;
            bibleButton.BackColor = Color.SandyBrown;
            notesButton.BackColor = Color.Wheat;
            announcementsButton.BackColor = Color.Wheat;

            Form livePresenterForm = Application.OpenForms["Presenter"];
            if (livePresenterForm != null) {
                livePresenterForm.Close();
            }

            Form notePresenterForm = Application.OpenForms["NotePresenter"];
            if (notePresenterForm != null) {
                notePresenterForm.Close();
            }

            Form announcemntPresenterForm = Application.OpenForms["AnnouncementPresenter"];
            if (announcemntPresenterForm != null) {
                announcemntPresenterForm.Close();
            }

            Bible bible = new();
            bible.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(bible);
            bible.Show();
        }

        private void notesButton_Click(object sender, EventArgs e) {

            liveButton.BackColor = Color.Wheat;
            bibleButton.BackColor = Color.Wheat;
            notesButton.BackColor = Color.SandyBrown;
            announcementsButton.BackColor = Color.Wheat;

            Form livePresenterForm = Application.OpenForms["Presenter"];
            if (livePresenterForm != null) {
                livePresenterForm.Close();
            }

            Form biblePresenterForm = Application.OpenForms["BiblePresenter"];
            if (biblePresenterForm != null) {
                biblePresenterForm.Close();
            }

            Form announcemntPresenterForm = Application.OpenForms["AnnouncementPresenter"];
            if (announcemntPresenterForm != null) {
                announcemntPresenterForm.Close();
            }

            Notes notes = new();
            notes.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(notes);
            notes.Show();
        }

        private void announcementsButton_Click(object sender, EventArgs e) {

            liveButton.BackColor = Color.Wheat;
            bibleButton.BackColor = Color.Wheat;
            notesButton.BackColor = Color.Wheat;
            announcementsButton.BackColor = Color.SandyBrown;

            Form livePresenterForm = Application.OpenForms["Presenter"];
            if (livePresenterForm != null) {
                livePresenterForm.Close();
            }

            Form biblePresenterForm = Application.OpenForms["BiblePresenter"];
            if (biblePresenterForm != null) {
                biblePresenterForm.Close();
            }

            Form notePresenterForm = Application.OpenForms["NotePresenter"];
            if (notePresenterForm != null) {
                notePresenterForm.Close();
            }

            Announcements announcements = new();
            announcements.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(announcements);
            announcements.Show();
        }
    }
}