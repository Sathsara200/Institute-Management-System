﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm2 = new Form10();
            frm2.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Form5 frm2 = new Form5();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm2 = new Form4();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 frm2 = new Form10();
            frm2.Show();
        }
    }
}
