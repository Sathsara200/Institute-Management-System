using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace login
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }















        private bool Isvalid()
        {
            if ((txtName.Text == string.Empty) || (txtId.Text != ""))
            {
                MessageBox.Show("Teacher name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;


        }



        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (Isvalid())
            {

                SqlCommand cmd = new SqlCommand("insert into teacher values (@name,@teacher_dob,@teacher_gender,@teacher_mobile,@address)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@teacher_dob", this.dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@teacher_gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@teacher_mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("New teacher is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  teacher set name = @name,teacher_dob=@teacher_dob,teacher_gender=@teacher_gender,teacher_mobile=@teacher_mobile,address=@address where teacher_id=@teacher_id ", con);
            cmd.Parameters.AddWithValue("@teacher_id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@teacher_dob", this.dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@teacher_gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@teacher_mobile", txtMobile.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete teacher where teacher_id=@teacher_id", con);
            cmd.Parameters.AddWithValue("@teacher_id", int.Parse(txtId.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            display();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);








        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = "select * from teacher where teacher_id = '" + txtSearch.Text + "'";
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
        void display()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from teacher", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void All_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtId.Text = "";
            txtGender.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }
    }
}


    

