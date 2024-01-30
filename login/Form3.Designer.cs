namespace login
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            textwelcome = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnDashboard = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 720);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(259, 167);
            panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(257, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(939, 112);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(257, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 156);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textwelcome);
            panel4.Location = new Point(257, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 92);
            panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1074, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // textwelcome
            // 
            textwelcome.BackColor = Color.Indigo;
            textwelcome.ForeColor = Color.White;
            textwelcome.Location = new Point(149, 28);
            textwelcome.Multiline = true;
            textwelcome.Name = "textwelcome";
            textwelcome.Size = new Size(38, 35);
            textwelcome.TabIndex = 1;
            textwelcome.Text = "{?}";
            textwelcome.TextChanged += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 73);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ascend Education Center";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Indigo;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(28, 28);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "Welcome:";
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Indigo;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(44, 182);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(212, 47);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Profile";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 235);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(44, 235);
            button2.Name = "button2";
            button2.Size = new Size(215, 47);
            button2.TabIndex = 4;
            button2.Text = "Dashboard";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1, 182);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1, 289);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(48, 289);
            button1.Name = "button1";
            button1.Size = new Size(215, 47);
            button1.TabIndex = 4;
            button1.Text = "Log Out";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textwelcome;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button2;
        private PictureBox pictureBox5;
        private Button button1;
    }
}