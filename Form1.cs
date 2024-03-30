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
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True");



        private void label2_Click(object sender, EventArgs e)
        { }

        private void login_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_checkBox1.Checked)
            {
                login_textBox_password.PasswordChar = '\0';
            }
            else
            {
                login_textBox_password.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            new regitration().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_loginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM loginpage WHERE Username = @Username AND Password = @Password";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                conn.Open();
                //MessageBox.Show("Connection Open");
                command.Parameters.AddWithValue("@Username", login_textBox_username.Text);
                command.Parameters.AddWithValue("@Password", login_textBox_password.Text);

                int userCount = (int)command.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Login successful!");

                    // Perform actions after successful login
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                    // Clear the textboxes or handle invalid login as needed
                }
            }
        }
    }
}


