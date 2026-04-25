namespace GH_Studio {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            notesButton = new Button();
            liveButton = new Button();
            bibleButton = new Button();
            announcementsButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(notesButton, 2, 0);
            tableLayoutPanel1.Controls.Add(liveButton, 0, 0);
            tableLayoutPanel1.Controls.Add(bibleButton, 1, 0);
            tableLayoutPanel1.Controls.Add(announcementsButton, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1015, 54);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // notesButton
            // 
            notesButton.BackColor = Color.Wheat;
            notesButton.Cursor = Cursors.Hand;
            notesButton.Dock = DockStyle.Fill;
            notesButton.FlatStyle = FlatStyle.Flat;
            notesButton.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesButton.ForeColor = Color.Black;
            notesButton.Location = new Point(513, 9);
            notesButton.Margin = new Padding(6, 4, 6, 4);
            notesButton.Name = "notesButton";
            notesButton.Size = new Size(239, 36);
            notesButton.TabIndex = 5;
            notesButton.TabStop = false;
            notesButton.Text = "Notes";
            notesButton.UseVisualStyleBackColor = false;
            notesButton.Click += notesButton_Click;
            // 
            // liveButton
            // 
            liveButton.BackColor = Color.Wheat;
            liveButton.Cursor = Cursors.Hand;
            liveButton.Dock = DockStyle.Fill;
            liveButton.FlatStyle = FlatStyle.Flat;
            liveButton.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liveButton.ForeColor = Color.Black;
            liveButton.Location = new Point(11, 9);
            liveButton.Margin = new Padding(6, 4, 6, 4);
            liveButton.Name = "liveButton";
            liveButton.Size = new Size(239, 36);
            liveButton.TabIndex = 3;
            liveButton.TabStop = false;
            liveButton.Text = "Live";
            liveButton.UseVisualStyleBackColor = false;
            liveButton.Click += liveButton_Click;
            // 
            // bibleButton
            // 
            bibleButton.BackColor = Color.Wheat;
            bibleButton.Cursor = Cursors.Hand;
            bibleButton.Dock = DockStyle.Fill;
            bibleButton.FlatStyle = FlatStyle.Flat;
            bibleButton.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bibleButton.ForeColor = Color.Black;
            bibleButton.Location = new Point(262, 9);
            bibleButton.Margin = new Padding(6, 4, 6, 4);
            bibleButton.Name = "bibleButton";
            bibleButton.Size = new Size(239, 36);
            bibleButton.TabIndex = 4;
            bibleButton.TabStop = false;
            bibleButton.Text = "Bible";
            bibleButton.UseVisualStyleBackColor = false;
            bibleButton.Click += bibleButton_Click;
            // 
            // announcementsButton
            // 
            announcementsButton.BackColor = Color.Wheat;
            announcementsButton.Cursor = Cursors.Hand;
            announcementsButton.Dock = DockStyle.Fill;
            announcementsButton.FlatStyle = FlatStyle.Flat;
            announcementsButton.Location = new Point(764, 9);
            announcementsButton.Margin = new Padding(6, 4, 6, 4);
            announcementsButton.Name = "announcementsButton";
            announcementsButton.Size = new Size(240, 36);
            announcementsButton.TabIndex = 6;
            announcementsButton.TabStop = false;
            announcementsButton.Text = "Announcements";
            announcementsButton.UseVisualStyleBackColor = false;
            announcementsButton.Click += announcementsButton_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 600);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 54);
            label1.Name = "label1";
            label1.Size = new Size(1015, 2);
            label1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1015, 654);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GH Studio";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button notesButton;
        private Button liveButton;
        private Button bibleButton;
        private Panel panel1;
        private Label label1;
        private Button announcementsButton;
    }
}