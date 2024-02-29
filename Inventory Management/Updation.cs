using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management
{
    class Updation
    {
        public void updateStaff(int sid, string fname, string lname, string usr, string pwd, string addrs, string conct, int typeid, int roleid,  int locid, int secid, int manid, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStaff", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@uname", usr);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@address", addrs);
                cmd.Parameters.AddWithValue("@contact", conct);
                cmd.Parameters.AddWithValue("@roleid", roleid);
                cmd.Parameters.AddWithValue("@typeid", typeid);
                cmd.Parameters.AddWithValue("@locid", locid);
                cmd.Parameters.AddWithValue("@secid", secid);
                cmd.Parameters.AddWithValue("@manager_id", manid);
                cmd.Parameters.AddWithValue("@sid", sid);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(fname + " " + lname + " updated in the system successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@IsActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " updated to the category successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateProduct(int prodID, string code, string barcode, string name, string unit, float price, int qtypunit, decimal qty, Int16 status, int catg, int minlvl)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.DBConn);
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
                cmd.Parameters.AddWithValue("@pid", prodID);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " update the product successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateRoles(int roleid, string name, string desc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateRoles", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@rolename", name);
                cmd.Parameters.AddWithValue("@roledesc", desc);
                cmd.Parameters.AddWithValue("@id", roleid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(name + " updated to the roles successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateTypes(int roleid, string desc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateType", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@type", desc);
                cmd.Parameters.AddWithValue("@id", roleid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(desc + " updated to the types successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateSection(int roleid, string desc)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateType", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@section", desc);
                cmd.Parameters.AddWithValue("@id", roleid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(desc + " updated to the types successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateLocations(int lid, string city, string province, string street)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateLocation", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@id", lid);
                cmd.Parameters.AddWithValue("@loc_city", city);
                cmd.Parameters.AddWithValue("@loc_province", province);
                cmd.Parameters.AddWithValue("@loc_street", street);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(city + " updated in the locations successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateInvRoles(int InvRlid, int userid, string suplname, int locid, int prefixid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateInvRoles", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@inv_id", InvRlid);
                cmd.Parameters.AddWithValue("@usrid", userid);
                cmd.Parameters.AddWithValue("@suplname", suplname);
                cmd.Parameters.AddWithValue("@locid", locid);
                cmd.Parameters.AddWithValue("@prefix", prefixid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Updated in the locations successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateSupplier(int sid, string name, string company, int location, string contact, string ntn, string nmcode, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@supl_name", name);
                cmd.Parameters.AddWithValue("@supl_company", company);
                cmd.Parameters.AddWithValue("@supl_locId", location);
                cmd.Parameters.AddWithValue("@supl_contact", contact);
                cmd.Parameters.AddWithValue("@supl_ntn", ntn);
                cmd.Parameters.AddWithValue("@supl_nm_code", nmcode);
                cmd.Parameters.AddWithValue("@supl_status", status);
                cmd.Parameters.AddWithValue("@supl_id", sid);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG(company + " updated in the suppliers successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void updateStock(string code, int qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateStock", MainClass.DBConn);
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
        public void updateConsumptionDetail(string code, string prodName, string pack, decimal opnbal, decimal consump, decimal clobal, DateTime sddate, int usrsec)
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

        public void updateSaleInvoice(Int64 piid, DateTime sdate, string reqFrom, string reqTo, string user)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSaleInvoice", MainClass.DBConn);
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

        public void updateSaleDetails(Int64 purchid, string code, string prodName, string pack, int perPack, decimal qty, string catg, DateTime sddate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateSaleDetails", MainClass.DBConn);
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
    }
}
