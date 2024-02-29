using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace Inventory_Management
{
    class Retrieve
    {
        public void showStaff(DataGridView gv, DataGridViewColumn staffidGV, DataGridViewColumn fnameGV, DataGridViewColumn lnameGV, DataGridViewColumn unameGV, DataGridViewColumn passGV, DataGridViewColumn conctGV, DataGridViewColumn addrsGV, DataGridViewColumn typeidGV, DataGridViewColumn roleidGV, DataGridViewColumn locidGV, DataGridViewColumn secidGV, DataGridViewColumn manidGV, DataGridViewColumn statGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data==null)
                {
                    cmd = new SqlCommand("st_getstaffdata", MainClass.DBConn);
                }
                else
                {
                    cmd = new SqlCommand("st_searchstaffdata", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                staffidGV.DataPropertyName = dt.Columns["sid"].ToString();
                fnameGV.DataPropertyName = dt.Columns["fname"].ToString();
                lnameGV.DataPropertyName = dt.Columns["lname"].ToString();
                unameGV.DataPropertyName = dt.Columns["uname"].ToString();
                passGV.DataPropertyName = dt.Columns["pwd"].ToString();
                conctGV.DataPropertyName = dt.Columns["contact"].ToString();
                addrsGV.DataPropertyName = dt.Columns["addrs"].ToString();
                typeidGV.DataPropertyName = dt.Columns["typeid"].ToString();
                roleidGV.DataPropertyName = dt.Columns["roleid"].ToString();
                locidGV.DataPropertyName = dt.Columns["locid"].ToString();
                secidGV.DataPropertyName = dt.Columns["secid"].ToString();
                manidGV.DataPropertyName = dt.Columns["manid"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void showCategory(DataGridView gv, DataGridViewColumn catIdGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getcatgData", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                catIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message,"Message","Error");
            }
        }

        public void populateComboBoxList(string proc, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //DataRow dr = dt.NewRow();
                //dr.ItemArray = new object[] { 0, "Select ..." };
                //dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Initialize Error", "Error");
            }
        }
        public void populateListBox(string proc, ListBox lvb, string DisplayMember, string ValueMember)
        {
            try
            {
                lvb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //DataRow dr = dt.NewRow();
                //dr.ItemArray = new object[] { 0, "Select ..." };
                //dt.Rows.InsertAt(dr, 0);
                lvb.DisplayMember = DisplayMember;
                lvb.ValueMember = ValueMember;
                lvb.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Initialize Error", "Error");
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn ProIdGV, DataGridViewColumn ProCodeGV, DataGridViewColumn ProBCodeGV, DataGridViewColumn NameGV, DataGridViewColumn unitGV, DataGridViewColumn priceGV, DataGridViewColumn qunitGV, DataGridViewColumn quantyGV, DataGridViewColumn statGV, DataGridViewColumn catgGV, DataGridViewColumn minlvlGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductData", MainClass.DBConn);
                }
                else
                {
                    cmd = new SqlCommand("st_searchProduct", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                ProIdGV.DataPropertyName = dt.Columns["pid"].ToString();
                ProCodeGV.DataPropertyName = dt.Columns["code"].ToString();
                ProBCodeGV.DataPropertyName = dt.Columns["barcode"].ToString();
                NameGV.DataPropertyName = dt.Columns["pname"].ToString();
                unitGV.DataPropertyName = dt.Columns["punit"].ToString();
                priceGV.DataPropertyName = dt.Columns["pprice"].ToString();
                qunitGV.DataPropertyName = dt.Columns["p_q_unt"].ToString();
                quantyGV.DataPropertyName = dt.Columns["p_qty"].ToString();
                statGV.DataPropertyName = dt.Columns["status"].ToString();
                catgGV.DataPropertyName = dt.Columns["pcatg"].ToString();
                minlvlGV.DataPropertyName = dt.Columns["pminlvl"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void showStock(DataGridView gv, DataGridViewColumn ProIdGV, DataGridViewColumn ProCodeGV, DataGridViewColumn ProBCodeGV, DataGridViewColumn NameGV, DataGridViewColumn unitGV, DataGridViewColumn priceGV, DataGridViewColumn qunitGV, DataGridViewColumn quantyGV, DataGridViewColumn statGV, DataGridViewColumn catgGV, DataGridViewColumn minlvlGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getStockData", MainClass.DBConn);
                }
                else
                {
                    cmd = new SqlCommand("st_getStockBySearch", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                ProIdGV.DataPropertyName = dt.Columns["pid"].ToString();
                ProCodeGV.DataPropertyName = dt.Columns["code"].ToString();
                ProBCodeGV.DataPropertyName = dt.Columns["barcode"].ToString();
                NameGV.DataPropertyName = dt.Columns["pname"].ToString();
                unitGV.DataPropertyName = dt.Columns["punit"].ToString();
                priceGV.DataPropertyName = dt.Columns["pprice"].ToString();
                qunitGV.DataPropertyName = dt.Columns["p_q_unt"].ToString();
                quantyGV.DataPropertyName = dt.Columns["p_qty"].ToString();
                statGV.DataPropertyName = dt.Columns["status"].ToString();
                catgGV.DataPropertyName = dt.Columns["pcatg"].ToString();
                minlvlGV.DataPropertyName = dt.Columns["pminlvl"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void showRoles(DataGridView gv, DataGridViewColumn roleIdGV, DataGridViewColumn NameGV, DataGridViewColumn descGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getRolesData", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                roleIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["RoleName"].ToString();
                descGV.DataPropertyName = dt.Columns["RoleDesc"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }

        public void showTypes(DataGridView gv, DataGridViewColumn typeIdGV, DataGridViewColumn descGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getTypeData", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                typeIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                descGV.DataPropertyName = dt.Columns["TypeDesc"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }

        public void showSections(DataGridView gv, DataGridViewColumn typeIdGV, DataGridViewColumn descGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSectionData", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                typeIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                descGV.DataPropertyName = dt.Columns["SecDesc"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }
        public void showLocations(DataGridView gv, DataGridViewColumn LocIdGV, DataGridViewColumn cityGV, DataGridViewColumn provinceGV, DataGridViewColumn streetGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getLocationData", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                LocIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                cityGV.DataPropertyName = dt.Columns["City"].ToString();
                provinceGV.DataPropertyName = dt.Columns["Province"].ToString();
                streetGV.DataPropertyName = dt.Columns["Street"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }
        public void showInvRoles(DataGridView gv, DataGridViewColumn idGV, DataGridViewColumn userGV, DataGridViewColumn suplGV, DataGridViewColumn locidGV, DataGridViewColumn codeGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getInvRoleData", MainClass.DBConn);
                }
                else
                {
                    cmd = new SqlCommand("st_searchInvRoles", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                idGV.DataPropertyName = dt.Columns["ID"].ToString();
                userGV.DataPropertyName = dt.Columns["usrid"].ToString();
                suplGV.DataPropertyName = dt.Columns["name"].ToString();
                locidGV.DataPropertyName = dt.Columns["locid"].ToString();
                codeGV.DataPropertyName = dt.Columns["nmcode"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }

        public void showSupplier(DataGridView gv, DataGridViewColumn suplidGV, DataGridViewColumn nameGV, DataGridViewColumn compnameGV, DataGridViewColumn locidGV, DataGridViewColumn conctGV, DataGridViewColumn ntnnoGV, DataGridViewColumn nmcodeGV, DataGridViewColumn statGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSupplierData", MainClass.DBConn);
                }
                else
                {
                    cmd = new SqlCommand("st_searchSupplierData", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                suplidGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                compnameGV.DataPropertyName = dt.Columns["Company"].ToString();
                locidGV.DataPropertyName = dt.Columns["Location"].ToString();
                conctGV.DataPropertyName = dt.Columns["contact"].ToString();
                ntnnoGV.DataPropertyName = dt.Columns["ntn"].ToString();
                nmcodeGV.DataPropertyName = dt.Columns["shcode"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        private int prodStock = 0;
        public int getProductQuantity(string prodCd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getStockQuantity", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@prodid", prodCd);
                MainClass.DBConn.Open();
                prodStock = Convert.ToInt32(cmd.ExecuteScalar());
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
                throw;
            }
            return prodStock;
        }
        public void showSaleInvoiceByDate(DataGridView gv, DataGridViewColumn saleidGV, DataGridViewColumn dateGV, DataGridViewColumn fromGV, DataGridViewColumn toGV, DataGridViewColumn userGV, DataGridViewColumn statGV, DataGridViewColumn isubyGV, DateTime frmdate, DateTime todate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_searchSaleInvoiceByDate", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@frmdate", frmdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                saleidGV.DataPropertyName = dt.Columns["indent no"].ToString();
                dateGV.DataPropertyName = dt.Columns["date"].ToString();
                fromGV.DataPropertyName = dt.Columns["indent from"].ToString();
                toGV.DataPropertyName = dt.Columns["indent to"].ToString();
                userGV.DataPropertyName = dt.Columns["user"].ToString();
                statGV.DataPropertyName = dt.Columns["status"].ToString();
                isubyGV.DataPropertyName = dt.Columns["final by"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void showSaleInvoiceWithDetail(DataGridView gv, DataGridViewColumn saleidGV, DataGridViewColumn dateGV, DataGridViewColumn codeGV, DataGridViewColumn nameGV, DataGridViewColumn packGV, DataGridViewColumn qpackGV, DataGridViewColumn qtyGV, DataGridViewColumn catgGV, Int64 saleid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSaleInvoiceWithDetail", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@saleid", saleid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        MainClass.DBConn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                gblInvoiceNo = dr.GetInt64(0);
                                gblDate = dr.GetDateTime(1);
                                gblFrom = dr.GetString(2);
                                gblTo = dr.GetString(3);
                                gblStatus = dr.GetString(5);
                                MainClass.gblIndentStatus = dr.GetString(5);
                            }
                        }
                        dr.Close();
                        MainClass.DBConn.Close();
                        saleidGV.DataPropertyName = dt.Columns["saleid"].ToString();
                        dateGV.DataPropertyName = dt.Columns["date"].ToString();
                        codeGV.DataPropertyName = dt.Columns["sdcode"].ToString();
                        nameGV.DataPropertyName = dt.Columns["name"].ToString();
                        packGV.DataPropertyName = dt.Columns["packing"].ToString();
                        qpackGV.DataPropertyName = dt.Columns["punit"].ToString();
                        qtyGV.DataPropertyName = dt.Columns["qty"].ToString();
                        catgGV.DataPropertyName = dt.Columns["catg"].ToString();
                        // bound gridview data source
                        gv.DataSource = dt;
                    }
                    else
                    {
                        MainClass.showMSG("No Record is found, plz check indent.", "Find..!", "Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void showPurchaseInvDetails( DataGridView gv, Int64 pid, DataGridViewColumn pidGV, DataGridViewColumn codeGV, DataGridViewColumn NameGV, DataGridViewColumn packGV, DataGridViewColumn qpackGV, DataGridViewColumn qtyGV, DataGridViewColumn catgGV, DataGridViewColumn statGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@pid",pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                pidGV.DataPropertyName = dt.Columns["pid"].ToString();
                codeGV.DataPropertyName = dt.Columns["picode"].ToString();
                NameGV.DataPropertyName = dt.Columns["name"].ToString();
                packGV.DataPropertyName = dt.Columns["packing"].ToString();
                qpackGV.DataPropertyName = dt.Columns["perpack"].ToString();
                qtyGV.DataPropertyName = dt.Columns["qty"].ToString();
                catgGV.DataPropertyName = dt.Columns["catg"].ToString();
                statGV.DataPropertyName = dt.Columns["status"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void getPurchaseInvList(string proc, ComboBox cb, string DisplayMember, string ValueMember, object mnth, object year)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@month", mnth);
                cmd.Parameters.AddWithValue("@year", year);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //DataRow dr = dt.NewRow();
                //dr.ItemArray = new object[] { 0, "Select ..." };
                //dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
                cb.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Initialize Error", "Error");
            }
        }
        public static Int64 gblInvoiceNo { get; private set; }
        public static string gblFrom { get; private set; }
        public static string gblTo { get; private set; }
        public static DateTime gblDate { get; private set; }
        public static string gblStatus { get; private set; }
        public static int staff_id { get; private set; }
        public static string staff_name { get; private set; }
        public static int staff_type_id { get; private set; }
        public static int staff_section_id { get; private set; }
        public static int staff_role_id { get; private set; }
        public static int staff_loc_id { get; private set; }
        public static int staff_mang_id { get; private set; }
        public static string staff_status { get; private set; }
        private string[] productInfo = new string[11];
        public string[] getProductByCode(string prodCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByCode", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prod_code",prodCode);
                cmd.CommandTimeout = 0;
                MainClass.DBConn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productInfo[0] = dr[0].ToString();  // id
                        productInfo[1] = dr[1].ToString();  // code
                        productInfo[2] = dr[2].ToString();  // barcode
                        productInfo[3] = dr[3].ToString();  // name
                        productInfo[4] = dr[4].ToString();  // unit
                        productInfo[5] = dr[5].ToString();  // price
                        productInfo[6] = dr[6].ToString();  // per unit
                        productInfo[7] = dr[7].ToString();  // qty
                        productInfo[8] = dr[8].ToString();  // status
                        productInfo[9] = dr[9].ToString();  // category
                        productInfo[10] = dr[10].ToString();// min lvl
                    }
                }
                MainClass.DBConn.Close();
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error", "Error");
            }
            return productInfo;
        }

        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static bool getUserDetail(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                MainClass.DBConn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        staff_id = Convert.ToInt32(dr["ID"].ToString());
                        staff_type_id = Convert.ToInt32(dr["typid"].ToString());
                        staff_section_id = Convert.ToInt32(dr["secid"].ToString());
                        staff_role_id = Convert.ToInt32(dr["rolid"].ToString());
                        staff_loc_id = Convert.ToInt32(dr["locid"].ToString());
                        staff_mang_id = Convert.ToInt32(dr["mangid"].ToString());
                        staff_name = dr["Name"].ToString() + " " + dr["LName"].ToString();
                        user_name = dr["username"].ToString();
                        pass_word = dr["password"].ToString();
                        staff_status = dr["password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password )
                        {
                            MainClass.showMSG("Invalid username ...", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid userid ...", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid userid and username ...", "Error", "Error");
                        }
                    }
                }
                MainClass.DBConn.Close();
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG("Unable to login, check credentials ...\n"+"Or "+Ex.Message, "Error", "Error");
            }
            return checkLogin;
        }
        ReportDocument rd;

        public void showReport(CrystalReportViewer crv, string proc, string param1, object val1, string filename)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue(param1,val1);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                rd.Load(Application.StartupPath + "\\" + filename);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showConsumptionDetail(DataGridView gv, DataGridViewColumn dateGV, DataGridViewColumn codeGV, DataGridViewColumn nameGV, DataGridViewColumn packGV,DataGridViewColumn opnbalGV, DataGridViewColumn consumpGV,DataGridViewColumn clobalGV, object data, int choice)
        {
            try
            {
                SqlCommand cmd;
                if (choice == 1)
                {
                    cmd = new SqlCommand("st_getConsumptionData", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@cddate", data);
                }
                else
                {
                    cmd = new SqlCommand("st_searchConsumptionData", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                dateGV.DataPropertyName = dt.Columns["upddate"].ToString();
                codeGV.DataPropertyName = dt.Columns["code"].ToString();
                nameGV.DataPropertyName = dt.Columns["name"].ToString();
                packGV.DataPropertyName = dt.Columns["pack"].ToString();
                opnbalGV.DataPropertyName = dt.Columns["opnbalance"].ToString();
                consumpGV.DataPropertyName = dt.Columns["consumption"].ToString();
                clobalGV.DataPropertyName = dt.Columns["clobalance"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void showConsumptionDates(DataGridView gv, DataGridViewColumn cdateGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getConsumptionDates", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound the gridview columns
                cdateGV.DataPropertyName = dt.Columns["scdate"].ToString();
                // bound gridview data source
                gv.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Message", "Error");
            }
        }
        public void showConsumptionStock(string prodCode, int secId, TextBox textDesc, TextBox textPack, TextBox textStock, DateTime sumdate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getConsumptionStock", MainClass.DBConn);
                cmd.Parameters.AddWithValue("@icode", prodCode);
                cmd.Parameters.AddWithValue("@sumdate", sumdate);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // fetch values from datatable to textboxes
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        textDesc.Text = dt.Rows[0]["desc"].ToString();
                        textPack.Text = dt.Rows[0]["qunit"].ToString();
                        textStock.Text = (Convert.ToInt32(dt.Rows[0]["totalbal"].ToString()) * Convert.ToInt32(dt.Rows[0]["qunit"].ToString())).ToString();
                    }
                    else
                    {
                        MainClass.showMSG("Invalid item code, Try again.", "Information", "Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void showPurchaseInvoiceByDate(DataGridView gv, DateTime frmdate, DateTime todate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_searchPurchaseInvoiceByDate", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@frmdate", frmdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound gridview data source
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gv.DataSource = dt;
                        gv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        gv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        gv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        MainClass.showMSG("There is no data to display.", "Information", "Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void showSaleInvoiceByDate(DataGridView gv, DateTime frmdate, DateTime todate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_searchSaleInvoiceByDate", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@frmdate", frmdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound gridview data source
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        gv.DataSource = dt;
                    }
                    else
                    {
                        MainClass.showMSG("There is no data to display.","Information","Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        
        public void showReport(CrystalReportViewer crv, string fileName, string proc, int choice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                if (choice == 1) { cmd.CommandType = CommandType.StoredProcedure; }
                if (choice == 2) { cmd.CommandType = CommandType.Text; }
                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                rd.Load(Application.StartupPath + "\\" + fileName);
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showReport(CrystalReportViewer crv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCashSheetDates", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@var_date", MainClass.gblFromDate.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                rd.Load(Application.StartupPath + "\\crCashSheet.rpt");
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showReport(CrystalReportViewer crv, string proc, DateTime frmDate, DateTime toDate, int option)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@fromdate", frmDate.ToShortDateString());
                cmd.Parameters.AddWithValue("@todate", toDate.ToShortDateString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd = new ReportDocument();
                rd.Load(Application.StartupPath + "\\crStockBalanceSummary.rpt");
                rd.SetDataSource(dt);
                //for (int i = 0; i < rd.DataDefinition.FormulaFields.Count; i++)
                //    if (rd.DataDefinition.FormulaFields[i].FormulaName == "{@toDate}")
                //        rd.DataDefinition.FormulaFields[i].Text = "\"" + toDate.ToShortDateString() + "\"";
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldLocation;
                ParameterValues crParameterValues = new ParameterValues();
                crParameterFieldDefinitions = rd.DataDefinition.ParameterFields;
                // 1stParameter Satrt
                crParameterFieldLocation = crParameterFieldDefinitions["@toDate"];
                crParameterValues = crParameterFieldLocation.CurrentValues;
                crParameterDiscreteValue = new ParameterDiscreteValue();
                crParameterDiscreteValue.Value = toDate.ToShortDateString().ToString();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldLocation.ApplyCurrentValues(crParameterValues);
                //1st Parameter End
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void showInvJournalByDate(DataGridView gv, DataGridViewColumn idGV, DataGridViewColumn dateGV, DataGridViewColumn indentGV, DataGridViewColumn codeGV, DataGridViewColumn nameGV, DataGridViewColumn descGV, DataGridViewColumn opnbalGV, DataGridViewColumn recvGV,DataGridViewColumn issueGV, DataGridViewColumn clobalGV, DateTime frmdate, DateTime todate, string itemcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_showInventoryJournal", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@fromdate", frmdate);
                cmd.Parameters.AddWithValue("@todate", todate);
                cmd.Parameters.AddWithValue("@itemcode",itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // bound gridview data source
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        // bound the gridview columns
                        idGV.DataPropertyName = dt.Columns["id"].ToString();
                        dateGV.DataPropertyName = dt.Columns["date"].ToString();
                        indentGV.DataPropertyName = dt.Columns["indent"].ToString();
                        codeGV.DataPropertyName = dt.Columns["code"].ToString();
                        nameGV.DataPropertyName = dt.Columns["name"].ToString();
                        descGV.DataPropertyName = dt.Columns["desc"].ToString();
                        opnbalGV.DataPropertyName = dt.Columns["opnbal"].ToString();
                        recvGV.DataPropertyName = dt.Columns["recieve"].ToString();
                        issueGV.DataPropertyName = dt.Columns["issue"].ToString();
                        clobalGV.DataPropertyName = dt.Columns["clobal"].ToString();
                        gv.DataSource = dt;
                    }
                    else
                    {
                        MainClass.showMSG("There is no data to display.", "Information", "Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
    }
}
