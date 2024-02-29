using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class ReportsMenu : SampleExt
    {
        public ReportsMenu()
        {
            InitializeComponent();
        }

        private void ReportsMenu_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            tableLayoutPanel1.Visible = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportViewer rv = new ReportViewer();
            if(rbStockPosition.Checked==true) 
            {
                MainClass.rptChoice = 2;
                rv.Show(); 
            }
            if(rbBalSummary .Checked==true)
            {
                if(dtpFrom.Enabled == true && dtpTo.Enabled == true)
                {
                    MainClass.gblFromDate = dtpFrom.Value;
                    MainClass.gblToDate = dtpTo.Value;
                    MainClass.rptChoice = 3;
                    rv.Show();
                }
            }
            if (rbBalDetail.Checked == true)
            {
                if (dtpFrom.Enabled == true && dtpTo.Enabled == true)
                {
                    try
                    {
                        //string delQuery = "delete from stock_detail_report";
                        //SqlCommand delCmd = new SqlCommand(delQuery, MainClass.DBConn);
                        //delCmd.CommandType = CommandType.Text;
                        //delCmd.CommandTimeout = 0;
                        //MainClass.DBConn.Open();
                        //delCmd.ExecuteNonQuery();
                        //MainClass.DBConn.Close();

                        SqlCommand cmd = new SqlCommand("st_stockpositiondetailreport", MainClass.DBConn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.AddWithValue("@fromdate", dtpFrom.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@todate", dtpTo.Value.ToShortDateString());
                        MainClass.DBConn.Open();
                        cmd.ExecuteNonQuery();
                        MainClass.DBConn.Close();
                        string issueDetail = "select [sale_desc], [sale_detail_date], sum([sale_qty]) As issue from sale_details " +
                                             "where sale_detail_date BETWEEN '" + dtpFrom.Value.ToShortDateString() + "' and '" + dtpTo.Value.ToShortDateString() + "' AND (sale_detail_status = 'issued') group by sale_detail_date, sale_desc";
                        SqlCommand issueCmd = new SqlCommand(issueDetail, MainClass.DBConn);
                        issueCmd.CommandType = CommandType.Text;
                        issueCmd.CommandTimeout = 0;
                        MainClass.DBConn.Open();
                        SqlDataReader dr = issueCmd.ExecuteReader();
                        if(dr.HasRows==true)
                        {
                            while(dr.Read())
                            {
                                DateTime now = Convert.ToDateTime(dr["sale_detail_date"].ToString());
                                int day = now.Day;
                                SqlCommand updCmd = new SqlCommand("update stock_detail_report set d" + day + "= " + Convert.ToInt32(dr["issue"].ToString()) + " where item_desc = N'" + dr["sale_desc"].ToString() + "'", MainClass.DBConn);
                                updCmd.CommandType = CommandType.Text;
                                updCmd.CommandTimeout = 0;
                                updCmd.ExecuteNonQuery();
                            }
                        }
                    MainClass.DBConn.Close();
                    dr.Close();
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MainClass.gblFromDate = dtpFrom.Value;
                MainClass.gblToDate = dtpTo.Value;
                MainClass.rptChoice = 4;
                rv.Show();
                }
            }
            if (rbCashSheet.Checked == true)
            {
                if (dtpFrom.Enabled == true)
                {
                    MainClass.gblFromDate = dtpFrom.Value;
                    MainClass.rptChoice = 5;
                    rv.Show();
                }
            }
        }
        private void rbBalDetail_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void rbBalSummary_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void rbStockPosition_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void rbCashSheet_Click(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
        }
    }
}
