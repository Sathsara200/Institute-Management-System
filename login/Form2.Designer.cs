namespace login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel7 = new Panel();
            buttonRegister = new Button();
            buttonReport = new Button();
            buttonAddStudents = new Button();
            buttonAddClass = new Button();
            buttonAttendance = new Button();
            buttonDashboard = new Button();
            panel8 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            panelExpand = new Panel();
            panel6 = new Panel();
            buttonLogout = new Button();
            panel5 = new Panel();
            button1 = new Button();
            buttonMinimize = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panelExpand.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 3, 125);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 673);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonRegister);
            panel7.Controls.Add(buttonReport);
            panel7.Controls.Add(buttonAddStudents);
            panel7.Controls.Add(buttonAddClass);
            panel7.Controls.Add(buttonAttendance);
            panel7.Controls.Add(buttonDashboard);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 180);
            panel7.Name = "panel7";
            panel7.Size = new Size(258, 493);
            panel7.TabIndex = 2;
            // 
            // buttonRegister
            // 
            buttonRegister.Dock = DockStyle.Top;
            buttonRegister.FlatAppearance.BorderColor = Color.White;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.White;
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.White;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Image = Properties.Resources.report1;
            buttonRegister.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegister.Location = new Point(0, 338);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(258, 69);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "  Report";
            buttonRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderColor = Color.White;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatAppearance.MouseDownBackColor = Color.White;
            buttonReport.FlatAppearance.MouseOverBackColor = Color.White;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = Properties.Resources.te;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 269);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(258, 69);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "  Teachers";
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAddStudents
            // 
            buttonAddStudents.Dock = DockStyle.Top;
            buttonAddStudents.FlatAppearance.BorderColor = Color.White;
            buttonAddStudents.FlatAppearance.BorderSize = 0;
            buttonAddStudents.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAddStudents.FlatAppearance.MouseOverBackColor = Color.White;
            buttonAddStudents.FlatStyle = FlatStyle.Flat;
            buttonAddStudents.ForeColor = Color.White;
            buttonAddStudents.Image = Properties.Resources.students;
            buttonAddStudents.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddStudents.Location = new Point(0, 210);
            buttonAddStudents.Name = "buttonAddStudents";
            buttonAddStudents.Size = new Size(258, 59);
            buttonAddStudents.TabIndex = 0;
            buttonAddStudents.Text = "  Students";
            buttonAddStudents.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddStudents.UseVisualStyleBackColor = true;
            buttonAddStudents.Click += buttonAddStudents_Click_1;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Dock = DockStyle.Top;
            buttonAddClass.FlatAppearance.BorderColor = Color.White;
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAddClass.FlatAppearance.MouseOverBackColor = Color.White;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Image = Properties.Resources.class1;
            buttonAddClass.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddClass.Location = new Point(0, 133);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(258, 77);
            buttonAddClass.TabIndex = 0;
            buttonAddClass.Text = "  Add Class";
            buttonAddClass.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddClass.UseVisualStyleBackColor = true;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderColor = Color.White;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAttendance.FlatAppearance.MouseOverBackColor = Color.White;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = Properties.Resources.check;
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(0, 56);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(258, 77);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "  Attendance";
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderColor = Color.White;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatAppearance.MouseDownBackColor = Color.White;
            buttonDashboard.FlatAppearance.MouseOverBackColor = Color.White;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = Properties.Resources.Dash;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 0);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(258, 56);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "  Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(8, 47);
            panel8.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 180);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 148);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 125);
            label1.Name = "label1";
            label1.Size = new Size(223, 23);
            label1.TabIndex = 0;
            label1.Text = "Institute Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(52, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBoxExpand);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(258, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 190);
            panel3.TabIndex = 1;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.DD;
            pictureBoxExpand.Location = new Point(766, 36);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(23, 29);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 9;
            pictureBoxExpand.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.logo2;
            pictureBox2.Location = new Point(698, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(67, 3, 125);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 0;
            label3.Text = "{?}";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(67, 3, 125);
            panel4.Controls.Add(panelExpand);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(924, 125);
            panel4.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(67, 3, 125);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(panel6);
            panelExpand.Controls.Add(panel5);
            panelExpand.Location = new Point(698, 0);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(214, 126);
            panelExpand.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(buttonLogout);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(212, 51);
            panel6.TabIndex = 0;
            panel6.Paint += panel6_Paint;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.FromArgb(67, 3, 125);
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(22, 0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(177, 48);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Log-out";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Controls.Add(buttonMinimize);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 45);
            panel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(67, 3, 125);
            button1.Image = Properties.Resources.min;
            button1.Location = new Point(0, 48);
            button1.Name = "button1";
            button1.Size = new Size(212, 48);
            button1.TabIndex = 1;
            button1.Text = "  Minimize";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinimize.ForeColor = Color.FromArgb(67, 3, 125);
            buttonMinimize.Image = Properties.Resources.min;
            buttonMinimize.Location = new Point(0, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(212, 48);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = "  Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(139, 60);
            label6.Name = "label6";
            label6.Size = new Size(41, 27);
            label6.TabIndex = 0;
            label6.Text = "{?}";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(67, 27);
            label7.TabIndex = 0;
            label7.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(139, 19);
            label5.Name = "label5";
            label5.Size = new Size(41, 27);
            label5.TabIndex = 0;
            label5.Text = "{?}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 27);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Institute Management System";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelExpand.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private Panel panelExpand;
        private Panel panel5;
        private Button buttonMinimize;
        private Button button1;
        private Panel panel6;
        private Button buttonLogout;
        private Panel panel7;
        private Button buttonDashboard;
        private Panel panel8;
        private Button buttonAttendance;
        private Button buttonAddClass;
        private Button buttonAddStudents;
        private Button buttonReport;
        private Button buttonRegister;
    }
}