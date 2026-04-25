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

    public partial class AddEvent : Form {

        public static string EventType = "";

        public AddEvent() {

            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(nameTextBox.Text)) {
                MessageBox.Show("Name can't be empty.", "GH Studio Warning", MessageBoxButtons.OK);
            } else {
                string formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameTextBox.Text.Trim().ToLower());
                string fileName = formattedName + ".ghlive";
                string filePath = "";

                if (EventType.Equals("Birthday")) {
                    filePath = Path.Combine(Constant.birthdayPath, fileName);
                } else if (EventType.Equals("Anniversary")) {
                    filePath = Path.Combine(Constant.anniversaryPath, fileName);
                }

                if (!File.Exists(filePath)) {
                    string content = nameTextBox.Text.Trim().ToUpper() + "=" + dateTimePicker1.Text;
                    TextWriter txt = new StreamWriter(filePath);
                    txt.Write(content);
                    txt.Close();

                    this.Close();
                } else {
                    MessageBox.Show("Name already existed.", "GH Studio Warning", MessageBoxButtons.OK);
                }
            }
        }
    }
}
