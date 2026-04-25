using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GH_Studio {

    public partial class BiblePresenter : Form {

        public BiblePresenter() {

            InitializeComponent();
        }

        private void BiblePresenter_Load(object sender, EventArgs e) {

            string fontString = File.ReadAllText(Constant.bibleFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;

            string colorString = File.ReadAllText(Constant.bibleFontColorFile);
            Color color = Color.FromName(colorString);

            string bgImage = File.ReadAllText(Constant.bibleBgImageFile);

            label1.Font = font;
            label1.ForeColor = color;
            label2.ForeColor = color;

            if (bgImage == String.Empty) {
                tableLayoutPanel1.BackgroundImage = null;
            } else {
                tableLayoutPanel1.BackgroundImage = new Bitmap(bgImage);
            }
        }

        public void ChangeText(string text) {

            label1.Text = text;
        }

        public void ChangeHeader(string text) {

            label2.Text = text;
        }
    }
}
