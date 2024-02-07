namespace login
{
    partial class Form4
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
            btnSearch = new Button();
            dataGridViewSearch = new DataGridView();
            textSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtGrade = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtGender = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            txtSid = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.BlueViolet;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1133, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 41);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AllowUserToOrderColumns = true;
            dataGridViewSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(57, 352);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowHeadersWidth = 51;
            dataGridViewSearch.Size = new Size(1187, 157);
            dataGridViewSearch.TabIndex = 1;
            dataGridViewSearch.CellContentClick += dataGridViewSearch_CellContentClick;
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSearch.Location = new Point(57, 65);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(1047, 41);
            textSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(540, 12);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 3;
            label1.Text = "Student Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 147);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(233, 148);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(381, 27);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 187);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 4;
            label3.Text = "Grade";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(233, 187);
            txtGrade.Multiline = true;
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(381, 27);
            txtGrade.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 226);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 4;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 265);
            label5.Name = "label5";
            label5.Size = new Size(80, 28);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(233, 265);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(381, 27);
            txtGender.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(687, 146);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 4;
            label6.Text = "Mobile";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(687, 186);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 4;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(687, 225);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 4;
            label8.Text = "Subject id";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(863, 147);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(381, 27);
            txtMobile.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(863, 186);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(381, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtSid
            // 
            txtSid.Location = new Point(863, 225);
            txtSid.Multiline = true;
            txtSid.Name = "txtSid";
            txtSid.Size = new Size(381, 27);
            txtSid.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.BlueViolet;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(863, 294);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 29);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.BlueViolet;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1138, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.BlueViolet;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1000, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(231, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(383, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2024, 2, 6, 0, 0, 0, 0);
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1296, 537);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtGender);
            Controls.Add(txtSid);
            Controls.Add(txtAddress);
            Controls.Add(txtGrade);
            Controls.Add(txtMobile);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSearch);
            Controls.Add(dataGridViewSearch);
            Controls.Add(btnSearch);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridViewSearch;
        private TextBox textSearch;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtGrade;
        private Label label4;
        private Label label5;
        private TextBox txtGender;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private TextBox txtSid;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
    }
}