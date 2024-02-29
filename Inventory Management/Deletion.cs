using System;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management
{
    class Deletion
    {
        public void delete(object id, string procedure, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Data deleted successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void deleteConsumptionItem(DateTime delDate, string itemCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteitemfromconsumptionlist", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@deldate", delDate);
                cmd.Parameters.AddWithValue("@item", itemCode);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Data deleted successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        public void deletePurchaseInvoiceItem(Int64 piid, string itemCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_deleteitemfrompurchaseinvdetails", MainClass.DBConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@piid", piid);
                cmd.Parameters.AddWithValue("@itemcd", itemCode);
                MainClass.DBConn.Open();
                cmd.ExecuteNonQuery();
                MainClass.DBConn.Close();
                MainClass.showMSG("Data deleted successfully.", "Success..!", "Success");
            }
            catch (Exception Ex)
            {
                MainClass.DBConn.Close();
                MainClass.showMSG(Ex.Message, "Error..!", "Error");
            }
        }
        //// output value from stored procedure
        //SqlCommand cmd = new SqlCommand("st_getProductQtyByParam", MainClass.DBConn);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.CommandTimeout = 0;
        //cmd.Parameters.AddWithValue("@prod_code", textItemCode.Text.Trim());
        //SqlParameter param2 = new SqlParameter("@qty", SqlDbType.Int);
        //param2.Direction = ParameterDirection.ReturnValue;
        //cmd.Parameters.Add(param2);
        //MainClass.DBConn.Open();
        //cmd.ExecuteNonQuery();
        //// assign value to variable
        //qtyBalance = Convert.ToInt32(param2.Value);
        //MainClass.DBConn.Close();
    }
}
