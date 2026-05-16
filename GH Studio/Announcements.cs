using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GH_Studio {

    public partial class Announcements : Form {

        public static string SelectedBirthday = "";

        private static int currentSlide = 0;

        private List<string> birthdays = new();
        private List<string> anniversaries = new();

        private string currentWeekBirthdays = String.Empty;
        private string currentWeekAnniversaries = String.Empty;
        private string currentWeekAnnouncements = String.Empty;

        AnnouncementPresenter announcementPresenter = new();

        public Announcements() {

            InitializeComponent();
        }

        private void Announcements_Load(object sender, EventArgs e) {

            RefreshEvents();
            UpdateLists();

            string text = File.ReadAllText(Constant.announcementFile);
            textBox1.Text = text;
        }

        private void addButton_Click(object sender, EventArgs e) {

            AddEvent.EventType = "Birthday";

            AddEvent addEvent = new();
            addEvent.ShowDialog();

            RefreshEvents();
            UpdateLists();
        }

        private void deleteButton_Click(object sender, EventArgs e) {

            if (listBox1.SelectedIndex != -1) {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "GH Studio Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    string eventToDelete = Path.Combine(Constant.birthdayPath, listBox1.SelectedItem + ".ghlive");
                    if (File.Exists(eventToDelete)) {
                        File.Delete(eventToDelete);
                        RefreshEvents();
                    }
                }
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new()) {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.gif;*.bmp;*.jpg;*.jpeg,*.png)|*.GIF;*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    TextWriter txt = new StreamWriter(Constant.birthdayBgImageFile);
                    txt.Write(dlg.FileName);
                    txt.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {

            AddEvent.EventType = "Anniversary";

            AddEvent addEvent = new();
            addEvent.ShowDialog();

            RefreshEvents();
            UpdateLists();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (listBox2.SelectedIndex != -1) {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "GH Studio Warning", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    string eventToDelete = Path.Combine(Constant.anniversaryPath, listBox2.SelectedItem + ".ghlive");
                    if (File.Exists(eventToDelete)) {
                        File.Delete(eventToDelete);
                        RefreshEvents();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new()) {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.gif;*.bmp;*.jpg;*.jpeg,*.png)|*.GIF;*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    TextWriter txt = new StreamWriter(Constant.anniversaryBgImageFile);
                    txt.Write(dlg.FileName);
                    txt.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {

            using (OpenFileDialog dlg = new()) {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.gif;*.bmp;*.jpg;*.jpeg,*.png)|*.GIF;*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK) {
                    TextWriter txt = new StreamWriter(Constant.announcementBgImageFile);
                    txt.Write(dlg.FileName);
                    txt.Close();
                }
            }
        }

        private void fontStyleButton_Click(object sender, EventArgs e) {

            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                FontConverter cvt = new();
                string? stringFont = cvt.ConvertToString(fontDialog1.Font);

                TextWriter txt = new StreamWriter(Constant.eventFontStyleFile);
                txt.Write(stringFont);
                txt.Close();
            }

            fontDialog1.Dispose();
        }

        private void goAnnounceButton_Click(object sender, EventArgs e) {

            int presenterScreenNo = Int32.Parse(File.ReadAllText(Constant.presenterScreenFile));
            Screen[] screens = Screen.AllScreens;

            Form openedForm = Application.OpenForms["AnnouncementPresenter"];
            if (openedForm != null) {
                openedForm.Close();
            }

            if (announcementPresenter.IsDisposed) {
                announcementPresenter = new();
            }

            if (presenterScreenNo >= 0 && presenterScreenNo < screens.Length) {
                announcementPresenter.WindowState = FormWindowState.Normal;
                announcementPresenter.Location = Screen.AllScreens[presenterScreenNo].WorkingArea.Location;
                announcementPresenter.WindowState = FormWindowState.Maximized;
                announcementPresenter.Show();
                this.Focus();
            } else {
                announcementPresenter.WindowState = FormWindowState.Maximized;
                announcementPresenter.Show();
                this.Focus();
            }

            currentWeekBirthdays = String.Empty;
            currentWeekAnniversaries = String.Empty;
            currentWeekAnnouncements = String.Empty;

            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = startDate.AddDays(6);

            // Birthday
            List<String> birthdayCelebrants = new();

            foreach (string birthday in birthdays) {
                string[] split = birthday.Split('=');
                DateTime rawDate = DateTime.Parse(split[1]);
                DateTime eventDate = new DateTime(startDate.Year, rawDate.Month, rawDate.Day);
                if (eventDate >= startDate && eventDate <= endDate) {
                    birthdayCelebrants.Add(split[0] + " - " + eventDate.ToString("MMM dd"));
                }
            }

            var sortedBirthdayCelebrants = birthdayCelebrants.OrderBy(x => {
                var datePart = x.Split(" - ")[1];
                return DateTime.ParseExact(datePart, "MMM dd", CultureInfo.InvariantCulture);
            }).ToList();

            currentWeekBirthdays = string.Join(Environment.NewLine, sortedBirthdayCelebrants.ToArray());

            // Anniversary
            List<String> anniversaryCelebrants = new();

            foreach (string anniversary in anniversaries) {
                string[] split = anniversary.Split('=');
                DateTime rawDate = DateTime.Parse(split[1]);
                DateTime eventDate = new DateTime(startDate.Year, rawDate.Month, rawDate.Day);
                if (eventDate >= startDate && eventDate <= endDate) {
                    anniversaryCelebrants.Add(split[0] + " - " + rawDate.ToString("MMM dd"));
                }
            }

            var sortedAnniversaryCelebrants = anniversaryCelebrants.OrderBy(x => {
                var datePart = x.Split(" - ")[1];
                return DateTime.ParseExact(datePart, "MMM dd", CultureInfo.InvariantCulture);
            }).ToList();

            currentWeekAnniversaries = string.Join(Environment.NewLine, sortedAnniversaryCelebrants.ToArray());

            // Save announcements to file
            string announcePath = Path.Combine(Constant.announcementPath, "Announcement.ghlive");
            if (!string.IsNullOrEmpty(textBox1.Text)) {
                TextWriter txt = new StreamWriter(announcePath);
                txt.Write(textBox1.Text.ToUpper());
                txt.Close();
            }

            // Retrieve announcement file
            string announcements = File.ReadAllText(Constant.announcementFile);
            if (!string.IsNullOrEmpty(announcements)) {
                currentWeekAnnouncements = announcements;
                textBox1.Text = announcements;
            }

            if (string.IsNullOrEmpty(currentWeekBirthdays)) {
                announcementPresenter.ChangeText("No Birthday For This Week");
                announcementPresenter.ChangeEvent("Birthday");
            } else {
                announcementPresenter.ChangeText(currentWeekBirthdays.TrimEnd());
                announcementPresenter.ChangeEvent("Birthday");
            }

            currentSlide = 0;

            panel1.Focus();
        }

        private void RefreshEvents() {

            listBox1.Items.Clear();
            string[] birthdays = Directory.GetFiles(Constant.birthdayPath, "*.ghlive");
            foreach (string birthday in birthdays) {
                listBox1.Items.Add(Path.GetFileName(birthday).Replace(".ghlive", String.Empty));
            }
            listBox1.Sorted = true;

            listBox2.Items.Clear();
            string[] anniversaries = Directory.GetFiles(Constant.anniversaryPath, "*.ghlive");
            foreach (string anniversary in anniversaries) {
                listBox2.Items.Add(Path.GetFileName(anniversary).Replace(".ghlive", String.Empty));
            }
            listBox2.Sorted = true;
        }

        private void UpdateLists() {

            birthdays.Clear();
            string[] birthdayEvents = Directory.GetFiles(Constant.birthdayPath, "*.ghlive");
            foreach (string birthday in birthdayEvents) {
                string birthdayPath = Path.Combine(Constant.birthdayPath, Path.GetFileName(birthday));
                birthdays.Add(File.ReadAllText(birthdayPath).Trim());
            }

            anniversaries.Clear();
            string[] anniversaryEvents = Directory.GetFiles(Constant.anniversaryPath, "*.ghlive");
            foreach (string anniversary in anniversaryEvents) {
                string anniversaryPath = Path.Combine(Constant.anniversaryPath, Path.GetFileName(anniversary));
                anniversaries.Add(File.ReadAllText(anniversaryPath).Trim());
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            if (keyData == Keys.Left) {
                if (currentSlide > -1 && currentSlide != 0) {
                    currentSlide--;

                    if (currentSlide == 0) {
                        if (string.IsNullOrEmpty(currentWeekBirthdays)) {
                            announcementPresenter.ChangeText("No Birthday For This Week");
                            announcementPresenter.ChangeEvent("Birthday");
                        } else {
                            announcementPresenter.ChangeText(currentWeekBirthdays.TrimEnd());
                            announcementPresenter.ChangeEvent("Birthday");
                        }
                    } else if (currentSlide == 1) {
                        if (string.IsNullOrEmpty(currentWeekAnniversaries)) {
                            announcementPresenter.ChangeText("No Anniversary For This Week");
                            announcementPresenter.ChangeEvent("Anniversary");
                        } else {
                            announcementPresenter.ChangeText(currentWeekAnniversaries.TrimEnd());
                            announcementPresenter.ChangeEvent("Anniversary");
                        }
                    }
                }
            }

            if (keyData == Keys.Right) {
                if (currentSlide < 2) {
                    currentSlide++;

                    if (currentSlide == 1) {
                        if (string.IsNullOrEmpty(currentWeekAnniversaries)) {
                            announcementPresenter.ChangeText("No Anniversary For This Week");
                            announcementPresenter.ChangeEvent("Anniversary");
                        } else {
                            announcementPresenter.ChangeText(currentWeekAnniversaries.TrimEnd());
                            announcementPresenter.ChangeEvent("Anniversary");
                        }
                    } else if (currentSlide == 2) {
                        if (string.IsNullOrEmpty(currentWeekAnnouncements)) {
                            announcementPresenter.ChangeText("No Announcement For This Week");
                            announcementPresenter.ChangeEvent("Announcement");
                        } else {
                            announcementPresenter.ChangeText(currentWeekAnnouncements.TrimEnd());
                            announcementPresenter.ChangeEvent("Announcement");
                        }
                    }
                }
            }

            if (keyData == Keys.Escape) {
                announcementPresenter.Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
