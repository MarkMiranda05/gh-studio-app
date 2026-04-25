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

    public partial class Presenter : Form {

        public Presenter() {

            InitializeComponent();
        }

        private void Presenter_Load(object sender, EventArgs e) {

            string fontString = File.ReadAllText(Constant.songFontStyleFile);
            FontConverter cvt = new();
            Font? font = cvt.ConvertFromString(fontString) as Font;

            string colorString = File.ReadAllText(Constant.songFontColorFile);
            Color color = Color.FromName(colorString);

            string bgImage = File.ReadAllText(Constant.songBgImageFile);

            label1.Font = font;
            label1.ForeColor = color;

            if (bgImage == String.Empty) {
                panel1.BackgroundImage = null;
            } else {
                panel1.BackgroundImage = new Bitmap(bgImage);
            }
        }

        public void ChangeText(string text) {

            label1.Text = text;
        }
    }
}
