namespace login
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            bttnSearch = new Button();
            txxtSearch = new TextBox();
            textId = new TextBox();
            bttnInsert = new Button();
            bttnDelete = new Button();
            button3 = new Button();
            label1 = new Label();
            textName = new TextBox();
            textMobile = new TextBox();
            textGender = new TextBox();
            textAddress = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // bttnSearch
            // 
            bttnSearch.BackColor = Color.BlueViolet;
            bttnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnSearch.ForeColor = Color.White;
            bttnSearch.Location = new Point(1133, 65);
            bttnSearch.Name = "bttnSearch";
            bttnSearch.Size = new Size(111, 41);
            bttnSearch.TabIndex = 0;
            bttnSearch.Text = "Search";
            bttnSearch.UseVisualStyleBackColor = false;
            bttnSearch.Click += bttnSearch_Click;
            // 
            // txxtSearch
            // 
            txxtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txxtSearch.Location = new Point(57, 65);
            txxtSearch.Multiline = true;
            txxtSearch.Name = "txxtSearch";
            txxtSearch.Size = new Size(1047, 41);
            txxtSearch.TabIndex = 1;
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textId.Location = new Point(230, 147);
            textId.Multiline = true;
            textId.Name = "textId";
            textId.Size = new Size(381, 27);
            textId.TabIndex = 2;
            textId.TextChanged += textBox2_TextChanged;
            // 
            // bttnInsert
            // 
            bttnInsert.BackColor = Color.BlueViolet;
            bttnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnInsert.ForeColor = Color.White;
            bttnInsert.Location = new Point(863, 306);
            bttnInsert.Name = "bttnInsert";
            bttnInsert.Size = new Size(106, 29);
            bttnInsert.TabIndex = 3;
            bttnInsert.Text = "Insert";
            bttnInsert.UseVisualStyleBackColor = false;
            bttnInsert.Click += bttnInsert_Click;
            // 
            // bttnDelete
            // 
            bttnDelete.BackColor = Color.BlueViolet;
            bttnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttnDelete.ForeColor = Color.White;
            bttnDelete.Location = new Point(1138, 306);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(106, 29);
            bttnDelete.TabIndex = 3;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = false;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.BlueViolet;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(999, 306);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 3;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(540, 10);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 4;
            label1.Text = "Student Details";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textName.Location = new Point(230, 225);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(381, 27);
            textName.TabIndex = 2;
            textName.TextChanged += textBox2_TextChanged;
            // 
            // textMobile
            // 
            textMobile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textMobile.Location = new Point(863, 186);
            textMobile.Multiline = true;
            textMobile.Name = "textMobile";
            textMobile.Size = new Size(381, 27);
            textMobile.TabIndex = 2;
            textMobile.TextChanged += textBox2_TextChanged;
            // 
            // textGender
            // 
            textGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textGender.Location = new Point(863, 147);
            textGender.Multiline = true;
            textGender.Name = "textGender";
            textGender.Size = new Size(381, 27);
            textGender.TabIndex = 2;
            textGender.TextChanged += textBox2_TextChanged;
            // 
            // textAddress
            // 
            textAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textAddress.Location = new Point(863, 224);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(381, 27);
            textAddress.TabIndex = 2;
            textAddress.TextChanged += textBox2_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(230, 264);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(381, 31);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 147);
            label3.Name = "label3";
            label3.Size = new Size(30, 28);
            label3.TabIndex = 7;
            label3.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 224);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 266);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 7;
            label5.Text = "Date of birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(687, 146);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 8;
            label6.Text = "Gender";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(687, 186);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 8;
            label7.Text = "Mobile";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(687, 226);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(57, 352);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1187, 157);
            dataGridView2.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(57, 185);
            label9.Name = "label9";
            label9.Size = new Size(68, 28);
            label9.TabIndex = 7;
            label9.Text = "Grade";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(230, 186);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(863, 262);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(687, 264);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 8;
            label10.Text = "Subject_id";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Indigo;
            ClientSize = new Size(1296, 537);
            Controls.Add(dataGridView2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textAddress);
            Controls.Add(textGender);
            Controls.Add(textMobile);
            Controls.Add(bttnDelete);
            Controls.Add(textName);
            Controls.Add(textBox1);
            Controls.Add(bttnInsert);
            Controls.Add(textId);
            Controls.Add(txxtSearch);
            Controls.Add(bttnSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnSearch;
        private TextBox txxtSearch;
        private TextBox textId;
        private Button bttnInsert;
        private Button bttnDelete;
        private Button button3;
        private Label label1;
        private TextBox textName;
        private TextBox textMobile;
        private TextBox textGender;
        private TextBox textAddress;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView2;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label10;
    }
}