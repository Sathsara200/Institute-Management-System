using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            try
            {
                con.Open();
                String sqlselect = "select * from teacher_attendance where id = '" + textBox1.Text + "'";
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            if (IsV())
            {

                SqlCommand cmd = new SqlCommand("insert into teacher_attendance values (@teacher_id,@status,@date,@teacher_name)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@teacher_id", txtTId.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@date", this.dateTimePicker4.Text);
                cmd.Parameters.AddWithValue("@teacher_name", txtTAName.Text);





                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                dall();
                MessageBox.Show("New teacher is successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private bool IsV()
        {
            if ((txtTAName.Text == string.Empty) || (txtTAId.Text != ""));
            {
                MessageBox.Show("Teacher name is required or id is not required", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        void dall()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from teacher_attendance", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete teacher_attendance where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtTAId.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            dall();
            MessageBox.Show("Record  successfully deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1972OJ\SQLEXPRESS;Initial Catalog=institutedb;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("update  teacher_attendance set id = @id,teacher_id=@teacher_id,status=@status,date=@date,teacher_name=@teacher_name where id=@id ", con);
            cmd.Parameters.AddWithValue("@id", txtTAId.Text);
            cmd.Parameters.AddWithValue("@teacher_id", txtTId.Text);
            cmd.Parameters.AddWithValue("@status", txtTId.Text);
            cmd.Parameters.AddWithValue("@date", this.dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@teacher_name", txtTAName.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
            dall();
            MessageBox.Show("Record successfully updated ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
