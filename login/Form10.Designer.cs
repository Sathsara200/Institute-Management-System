namespace login
{
    partial class Form10
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtGender = new TextBox();
            txtMobile = new TextBox();
            txtAddress = new TextBox();
            txtSalary = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(540, 12);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 0;
            label1.Text = "Teacher Details";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(57, 65);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1047, 41);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.BlueViolet;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1133, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(57, 146);
            label2.Name = "label2";
            label2.Size = new Size(30, 28);
            label2.TabIndex = 3;
            label2.Text = "Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(54, 263);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 5;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(687, 186);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 6;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(54, 224);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 7;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(687, 146);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 8;
            label7.Text = "Mobile";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1187, 157);
            dataGridView1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(687, 225);
            label8.Name = "label8";
            label8.Size = new Size(71, 28);
            label8.TabIndex = 10;
            label8.Text = "Salary";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(230, 146);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(381, 25);
            txtId.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(230, 185);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(381, 27);
            txtName.TabIndex = 11;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(230, 224);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(381, 27);
            txtGender.TabIndex = 11;
            // 
            // txtMobile
            // 
            txtMobile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMobile.Location = new Point(863, 147);
            txtMobile.Multiline = true;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(381, 27);
            txtMobile.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(863, 186);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(381, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(863, 225);
            txtSalary.Multiline = true;
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(381, 27);
            txtSalary.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(228, 263);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(381, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.BlueViolet;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(863, 294);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 29);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.BlueViolet;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1000, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.BlueViolet;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1138, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1296, 537);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSalary);
            Controls.Add(txtAddress);
            Controls.Add(txtMobile);
            Controls.Add(txtGender);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtGender;
        private TextBox txtMobile;
        private TextBox txtAddress;
        private TextBox txtSalary;
        private DateTimePicker dateTimePicker1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}