namespace login
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            dateTimePicker4 = new DateTimePicker();
            textBox1 = new TextBox();
            txtStatus = new TextBox();
            txtTId = new TextBox();
            txtTAName = new TextBox();
            txtTAId = new TextBox();
            buttonSearch = new Button();
            buttonClear = new Button();
            button3 = new Button();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Location = new Point(646, 104);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(287, 27);
            dateTimePicker4.TabIndex = 0;
            dateTimePicker4.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(870, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(646, 147);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(287, 27);
            txtStatus.TabIndex = 2;
            // 
            // txtTId
            // 
            txtTId.Location = new Point(190, 186);
            txtTId.Name = "txtTId";
            txtTId.Size = new Size(287, 27);
            txtTId.TabIndex = 2;
            txtTId.TextChanged += textBox3_TextChanged;
            // 
            // txtTAName
            // 
            txtTAName.Location = new Point(190, 144);
            txtTAName.Name = "txtTAName";
            txtTAName.Size = new Size(287, 27);
            txtTAName.TabIndex = 2;
            txtTAName.TextChanged += txtTAName_TextChanged;
            // 
            // txtTAId
            // 
            txtTAId.Location = new Point(191, 102);
            txtTAId.Name = "txtTAId";
            txtTAId.Size = new Size(287, 27);
            txtTAId.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.BlueViolet;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(987, 58);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.BlueViolet;
            buttonClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(987, 277);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(987, 160);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = Color.BlueViolet;
            buttonInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInsert.ForeColor = Color.White;
            buttonInsert.Location = new Point(987, 119);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 6;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.BlueViolet;
            buttonUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(987, 202);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1018, 135);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(63, 143);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 10;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(63, 186);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 10;
            label1.Text = "Teachet ID";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(532, 101);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(63, 102);
            label5.Name = "label5";
            label5.Size = new Size(33, 28);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(532, 140);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 10;
            label6.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(456, 9);
            label4.Name = "label4";
            label4.Size = new Size(294, 41);
            label4.TabIndex = 10;
            label4.Text = "Teacher Attendance";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.BlueViolet;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(987, 239);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1146, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(button3);
            Controls.Add(buttonClear);
            Controls.Add(buttonSearch);
            Controls.Add(txtTAId);
            Controls.Add(txtTAName);
            Controls.Add(txtTId);
            Controls.Add(txtStatus);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form9";
            Text = "ASCEND EDUCATION CENTER : )";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker4;
        private TextBox textBox1;
        private TextBox txtStatus;
        private TextBox txtTId;
        private TextBox txtTAName;
        private TextBox txtTAId;
        private Button buttonSearch;
        private Button buttonClear;
        private Button button3;
        private Button buttonInsert;
        private Button buttonUpdate;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Button button1;
    }
}