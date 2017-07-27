using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayers
{
    public class DataAccess
    {
        SqlConnection sqlConnection { get; set; }
        DataTable dataTable { get; set; }
        string conString = ConfigurationManager.ConnectionStrings["UsereDBContext"].ConnectionString;
        //return all user
        protected  DataTable ReturnData()
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
        protected DataTable ReturnData(int userID)
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