using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DB_Project
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            new regitration().Show();
            this.Hide();
        }
    }
}
