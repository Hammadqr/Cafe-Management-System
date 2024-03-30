using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    internal class func
    {
        protected SqlConnection get_connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MDQEFUV\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
            return conn;
        }

        public DataSet  get_data(string query)
        {
            SqlConnection conn = get_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;  
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void set_data(string query)
        {
            SqlConnection conn = get_connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data is saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
