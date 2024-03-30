using System;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DB_Project;

namespace DB_Project
{
    public partial class regitration : Form
    {
        public regitration()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True");
        SqlCommand cmd;  
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regitration_Load(object sender, EventArgs e)
        {

        }


        // Buttons start form this section
        private void registration_registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(registration_textBox_username.Text) ||
                    string.IsNullOrEmpty(registration_textBox_password.Text) ||
                    string.IsNullOrEmpty(registration_textBox_confirmPass.Text))
                {
                    MessageBox.Show("Input fields are empty. Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (registration_textBox_password.Text != registration_textBox_confirmPass.Text)
                {
                    MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    registration_textBox_password.Text = "";
                    registration_textBox_confirmPass.Text = "";
                    registration_textBox_password.Focus();
                    return;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True"))
                {
                    conn.Open();
                    cmd = new SqlCommand("Insert into record values('"+registration_textBox_username.Text+"'" +
                        ",'"+registration_textBox_password+"')", conn);
                    //using (SqlCommand cmd = new SqlCommand("sp_insert", conn))
                    //{
                        //cmd.CommandType = CommandType.StoredProcedure;

                        // Use SqlParameter with explicit types
                        //cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar, 255) { Value = registration_textBox_username.Text });
                        //cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 255) { Value = registration_textBox_password.Text });

                        int rowsAffected = cmd.ExecuteNonQuery();

                        registration_textBox_username.Text = "";
                        registration_textBox_password.Text = "";
                        registration_textBox_confirmPass.Text = "";

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(rowsAffected + " Data Saved");
                        }
                        else
                        {
                            MessageBox.Show("Data not saved. Check your stored procedure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void registration_tologinBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show(); 
            this.Hide();
        }

        private void registration_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (registration_showpassword.Checked)
            {
                registration_textBox_password.PasswordChar = '\0';
                registration_textBox_confirmPass.PasswordChar = '\0';
            }
            else
            {
                registration_textBox_password.PasswordChar = '*';
                registration_textBox_confirmPass.PasswordChar = '*';
            }
        }

        private void registration_textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
