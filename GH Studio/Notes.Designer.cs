namespace GH_Studio {
    partial class Notes {
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            changeFontButton = new Button();
            deleteButton = new Button();
            selectButton = new Button();
            listBox1 = new ListBox();
            updateButton = new Button();
            addButton = new Button();
            fontDialog1 = new FontDialog();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 572);
            panel1.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(changeFontButton);
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(selectButton);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(updateButton);
            groupBox2.Controls.Add(addButton);
            groupBox2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(15, 19);
            groupBox2.Margin = new Padding(3, 10, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 393);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Notes";
            // 
            // changeFontButton
            // 
            changeFontButton.BackColor = Color.Wheat;
            changeFontButton.Cursor = Cursors.Hand;
            changeFontButton.FlatStyle = FlatStyle.Flat;
            changeFontButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            changeFontButton.ForeColor = Color.Black;
            changeFontButton.Location = new Point(379, 268);
            changeFontButton.Name = "changeFontButton";
            changeFontButton.Size = new Size(119, 31);
            changeFontButton.TabIndex = 5;
            changeFontButton.TabStop = false;
            changeFontButton.Text = "Change Font";
            changeFontButton.UseVisualStyleBackColor = false;
            changeFontButton.Click += changeFontButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Wheat;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(256, 268);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(119, 31);
            deleteButton.TabIndex = 4;
            deleteButton.TabStop = false;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.Wheat;
            selectButton.Cursor = Cursors.Hand;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectButton.ForeColor = Color.Black;
            selectButton.Location = new Point(6, 317);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(492, 68);
            selectButton.TabIndex = 2;
            selectButton.TabStop = false;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Khaki;
            listBox1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(6, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(492, 235);
            listBox1.Sorted = true;
            listBox1.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Wheat;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(131, 268);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(119, 31);
            updateButton.TabIndex = 1;
            updateButton.TabStop = false;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Wheat;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(6, 268);
            addButton.Name = "addButton";
            addButton.Size = new Size(119, 31);
            addButton.TabIndex = 0;
            addButton.TabStop = false;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new Font("Ebrima", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Notes
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
            Name = "Notes";
            Padding = new Padding(13, 14, 13, 14);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            Load += Notes_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox groupBox2;
        private Button deleteButton;
        private ListBox listBox1;
        private Button selectButton;
        private Button updateButton;
        private Button addButton;
        private Button changeFontButton;
        private FontDialog fontDialog1;
    }
}