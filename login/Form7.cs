using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "**********************************************************";
            txtResult.Text += "***               Fees Receipt                         ***";
            txtResult.Text += "**********************************************************";
            txtResult.Text += "Date :" + DateTime.Now + "\n\n";

            txtResult.Text += "Student Name:" + txtStudentId + "\n\n";
            txtResult.Text += "Student Name:" + txtSName + "\n\n";
            txtResult.Text += "Student Name:" + txtSuName + "\n\n";
            txtResult.Text += "Student Name:" + txtSGrade + "\n\n";
            txtResult.Text += "Student Name:" + txtSFee + "\n\n";

            txtResult.Text += "\n                  Signature";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
            txtSName.Text = "";
            txtSuName.Text = "";
            txtSGrade.Text = "";
            txtSFee.Text = "";
            txtResult.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text,new Font("Microsoft Sens Serif", 18, FontStyle.Bold),Brushes.Black,new Point(10, 10));
        }
    }
}
