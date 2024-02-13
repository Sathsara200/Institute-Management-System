using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = " select * from fee_deatail where fee_date = '" + this.dateTimePicker1.Text + "' AND subject_name = '" + textBox7.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (Isvalid())
            {

                SqlCommand cmd = new SqlCommand("insert into fee_deatail values (@student_id,@subject_id,@status,@student_name,@subject_name,@fee_date)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@student_id", textBox5.Text);
                cmd.Parameters.AddWithValue("@subject_id", textBox3.Text);
                cmd.Parameters.AddWithValue("@status", textBox4.Text);
                cmd.Parameters.AddWithValue("@student_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@subject_name", textBox6.Text);
                cmd.Parameters.AddWithValue("@fee_date", dateTimePicker3.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("New teacher is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private bool Isvalid()
        {
            if ((textBox2.Text == string.Empty) || (textBox1.Text != ""))
            {
                MessageBox.Show("Teacher name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;


        }
        void display()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from fee_deatail", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  fee_deatail set student_id = @student_id,subject_id=@subject_id,status=@status,student_name=@student_name,subject_name=@subject_name,fee_date=@fee_date where fee_id=@fee_id ", con);
            cmd.Parameters.AddWithValue("@fee_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@student_id", textBox5.Text);
            cmd.Parameters.AddWithValue("@subject_id", textBox3.Text);
            cmd.Parameters.AddWithValue("@student_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@subject_name", textBox6.Text);
            cmd.Parameters.AddWithValue("@fee_date", dateTimePicker3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete fee_deatail where fee_id=@fee_id", con);
            cmd.Parameters.AddWithValue("@fee_id", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

