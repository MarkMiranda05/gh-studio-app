namespace GH_Studio {
    partial class Live {
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
            goLiveButton = new Button();
            removeBGButton = new Button();
            backgroundButton = new Button();
            fontStyleButton = new Button();
            fontColorButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            deleteButton = new Button();
            listBox2 = new ListBox();
            selectButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            groupBox1 = new GroupBox();
            moveUpButton = new Button();
            listBox1 = new ListBox();
            removeButton = new Button();
            moveDownButton = new Button();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(goLiveButton);
            panel1.Controls.Add(removeBGButton);
            panel1.Controls.Add(backgroundButton);
            panel1.Controls.Add(fontStyleButton);
            panel1.Controls.Add(fontColorButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 572);
            panel1.TabIndex = 0;
            // 
            // goLiveButton
            // 
            goLiveButton.BackColor = Color.Wheat;
            goLiveButton.Cursor = Cursors.Hand;
            goLiveButton.FlatStyle = FlatStyle.Flat;
            goLiveButton.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            goLiveButton.ForeColor = Color.Black;
            goLiveButton.Location = new Point(363, 492);
            goLiveButton.Name = "goLiveButton";
            goLiveButton.Size = new Size(615, 68);
            goLiveButton.TabIndex = 23;
            goLiveButton.TabStop = false;
            goLiveButton.Text = "Live";
            goLiveButton.UseVisualStyleBackColor = false;
            goLiveButton.Click += goLiveButton_Click;
            // 
            // removeBGButton
            // 
            removeBGButton.BackColor = Color.Wheat;
            removeBGButton.Cursor = Cursors.Hand;
            removeBGButton.FlatStyle = FlatStyle.Flat;
            removeBGButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeBGButton.ForeColor = Color.Black;
            removeBGButton.Location = new Point(674, 423);
            removeBGButton.Name = "removeBGButton";
            removeBGButton.Size = new Size(303, 31);
            removeBGButton.TabIndex = 22;
            removeBGButton.TabStop = false;
            removeBGButton.Text = "Remove Background";
            removeBGButton.UseVisualStyleBackColor = false;
            removeBGButton.Click += removeBGButton_Click;
            // 
            // backgroundButton
            // 
            backgroundButton.BackColor = Color.Wheat;
            backgroundButton.Cursor = Cursors.Hand;
            backgroundButton.FlatStyle = FlatStyle.Flat;
            backgroundButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            backgroundButton.ForeColor = Color.Black;
            backgroundButton.Location = new Point(362, 423);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(304, 31);
            backgroundButton.TabIndex = 21;
            backgroundButton.TabStop = false;
            backgroundButton.Text = "Change Background";
            backgroundButton.UseVisualStyleBackColor = false;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // fontStyleButton
            // 
            fontStyleButton.BackColor = Color.Wheat;
            fontStyleButton.Cursor = Cursors.Hand;
            fontStyleButton.FlatStyle = FlatStyle.Flat;
            fontStyleButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fontStyleButton.ForeColor = Color.Black;
            fontStyleButton.Location = new Point(362, 386);
            fontStyleButton.Name = "fontStyleButton";
            fontStyleButton.Size = new Size(304, 31);
            fontStyleButton.TabIndex = 19;
            fontStyleButton.TabStop = false;
            fontStyleButton.Text = "Change Font Style";
            fontStyleButton.UseVisualStyleBackColor = false;
            fontStyleButton.Click += fontStyleButton_Click;
            // 
            // fontColorButton
            // 
            fontColorButton.BackColor = Color.Wheat;
            fontColorButton.Cursor = Cursors.Hand;
            fontColorButton.FlatStyle = FlatStyle.Flat;
            fontColorButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fontColorButton.ForeColor = Color.Black;
            fontColorButton.Location = new Point(674, 386);
            fontColorButton.Name = "fontColorButton";
            fontColorButton.Size = new Size(303, 31);
            fontColorButton.TabIndex = 20;
            fontColorButton.TabStop = false;
            fontColorButton.Text = "Change Font Color";
            fontColorButton.UseVisualStyleBackColor = false;
            fontColorButton.Click += fontColorButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(362, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 365);
            panel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(613, 363);
            label1.TabIndex = 1;
            label1.Text = "GH Live";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.25874F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 58.74126F));
            tableLayoutPanel2.Size = new Size(343, 572);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(listBox2);
            groupBox2.Controls.Add(selectButton);
            groupBox2.Controls.Add(updateButton);
            groupBox2.Controls.Add(addButton);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 245);
            groupBox2.Margin = new Padding(3, 10, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 324);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Songs";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Wheat;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(227, 284);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(101, 31);
            deleteButton.TabIndex = 4;
            deleteButton.TabStop = false;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(9, 27);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(319, 214);
            listBox2.Sorted = true;
            listBox2.TabIndex = 1;
            listBox2.TabStop = false;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.Wheat;
            selectButton.Cursor = Cursors.Hand;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectButton.ForeColor = Color.Black;
            selectButton.Location = new Point(9, 247);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(319, 31);
            selectButton.TabIndex = 2;
            selectButton.TabStop = false;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Wheat;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(118, 284);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(101, 31);
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
            addButton.Location = new Point(9, 284);
            addButton.Name = "addButton";
            addButton.Size = new Size(101, 31);
            addButton.TabIndex = 0;
            addButton.TabStop = false;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(moveUpButton);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(removeButton);
            groupBox1.Controls.Add(moveDownButton);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(335, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Playlist";
            // 
            // moveUpButton
            // 
            moveUpButton.BackColor = Color.Wheat;
            moveUpButton.Cursor = Cursors.Hand;
            moveUpButton.FlatStyle = FlatStyle.Flat;
            moveUpButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            moveUpButton.ForeColor = Color.Black;
            moveUpButton.Location = new Point(8, 188);
            moveUpButton.Margin = new Padding(4);
            moveUpButton.Name = "moveUpButton";
            moveUpButton.Size = new Size(101, 31);
            moveUpButton.TabIndex = 0;
            moveUpButton.TabStop = false;
            moveUpButton.Text = "Move Up";
            moveUpButton.UseVisualStyleBackColor = false;
            moveUpButton.Click += moveUpButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(8, 29);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(319, 151);
            listBox1.TabIndex = 1;
            listBox1.TabStop = false;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Wheat;
            removeButton.Cursor = Cursors.Hand;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.ForeColor = Color.Black;
            removeButton.Location = new Point(226, 188);
            removeButton.Margin = new Padding(4);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(101, 31);
            removeButton.TabIndex = 2;
            removeButton.TabStop = false;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // moveDownButton
            // 
            moveDownButton.BackColor = Color.Wheat;
            moveDownButton.Cursor = Cursors.Hand;
            moveDownButton.FlatStyle = FlatStyle.Flat;
            moveDownButton.Font = new Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            moveDownButton.ForeColor = Color.Black;
            moveDownButton.Location = new Point(117, 188);
            moveDownButton.Margin = new Padding(4);
            moveDownButton.Name = "moveDownButton";
            moveDownButton.Size = new Size(101, 31);
            moveDownButton.TabIndex = 1;
            moveDownButton.TabStop = false;
            moveDownButton.Text = "Move Down";
            moveDownButton.UseVisualStyleBackColor = false;
            moveDownButton.Click += moveDownButton_Click;
            // 
            // Live
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1015, 600);
            Controls.Add(panel1);
            Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Live";
            Padding = new Padding(13, 14, 13, 14);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Live";
            Load += Live_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button goLiveButton;
        private Button removeBGButton;
        private Button backgroundButton;
        private Button fontStyleButton;
        private Button fontColorButton;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private Button deleteButton;
        private ListBox listBox2;
        private Button selectButton;
        private Button updateButton;
        private Button addButton;
        private GroupBox groupBox1;
        private Button moveUpButton;
        private ListBox listBox1;
        private Button removeButton;
        private Button moveDownButton;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}