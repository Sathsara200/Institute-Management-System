namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Admin" && textPassword.Text == "Admin123")
            {
                MessageBox.Show("Welcome Admin");
                Form2 frm1 = new Form2();
                frm1.Show();
                this.Hide();

            }
            else if (textUsername.Text == "Teacher" && textPassword.Text == "Teacher123")
            {
                MessageBox.Show("Welcome Teacher");
                Form3 frm2 = new Form3();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Error");
                textUsername.Text = "";
                textPassword.Clear();
                textUsername.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dresult = MessageBox.Show("Do you want to exit", "EXIT",
         MessageBoxButtons.YesNo);
            if (dresult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }

        }

        private void textUsername_Enter(object sender, EventArgs e)
        {
            if (textUsername.Text == "User name")
            {
                textUsername.Text = "";
                textUsername.ForeColor = Color.Black;
            }
        }

        private void textUsername_Leave(object sender, EventArgs e)
        {
            if (textUsername.Text == "")
            {
                textUsername.Text = "User name";
                textUsername.ForeColor = Color.Silver;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;

            }

        }
        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.Silver;
            }

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
