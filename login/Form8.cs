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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = "select * from student_attendance where id = '" + textBox5.Text + "'";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (Isvalid())
            {

                SqlCommand cmd = new SqlCommand("insert into student_attendance values (@subject_id,@status,@date,@grade,@student_id,@student_name)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@subject_id", textBox3.Text);
                cmd.Parameters.AddWithValue("@status", textBox8.Text);
                cmd.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@grade", textBox7.Text);
                cmd.Parameters.AddWithValue("@student_id", textBox4.Text);
                cmd.Parameters.AddWithValue("@student_name", textBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("New student is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        void display()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student_attendance", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private bool Isvalid()
        {
            if ((textBox1.Text == string.Empty) || (textBox2.Text != ""))
            {
                MessageBox.Show("Student name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  student_attendance set subject_id = @subject_id,status=@status,date=@date,grade=@grade,student_id=@student_id,student_name=@student_name where id=@id ", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@subject_id", textBox3.Text);
            cmd.Parameters.AddWithValue("@status", textBox8.Text);
            cmd.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@grade", textBox7.Text);
            cmd.Parameters.AddWithValue("@student_id", textBox4.Text);
            cmd.Parameters.AddWithValue("@student_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete student_attendance where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox2.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load_1(object sender, EventArgs e)
        {

        }
    }

}

