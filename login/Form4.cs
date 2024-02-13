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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete employe where emp_id=@emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", int.Parse(textBox6.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            view2();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = "select * from employe where emp_id = '" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (Isvalid())
            {

                SqlCommand cmd = new SqlCommand("insert into employe values (@emp_name,@emp_dob,@emp_gender,@emp_mobile,@emp_address,@emp_salary)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@emp_name", textBox6.Text);
                cmd.Parameters.AddWithValue("@emp_dob", this.dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@emp_gender", textBox1.Text);
                cmd.Parameters.AddWithValue("@emp_mobile", textBox2.Text);
                cmd.Parameters.AddWithValue("@emp_address", textBox7.Text);
                cmd.Parameters.AddWithValue("@emp_salary", textBox8.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                view2();
                MessageBox.Show("New employe is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        void view2()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employe", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView3.DataSource = dt;
        }
        private bool Isvalid()
        {
            if ((textBox4.Text == string.Empty) || (textBox6.Text != ""))
            {
                MessageBox.Show("Employe name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  employe set emp_name = @emp_name,emp_dob=@emp_dob,emp_gender=@emp_gender,emp_mobile=@emp_mobile,emp_address=@emp_address,emp_salary=@emp_salary where emp_id=@emp_id ", con);
            cmd.Parameters.AddWithValue("@emp_id", textBox6.Text);
            cmd.Parameters.AddWithValue("@emp_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@emp_dob", this.dateTimePicker3.Text);
            cmd.Parameters.AddWithValue("@emp_gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@emp_mobile", textBox2.Text);
            cmd.Parameters.AddWithValue("@emp_address", textBox7.Text);
            cmd.Parameters.AddWithValue("@emp_salary", textBox8.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            view2();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            view2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox3.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }
    }
 }

 

