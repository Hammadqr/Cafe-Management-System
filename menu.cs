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
using System.Xml;

namespace DB_Project
{
    public partial class menu : Form
    {
        func fn = new func();
        string query;

        private SqlConnection connection;
        private SqlCommand command;
        public menu()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        }

        private void menu_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadCategories()
        {
            query = "SELECT DISTINCT category FROM items";
            DataSet ds = fn.get_data(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    menu_gunaComboBox1.Items.Add(row["category"].ToString());
                }
            }
        }

        private void menu_gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in the menu_listBox1 before adding new items
            menu_listBox1.Items.Clear();

            string ctg = menu_gunaComboBox1.Text;
            query = "SELECT itemname FROM items WHERE category ='" + ctg + "'";
            DataSet ds = fn.get_data(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                menu_listBox1.Items.Add(ds.Tables[0].Rows[i]["itemname"].ToString());
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            menu_listBox1.Items.Clear();

            string ctg = menu_gunaComboBox1.Text;
            query = "SELECT itemname FROM items WHERE category ='" + ctg + "' and itemname LIKE '"+menu_search.Text+"%'";
            DataSet ds = fn.get_data(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                menu_listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void menu_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            menu_gunaNumeric1.ResetText();
            menu_total.Clear();

            string txt = menu_listBox1.GetItemText(menu_listBox1.SelectedItem);
            menu_itemName.Text = txt;
            query = "select price from items where itemname = '" + txt + "' "  ;
            DataSet ds = fn.get_data(query);

            try
            {
                menu_price.Text = ds.Tables[0].Rows[0][0].ToString();
            }

            catch { }

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_gunaNumeric1_ValueChanged(object sender, EventArgs e)
        {
            Int64 qty = Int64.Parse(menu_gunaNumeric1.Value.ToString());
            Int64 price = Int64.Parse(menu_price.Text);
            menu_total.Text = (qty*price).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //new welcome().Show();
        }

        private void menu_gotocart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cart().Show();
        }
    }
}
