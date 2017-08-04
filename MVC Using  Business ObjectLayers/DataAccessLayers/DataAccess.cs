using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public static class DataAccess
    {
        static SqlConnection sqlConnection { get; set; }
        static DataTable dataTable { get; set; }
        static string conString = ConfigurationManager.ConnectionStrings["UsereDBContext"].ConnectionString;
        //return all user
        public static DataTable ReturnData()
        {
            dataTable = new DataTable();
            using (sqlConnection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("SP_ReturnUser", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
        //return user by id
        public static DataTable ReturnData(int userID)
        {
            dataTable = new DataTable();
            using (sqlConnection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("SP_ReturnUserByID", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@UserID", userID);
                cmd.Parameters.Add(param);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}