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

namespace DB_Project
{
    public partial class InventoryAddRem : Form
    {

        func fn = new func();
        string query;

        private SqlConnection connection;
        private SqlCommand command;
        public InventoryAddRem()
        {
            InitializeComponent();
        }

        private void InventoryAddRem_Load(object sender, EventArgs e)
        {

        }
    }
}
