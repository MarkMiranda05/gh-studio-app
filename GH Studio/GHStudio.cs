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

    public partial class GHStudio : Form {

        public GHStudio() {

            InitializeComponent();
        }

        private void GHStudio_Load(object sender, EventArgs e) {

            string bgImage = File.ReadAllText(Constant.ghStudioBgImageFile);

            if (bgImage == String.Empty) {
                this.BackgroundImage = null;
            } else {
                this.BackgroundImage = new Bitmap(bgImage);
            }
        }
    }
}
