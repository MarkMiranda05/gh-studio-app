namespace GH_Studio {
    partial class Bible {
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            versionComboBox = new ComboBox();
            bookComboBox = new ComboBox();
            chapterComboBox = new ComboBox();
            panel1 = new Panel();
            listBox2 = new ListBox();
            changeColorButton = new Button();
            removeBackgroundButton = new Button();
            changeBackgroundButton = new Button();
            panel2 = new Panel();
            label4 = new Label();
            changeFontButton = new Button();
            goButton = new Button();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(510, 14);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 24;
            label3.Text = "Chapter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(247, 14);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 23;
            label2.Text = "Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 22;
            label1.Text = "Version";
            // 
            // versionComboBox
            // 
            versionComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            versionComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            versionComboBox.BackColor = SystemColors.Window;
            versionComboBox.Cursor = Cursors.Hand;
            versionComboBox.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            versionComboBox.FormattingEnabled = true;
            versionComboBox.Items.AddRange(new object[] { "World English Bible", "King James Version", "Tagalog" });
            versionComboBox.Location = new Point(11, 38);
            versionComboBox.Name = "versionComboBox";
            versionComboBox.Size = new Size(230, 25);
            versionComboBox.TabIndex = 0;
            versionComboBox.TabStop = false;
            // 
            // bookComboBox
            // 
            bookComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            bookComboBox.Cursor = Cursors.Hand;
            bookComboBox.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bookComboBox.FormattingEnabled = true;
            bookComboBox.Location = new Point(247, 38);
            bookComboBox.Name = "bookComboBox";
            bookComboBox.Size = new Size(257, 25);
            bookComboBox.TabIndex = 0;
            bookComboBox.TabStop = false;
            bookComboBox.SelectedValueChanged += bookComboBox_SelectedValueChanged;
            // 
            // chapterComboBox
            // 
            chapterComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            chapterComboBox.Cursor = Cursors.Hand;
            chapterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chapterComboBox.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chapterComboBox.FormattingEnabled = true;
            chapterComboBox.Location = new Point(510, 38);
            chapterComboBox.Name = "chapterComboBox";
            chapterComboBox.Size = new Size(110, 25);
            chapterComboBox.TabIndex = 0;
            chapterComboBox.TabStop = false;
            chapterComboBox.SelectedIndexChanged += chapterComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(changeColorButton);
            panel1.Controls.Add(removeBackgroundButton);
            panel1.Controls.Add(changeBackgroundButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(changeFontButton);
            panel1.Controls.Add(goButton);
            panel1.Controls.Add(versionComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chapterComboBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bookComboBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 572);
            panel1.TabIndex = 25;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(11, 145);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(609, 412);
            listBox2.TabIndex = 31;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // changeColorButton
            // 
            changeColorButton.BackColor = Color.Wheat;
            changeColorButton.Cursor = Cursors.Hand;
            changeColorButton.FlatStyle = FlatStyle.Flat;
            changeColorButton.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeColorButton.ForeColor = Color.Black;
            changeColorButton.Location = new Point(818, 222);
            changeColorButton.Margin = new Padding(4);
            changeColorButton.Name = "changeColorButton";
            changeColorButton.Size = new Size(161, 25);
            changeColorButton.TabIndex = 28;
            changeColorButton.TabStop = false;
            changeColorButton.Text = "Change Font Color";
            changeColorButton.UseVisualStyleBackColor = false;
            changeColorButton.Click += changeColorButton_Click;
            // 
            // removeBackgroundButton
            // 
            removeBackgroundButton.BackColor = Color.Wheat;
            removeBackgroundButton.Cursor = Cursors.Hand;
            removeBackgroundButton.FlatStyle = FlatStyle.Flat;
            removeBackgroundButton.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeBackgroundButton.ForeColor = Color.Black;
            removeBackgroundButton.Location = new Point(818, 255);
            removeBackgroundButton.Margin = new Padding(4);
            removeBackgroundButton.Name = "removeBackgroundButton";
            removeBackgroundButton.Size = new Size(161, 25);
            removeBackgroundButton.TabIndex = 27;
            removeBackgroundButton.TabStop = false;
            removeBackgroundButton.Text = "Remove Background";
            removeBackgroundButton.UseVisualStyleBackColor = false;
            removeBackgroundButton.Click += removeBackgroundButton_Click;
            // 
            // changeBackgroundButton
            // 
            changeBackgroundButton.BackColor = Color.Wheat;
            changeBackgroundButton.Cursor = Cursors.Hand;
            changeBackgroundButton.FlatStyle = FlatStyle.Flat;
            changeBackgroundButton.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeBackgroundButton.ForeColor = Color.Black;
            changeBackgroundButton.Location = new Point(649, 255);
            changeBackgroundButton.Margin = new Padding(4);
            changeBackgroundButton.Name = "changeBackgroundButton";
            changeBackgroundButton.Size = new Size(161, 25);
            changeBackgroundButton.TabIndex = 26;
            changeBackgroundButton.TabStop = false;
            changeBackgroundButton.Text = "Change Background";
            changeBackgroundButton.UseVisualStyleBackColor = false;
            changeBackgroundButton.Click += changeBackgroundButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Location = new Point(649, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 201);
            panel2.TabIndex = 25;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(328, 199);
            label4.TabIndex = 0;
            label4.Text = "GH Bible";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // changeFontButton
            // 
            changeFontButton.BackColor = Color.Wheat;
            changeFontButton.Cursor = Cursors.Hand;
            changeFontButton.FlatStyle = FlatStyle.Flat;
            changeFontButton.Font = new Font("Ebrima", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            changeFontButton.ForeColor = Color.Black;
            changeFontButton.Location = new Point(649, 222);
            changeFontButton.Margin = new Padding(4);
            changeFontButton.Name = "changeFontButton";
            changeFontButton.Size = new Size(161, 25);
            changeFontButton.TabIndex = 0;
            changeFontButton.TabStop = false;
            changeFontButton.Text = "Change Font Style";
            changeFontButton.UseVisualStyleBackColor = false;
            changeFontButton.Click += changeFontButton_Click;
            // 
            // goButton
            // 
            goButton.BackColor = Color.SandyBrown;
            goButton.Cursor = Cursors.Hand;
            goButton.FlatStyle = FlatStyle.Flat;
            goButton.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            goButton.ForeColor = Color.Black;
            goButton.Location = new Point(11, 70);
            goButton.Margin = new Padding(4);
            goButton.Name = "goButton";
            goButton.Size = new Size(609, 61);
            goButton.TabIndex = 0;
            goButton.TabStop = false;
            goButton.Text = "Go Live";
            goButton.UseVisualStyleBackColor = false;
            goButton.Click += goButton_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new Font("Ebrima", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Bible
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1015, 600);
            Controls.Add(panel1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Bible";
            Padding = new Padding(13, 14, 13, 14);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bible";
            Load += Bible_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox versionComboBox;
        private ComboBox bookComboBox;
        private ComboBox chapterComboBox;
        private Panel panel1;
        private Button goButton;
        private Button changeFontButton;
        private FontDialog fontDialog1;
        private Panel panel2;
        private Label label4;
        private Button changeBackgroundButton;
        private Button removeBackgroundButton;
        private Button changeColorButton;
        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox2;
    }
}