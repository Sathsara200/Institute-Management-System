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
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1007, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 41);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.AllowUserToOrderColumns = true;
            dataGridViewSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(51, 98);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowHeadersWidth = 51;
            dataGridViewSearch.Size = new Size(1055, 373);
            dataGridViewSearch.TabIndex = 1;
            dataGridViewSearch.CellContentClick += dataGridViewSearch_CellContentClick;
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSearch.Location = new Point(51, 36);
            textSearch.Multiline = true;
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(931, 41);
            textSearch.TabIndex = 2;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1152, 499);
            Controls.Add(textSearch);
            Controls.Add(dataGridViewSearch);
            Controls.Add(btnSearch);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private DataGridView dataGridViewSearch;
        private TextBox textSearch;
    }
}