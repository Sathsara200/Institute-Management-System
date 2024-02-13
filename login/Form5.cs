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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  student set name = @name,student_grade=@student_grade,student_dob=@student_dob,student_gender=@student_gender,student_mobile=@student_mobile,address=@address where student_id=@student_id ", con);
            cmd.Parameters.AddWithValue("@student_id", textId.Text);
            cmd.Parameters.AddWithValue("@name", textName.Text);
            cmd.Parameters.AddWithValue("@student_grade", textBox1.Text);
            cmd.Parameters.AddWithValue("@student_dob", this.dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@student_gender", textGender.Text);
            cmd.Parameters.AddWithValue("@student_mobile", textMobile.Text);
            cmd.Parameters.AddWithValue("@address", textAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dplay();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = "select * from student where student_id = '" + txxtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
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

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (Ischeck())
            {

                SqlCommand cmd = new SqlCommand("insert into student values (@name,@student_grade,@student_dob,@student_gender,@student_mobile,@address,@subject_id)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@student_grade", textBox1.Text);
                cmd.Parameters.AddWithValue("@student_dob", this.dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@student_gender", textGender.Text);
                cmd.Parameters.AddWithValue("@student_mobile", textMobile.Text);
                cmd.Parameters.AddWithValue("@address", textAddress.Text);
                cmd.Parameters.AddWithValue("@subject_id", textBox2.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                dplay();
                MessageBox.Show("New teacher is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        void dplay()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView2.DataSource = dt;
        }
        private bool Ischeck()
        {
            if ((textName.Text == string.Empty) || (textId.Text != ""))
            {
                MessageBox.Show("Student name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;


        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete student where student_id=@student_id", con);
            cmd.Parameters.AddWithValue("@student_id", int.Parse(textId.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            dplay();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textGender.Text = "";
            textMobile.Text = "";
            textName.Text = "";
            txxtSearch.Text = "";
            textAddress.Text = "";
            textId.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }
    }
}

