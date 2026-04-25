namespace GH_Studio {
    partial class AddSong {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSong));
            lyricsTextBox = new TextBox();
            label2 = new Label();
            titleTextBox = new TextBox();
            label1 = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // lyricsTextBox
            // 
            lyricsTextBox.Location = new Point(12, 98);
            lyricsTextBox.Multiline = true;
            lyricsTextBox.Name = "lyricsTextBox";
            lyricsTextBox.ScrollBars = ScrollBars.Vertical;
            lyricsTextBox.Size = new Size(481, 331);
            lyricsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 6;
            label2.Text = "Lyrics";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 33);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(481, 29);
            titleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Wheat;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(12, 435);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(481, 32);
            saveButton.TabIndex = 8;
            saveButton.TabStop = false;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // AddSong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(505, 479);
            Controls.Add(saveButton);
            Controls.Add(lyricsTextBox);
            Controls.Add(label2);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddSong";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Song";
            Load += AddSong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lyricsTextBox;
        private Label label2;
        private TextBox titleTextBox;
        private Label label1;
        private Button saveButton;
    }
}