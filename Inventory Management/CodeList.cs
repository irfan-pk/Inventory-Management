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

namespace Inventory_Management
{
    public partial class CodeList : Form
    {
        public CodeList()
        {
            InitializeComponent();
        }
        private void CodeList_Load(object sender, EventArgs e)
        {
            dgvCodeHelp.AutoGenerateColumns = false;
            SqlCommand cmd = new SqlCommand("select product_code, product_name from products order by product_code", MainClass.DBConn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            MainClass.DBConn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            codeGV.DataPropertyName = dt.Columns["product_code"].ToString();
            descGV.DataPropertyName = dt.Columns["product_name"].ToString();
            dgvCodeHelp.DataSource = dt;
            MainClass.DBConn.Close();
        }

        private void dgvCodeHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dgvCodeHelp.CurrentRow;
                MainClass.gblprodCode = dgr.Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
