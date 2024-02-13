namespace login
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblGrade = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentId = new TextBox();
            txtSName = new TextBox();
            txtSuName = new TextBox();
            txtSGrade = new TextBox();
            txtSFee = new TextBox();
            txtResult = new RichTextBox();
            btnGenarate = new Button();
            btnReset = new Button();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(587, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 38);
            label1.TabIndex = 0;
            label1.Text = "Fee Receipt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 172);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 234);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Subject Name";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrade.ForeColor = Color.White;
            lblGrade.Location = new Point(60, 292);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(68, 28);
            lblGrade.TabIndex = 3;
            lblGrade.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 111);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 4;
            label5.Text = "Student id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(60, 352);
            label6.Name = "label6";
            label6.Size = new Size(44, 28);
            label6.TabIndex = 5;
            label6.Text = "Fee";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(284, 111);
            txtStudentId.Multiline = true;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(374, 27);
            txtStudentId.TabIndex = 6;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(284, 172);
            txtSName.Multiline = true;
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(374, 28);
            txtSName.TabIndex = 7;
            // 
            // txtSuName
            // 
            txtSuName.Location = new Point(284, 234);
            txtSuName.Multiline = true;
            txtSuName.Name = "txtSuName";
            txtSuName.Size = new Size(374, 27);
            txtSuName.TabIndex = 8;
            // 
            // txtSGrade
            // 
            txtSGrade.Location = new Point(284, 292);
            txtSGrade.Multiline = true;
            txtSGrade.Name = "txtSGrade";
            txtSGrade.Size = new Size(374, 30);
            txtSGrade.TabIndex = 9;
            // 
            // txtSFee
            // 
            txtSFee.Location = new Point(284, 352);
            txtSFee.Multiline = true;
            txtSFee.Name = "txtSFee";
            txtSFee.Size = new Size(374, 30);
            txtSFee.TabIndex = 10;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(691, 61);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(596, 441);
            txtResult.TabIndex = 13;
            txtResult.Text = "";
            // 
            // btnGenarate
            // 
            btnGenarate.BackColor = Color.BlueViolet;
            btnGenarate.FlatStyle = FlatStyle.Popup;
            btnGenarate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenarate.ForeColor = Color.White;
            btnGenarate.Location = new Point(315, 432);
            btnGenarate.Name = "btnGenarate";
            btnGenarate.Size = new Size(98, 34);
            btnGenarate.TabIndex = 14;
            btnGenarate.Text = "Genarate";
            btnGenarate.UseVisualStyleBackColor = false;
            btnGenarate.Click += btnGenarate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.BlueViolet;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(439, 432);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 34);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.BlueViolet;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(560, 432);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(98, 34);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 432);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 17;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(190, 432);
            button2.Name = "button2";
            button2.Size = new Size(98, 34);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1338, 529);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPrint);
            Controls.Add(btnReset);
            Controls.Add(btnGenarate);
            Controls.Add(txtResult);
            Controls.Add(txtSFee);
            Controls.Add(txtSGrade);
            Controls.Add(txtSuName);
            Controls.Add(txtSName);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblGrade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "ASCEND EDUCATION CENTER : )";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblGrade;
        private Label label5;
        private Label label6;
        private TextBox txtStudentId;
        private TextBox txtSName;
        private TextBox txtSuName;
        private TextBox txtSGrade;
        private TextBox txtSFee;
        private RichTextBox txtResult;
        private Button btnGenarate;
        private Button btnReset;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Button button1;
        private Button button2;
    }
}