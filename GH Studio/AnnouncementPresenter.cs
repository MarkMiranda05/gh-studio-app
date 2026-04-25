using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH_Studio {

    public partial class AnnouncementPresenter : Form {

        public AnnouncementPresenter() {

            InitializeComponent();
        }

        private void AnnouncementPresenter_Load(object sender, EventArgs e) {

            string fontString = File.ReadAllText(Constant.eventFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;

            string bgImage = File.ReadAllText(Constant.birthdayBgImageFile);

            label1.Font = font;

            if (bgImage == String.Empty) {
                panel1.BackgroundImage = null;
            } else {
                panel1.BackgroundImage = new Bitmap(bgImage);
            }
        }

        public void ChangeText(string text) {

            label1.Text = text;
        }
        public void ChangeEvent(string text) {

            string bgImage = String.Empty;

            if ("Birthday" == text) {
                bgImage = File.ReadAllText(Constant.birthdayBgImageFile);
            } else if ("Anniversary" == text) {
                bgImage = File.ReadAllText(Constant.anniversaryBgImageFile);
            } else if ("Announcement" == text) {
                bgImage = File.ReadAllText(Constant.announcementBgImageFile);
            }

            if (bgImage == String.Empty) {
                panel1.BackgroundImage = null;
            } else {
                panel1.BackgroundImage = new Bitmap(bgImage);
            }
        }
    }
}
