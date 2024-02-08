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


namespace login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sqlselect = "select * from student where student_id = '" + textSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewSearch.DataSource = dt;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                SqlCommand cmd = new SqlCommand("insert into student values (@student_id,@name,@student_grade,@student_dob,@student_gender,@student_mobile,@address,@subject_id)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@student_grade", txtGrade.Text);
                cmd.Parameters.AddWithValue("@student_dob", this.dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@student_gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@student_mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@subject_id", txtSid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New student is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private bool Isvalid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Student name is required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtName.Text == string.Empty)
            {
                SqlCommand cmd = new SqlCommand("update student set  (@Student_id , @name , @student_grade , @student_dob , @student_gender , @student_mobile , @address , @subject_id)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@student_grade", txtGrade.Text);
                cmd.Parameters.AddWithValue("@student_dob", this.dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@student_gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@student_mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@subject_id", txtSid.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student information is successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an student to update his information", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update student set name = '" + txtName.Text + "', student_grade = '" + txtGrade.Text + "', student_dob = '" + this.dateTimePicker1.Text + "', student_gender = '" + txtGender.Text + "',student_mobile = '" + txtMobile.Text + "', address = '" + txtAddress.Text + "', student_id = '" + txtSid.Text + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully updated.");
            

        }
    }
}
