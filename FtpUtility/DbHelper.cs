using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpUtility
{
    public static class DbHelper
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;

        public static string SaveChanges(int Customer_Id, long TotalFiles, string TotalSize)
        {

            string Msg = string.Empty;

            SqlConnection Conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Utility_SaveFTPStats", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dtReturn = new DataTable();
            try
            {
                cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id);
                cmd.Parameters.AddWithValue("@TotalFile", TotalFiles);
                cmd.Parameters.AddWithValue("@TotalSize", TotalSize);
                Conn.Open();
                cmd.ExecuteNonQuery();

                Msg = "Success";
            }
            catch (Exception ex)
            {
                Msg = ex.ToString();
            }
            finally
            {
                Conn.Close();
            }


            return Msg;
        }

        public static List<FtpConfigurationcs> GetFTPConfigurtion(int Customer_id)
        {
            string Msg = string.Empty;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection Conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Utility_GetFTPConfig", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtReturn = new DataTable();
                try
                {
                    cmd.Parameters.AddWithValue("@Customer_Id", Customer_id);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                }
                catch (Exception ex)
                {
                    Msg = ex.ToString();
                }
                finally
                {
                    Conn.Close();
                }
            }
            catch (Exception ex1)
            {
                Msg = ex1.ToString();
            }

            return ds.Tables[0].ToList<FtpConfigurationcs>();
        }

    }
}
