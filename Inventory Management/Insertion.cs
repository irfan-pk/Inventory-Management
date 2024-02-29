using System;
using System.Data.SqlClient;
using System.Data;

namespace Inventory_Management
{
    class Insertion
    {
        Int64 purchaseID, saleID;
        public void insertStaff(string fname, string lname, string usr, string pwd, string addrs, string conct, int typeid, int roleid,  int locid, int secid, int manid, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertstaff", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@fname",fname);
                cmd.Parameters.AddWithValue("@lname",lname);
                cmd.Parameters.AddWithValue("@uname",usr);
                cmd.Parameters.AddWithValue("@pwd",pwd);
                cmd.Parameters.AddWithValue("@address",addrs);
                cmd.Parameters.AddWithValue("@contact",conct);
                cmd.Parameters.AddWithValue("@roleid",roleid);
                cmd.Parameters.AddWithValue("@typeid",typeid);
                cmd.Parameters.AddWithValue("@locid", locid);
                cmd.Parameters.AddWithValue("@secid", secid);
                cmd.Parameters.AddWithValue("@manager_id", manid);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(fname+" "+lname+" added to the system successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message,"Error..!","Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@IsActive", status);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " added to the category successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertProduct(string code, string barcode, string name, string unit, float price, int qtypunit, decimal qty, Int16 status, int catg, int minlvl)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProduct", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@pro_code", code);
                cmd.Parameters.AddWithValue("@pro_bcode", barcode);
                cmd.Parameters.AddWithValue("@pro_name", name);
                cmd.Parameters.AddWithValue("@pro_unit", unit);
                cmd.Parameters.AddWithValue("@pro_price", price);
                cmd.Parameters.AddWithValue("@pro_q_unt", qtypunit);
                cmd.Parameters.AddWithValue("@pro_qty", qty);
                cmd.Parameters.AddWithValue("@pro_status", status);
                cmd.Parameters.AddWithValue("@pro_catg", catg);
                cmd.Parameters.AddWithValue("@pro_min_lvl", minlvl);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " added to the products successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertRoles(string name, string desc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertRoles", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@rolename", name);
                cmd.Parameters.AddWithValue("@roledesc", desc);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " added to the roles successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertTypes(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertType", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@type", name);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " added to the types successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertLocation(string city, string province, string street)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertLocation", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@loc_city", city);
                cmd.Parameters.AddWithValue("@loc_province", province);
                cmd.Parameters.AddWithValue("@loc_street", street);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(city + " added to the locations successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertInvoiceRoles(int userid, string suplname, int locid, int prefixid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertInvRoles", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@usrid", userid);
                cmd.Parameters.AddWithValue("@suplname", suplname);
                cmd.Parameters.AddWithValue("@locid", locid);
                cmd.Parameters.AddWithValue("@prefix", prefixid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Added to the invoice-roles successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertSupplier(string name, string company, int location, string contact, string ntn, string nmcode, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@supl_name", name);
                cmd.Parameters.AddWithValue("@supl_company", company);
                cmd.Parameters.AddWithValue("@supl_locId", location);
                cmd.Parameters.AddWithValue("@supl_contact", contact);
                cmd.Parameters.AddWithValue("@supl_ntn", ntn);
                cmd.Parameters.AddWithValue("@supl_nm_code", nmcode);
                cmd.Parameters.AddWithValue("@supl_status", status);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(company + " added to the supplier successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public Int64 insertPurchaseInvoice(Int64 piid, string supl, DateTime date, string user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@pi_id", piid);
                cmd.Parameters.AddWithValue("@pi_supl", supl);
                cmd.Parameters.AddWithValue("@pi_date", date);
                cmd.Parameters.AddWithValue("@pi_user", user);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "st_getLastPurchaseID";
                cmd.Parameters.Clear();
                purchaseID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.DBConn.Close();
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
            return purchaseID;
        }

        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purchid, string code, string prodName, string pack, string perPack, int qty, string catg, DateTime pDate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetail", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid_pi",purchid);
                cmd.Parameters.AddWithValue("@pid_code",code);
                cmd.Parameters.AddWithValue("@pid_name",prodName);
                cmd.Parameters.AddWithValue("@pid_packing",pack);
                cmd.Parameters.AddWithValue("@pid_qunit",perPack);
                cmd.Parameters.AddWithValue("@pid_qty", qty);
                cmd.Parameters.AddWithValue("@pid_catg",catg);
                cmd.Parameters.AddWithValue("@pid_status", "INVOICE");
                cmd.Parameters.AddWithValue("@pid_date", pDate);
                MainClass.DBConn.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
            }
            return pidCount;
        }

        public void insertStock(string code, int qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@proId", code);
                cmd.Parameters.AddWithValue("@quant", qty);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
            }
        }

        public void insertDeleteItem(Int64 pid, int usrid, int prodid, int qty, DateTime deldate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertdeletedItemPI", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@usrid", usrid);
                cmd.Parameters.AddWithValue("@proId", prodid);
                cmd.Parameters.AddWithValue("@quant", qty);
                cmd.Parameters.AddWithValue("@deldt", deldate);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
            }
        }

        public void insertSection(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSection", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@section", name);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " added to the types successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }

        public void insertSaleInvoice(Int64 piid, DateTime sdate, string reqFrom, string reqTo, string user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSaleMaster", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@id", piid);
                cmd.Parameters.AddWithValue("@sdate", sdate);
                cmd.Parameters.AddWithValue("@reqfrom", reqFrom);
                cmd.Parameters.AddWithValue("@reqTo", reqTo);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@status", "INDENTED");
                cmd.Parameters.AddWithValue("@issueperson", "X");
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "st_getLastSaleID";
                //cmd.Parameters.Clear();
                //saleID = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.DBConn.Close();
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
            //return saleID;
        }

        public void insertSaleDetails(Int64 purchid, string code, string prodName, string pack, int perPack, decimal qty, string catg, DateTime sddate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSaleDetail", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sd_id", purchid);
                cmd.Parameters.AddWithValue("@sd_code", code);
                cmd.Parameters.AddWithValue("@sd_name", prodName);
                cmd.Parameters.AddWithValue("@sd_packing", pack);
                cmd.Parameters.AddWithValue("@sd_qunit", perPack);
                cmd.Parameters.AddWithValue("@sd_qty", qty);
                cmd.Parameters.AddWithValue("@sd_catg", catg);
                cmd.Parameters.AddWithValue("@sd_date", sddate);
                cmd.Parameters.AddWithValue("@sd_status", "INDENTED");
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
            }
        }

        public void insertConsumptionDetail(string code, string prodName, string pack, decimal opnbal, decimal consump, decimal clobal, DateTime sddate, int usrsec)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertConsumption", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@item_code", code);
                cmd.Parameters.AddWithValue("@item_desc", prodName);
                cmd.Parameters.AddWithValue("@item_pckg", pack);
                cmd.Parameters.AddWithValue("@item_opn_bal", opnbal);
                cmd.Parameters.AddWithValue("@item_consumption", consump);
                cmd.Parameters.AddWithValue("@item_balance", clobal);
                cmd.Parameters.AddWithValue("@item_upd_date", sddate);
                cmd.Parameters.AddWithValue("@item_section", usrsec);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
            }
            catch (Exception)
            {
                MainClass.DBConn.Close();
            }
        }

        public void processOrders(string param1, string param2 = null)
        {
            try
            {
                SqlCommand cmd;
                if (param2 == null)
                {
                    cmd = new SqlCommand("st_receivePurchaseOrder", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@purch_id", Convert.ToInt64(param1));
                }
                else
                {
                    cmd = new SqlCommand("st_issueIndentOrder", MainClass.DBConn);
                    cmd.Parameters.AddWithValue("@invoice_id", Convert.ToInt64(param1));
                    cmd.Parameters.AddWithValue("@issue_by", param2);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                MainClass.DBConn.Open();
                int k = cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Indent processed successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
                MainClass.DBConn.Close();
            }   
        }
    }
}
