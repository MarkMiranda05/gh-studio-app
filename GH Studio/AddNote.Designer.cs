namespace GH_Studio {
    partial class AddNote {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            saveButton = new Button();
            contentTextBox = new TextBox();
            label2 = new Label();
            titleTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.SandyBrown;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(12, 436);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(481, 32);
            saveButton.TabIndex = 13;
            saveButton.TabStop = false;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.Location = new Point(12, 99);
            contentTextBox.Multiline = true;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.ScrollBars = ScrollBars.Vertical;
            contentTextBox.Size = new Size(481, 331);
            contentTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 11;
            label2.Text = "Content";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 34);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(481, 29);
            titleTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // AddNote
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(505, 479);
            Controls.Add(saveButton);
            Controls.Add(contentTextBox);
            Controls.Add(label2);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AddNote";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Note";
            Load += AddNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox contentTextBox;
        private Label label2;
        private TextBox titleTextBox;
        private Label label1;
    }
}