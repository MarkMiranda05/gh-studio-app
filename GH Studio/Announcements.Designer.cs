namespace GH_Studio {
    partial class Announcements {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcements));
            panel1 = new Panel();
            goAnnounceButton = new Button();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            backgroundButton = new Button();
            deleteButton = new Button();
            listBox1 = new ListBox();
            addButton = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            listBox2 = new ListBox();
            button3 = new Button();
            fontStyleButton = new Button();
            groupBox4 = new GroupBox();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(goAnnounceButton);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 572);
            panel1.TabIndex = 0;
            // 
            // goAnnounceButton
            // 
            goAnnounceButton.BackColor = Color.Wheat;
            goAnnounceButton.Cursor = Cursors.Hand;
            goAnnounceButton.FlatStyle = FlatStyle.Flat;
            goAnnounceButton.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            goAnnounceButton.ForeColor = Color.Black;
            goAnnounceButton.Location = new Point(346, 349);
            goAnnounceButton.Name = "goAnnounceButton";
            goAnnounceButton.Size = new Size(313, 68);
            goAnnounceButton.TabIndex = 24;
            goAnnounceButton.TabStop = false;
            goAnnounceButton.Text = "Announce";
            goAnnounceButton.UseVisualStyleBackColor = false;
            goAnnounceButton.Click += goAnnounceButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(674, 10);
            groupBox3.Margin = new Padding(3, 10, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 291);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "General Announcements";
            // 
            // button4
            // 
            button4.BackColor = Color.Wheat;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(9, 249);
            button4.Name = "button4";
            button4.Size = new Size(297, 31);
            button4.TabIndex = 24;
            button4.TabStop = false;
            button4.Text = "Change Background";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 216);
            textBox1.TabIndex = 7;
            textBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(backgroundButton);
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(addButton);
            groupBox2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(0, 10);
            groupBox2.Margin = new Padding(3, 10, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 326);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Birthday";
            // 
            // backgroundButton
            // 
            backgroundButton.BackColor = Color.Wheat;
            backgroundButton.Cursor = Cursors.Hand;
            backgroundButton.FlatStyle = FlatStyle.Flat;
            backgroundButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backgroundButton.ForeColor = Color.Black;
            backgroundButton.Location = new Point(8, 284);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(313, 31);
            backgroundButton.TabIndex = 22;
            backgroundButton.TabStop = false;
            backgroundButton.Text = "Change Background";
            backgroundButton.UseVisualStyleBackColor = false;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Wheat;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(167, 247);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(154, 31);
            deleteButton.TabIndex = 4;
            deleteButton.TabStop = false;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(8, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(313, 214);
            listBox1.Sorted = true;
            listBox1.TabIndex = 1;
            listBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Wheat;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(8, 247);
            addButton.Name = "addButton";
            addButton.Size = new Size(153, 31);
            addButton.TabIndex = 0;
            addButton.TabStop = false;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(337, 10);
            groupBox1.Margin = new Padding(3, 10, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 326);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anniversary";
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(9, 284);
            button2.Name = "button2";
            button2.Size = new Size(313, 31);
            button2.TabIndex = 23;
            button2.TabStop = false;
            button2.Text = "Change Background";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(169, 247);
            button1.Name = "button1";
            button1.Size = new Size(153, 31);
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(9, 27);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(313, 214);
            listBox2.Sorted = true;
            listBox2.TabIndex = 1;
            listBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(9, 247);
            button3.Name = "button3";
            button3.Size = new Size(154, 31);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // fontStyleButton
            // 
            fontStyleButton.BackColor = Color.Wheat;
            fontStyleButton.Cursor = Cursors.Hand;
            fontStyleButton.FlatStyle = FlatStyle.Flat;
            fontStyleButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fontStyleButton.ForeColor = Color.Black;
            fontStyleButton.Location = new Point(8, 27);
            fontStyleButton.Name = "fontStyleButton";
            fontStyleButton.Size = new Size(313, 31);
            fontStyleButton.TabIndex = 25;
            fontStyleButton.TabStop = false;
            fontStyleButton.Text = "Change Font Style";
            fontStyleButton.UseVisualStyleBackColor = false;
            fontStyleButton.Click += fontStyleButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(fontStyleButton);
            groupBox4.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(13, 363);
            groupBox4.Margin = new Padding(3, 10, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(331, 68);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Config";
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new Font("Ebrima", 54.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Announcements
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1015, 600);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Announcements";
            Padding = new Padding(13, 14, 13, 14);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Announcements";
            Load += Announcements_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button deleteButton;
        private ListBox listBox2;
        private Button addButton;
        private GroupBox groupBox1;
        private Button button1;
        private ListBox listBox3;
        private Button button3;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button goAnnounceButton;
        private Button backgroundButton;
        private Button button2;
        private Button fontStyleButton;
        private GroupBox groupBox4;
        private FontDialog fontDialog1;
        private Button button4;
    }
}