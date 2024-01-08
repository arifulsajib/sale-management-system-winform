using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleDAL
{
    public class sqlHelp
    {
        //Database connection string
        public static string Connectionstr = @"Data Source=DESKTOP-GHM1KBB;Initial Catalog=db_saleManagement;User ID=sa;pwd=12345";

        //query
        public static DataTable ExecuteQuery(string sql)
        {
            try
            {
                SqlConnection con = new SqlConnection(Connectionstr);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message;
                return null;
            }

        }



        //add, delete, modify
        public static int ExecuteUpdate(string sql)
        {
            int i = 0;

            try
            {
                SqlConnection conn = new SqlConnection(Connectionstr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i;
            }
            catch (Exception ex)
            {
                string strMsg = ex.Message;
                return 0;
            }
        }


    }
}
