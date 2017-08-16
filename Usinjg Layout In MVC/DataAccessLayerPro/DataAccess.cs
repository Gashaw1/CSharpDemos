using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Caching;

namespace DataAccessLayerPro
{
    public class DataAccess
    {
        SqlConnection sqlConnection { get; set; }
        SqlCommand cmd { get; set; }
        SqlParameter param { get; set; }
        SqlDataAdapter dataAdapter { get; set; }
        DataSet dataSet { get; set; }
        ~DataAccess()
        {

        }
        DataTable dataTable { get; set; }
        DataRow dataRow { get; set; }
        Cache cache { get; set; }
        SqlCommandBuilder comandBuilder { get; set; }

        string conStr = ConfigurationManager.ConnectionStrings["UsereDBContext"].ConnectionString;
        //Return all user
        public DataSet ReturnData()
        {
            dataSet = new DataSet();
            try
            {
                using (sqlConnection = new SqlConnection(conStr))
                {
                    cmd = new SqlCommand("SP_ReturnUser", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataSet;
        }
        //Return singule user
        public DataSet ReturnData(int id)
        {
            dataSet = new DataSet();
            try
            {
                using (sqlConnection = new SqlConnection(conStr))
                {
                    cmd = new SqlCommand("SP_ReturnUserByID", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    param = new SqlParameter("@UserId", id);
                    cmd.Parameters.Add(param);
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataSet, "Users");

                    //Invock Cache method
                    CacheData(dataSet);
                }

            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return dataSet;
        }
        //Cache Data
        public void CacheData(DataSet ds)
        {
            dataSet = new DataSet();
            dataSet = ds;
            dataSet.Tables["Users"].PrimaryKey = new DataColumn[] { dataSet.Tables["Users"].Columns["UserID"] };
            cache = new Cache();
            cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24), Cache.NoSlidingExpiration);
        }
        //Return cached this could be Updted row or not
        public DataSet ReturnCachedDatq()
        {
            cache = new Cache();
            if (cache["DATASET"] != null)
            {
                dataSet = new DataSet();
                dataSet = (DataSet)cache["DATASET"];
            }
            return dataSet;
        }
        //Updaet cached data
        public void UpdateCachedData(int UserID, string UserName, string UserEmail, string UserPassword)
        {
            cache = new Cache();
            if (cache["DATASET"] != null)
            {
                dataSet = new DataSet();
                dataSet = (DataSet)cache["DATASET"];
                dataRow = dataSet.Tables["Users"].Rows.Find(UserID);
                dataRow["UserName"] = UserName;
                dataRow["UserEmail"] = UserEmail;
                dataRow["UserPassword"] = UserPassword;

                cache = new Cache();
                cache.Insert("DATASET", dataSet, null, DateTime.Now.AddHours(24), Cache.NoSlidingExpiration);
            }
        }
        //Update database from the Cached data
        public void UpdateDataBase()
        {
            dataSet = new DataSet();
            try
            {
                using (sqlConnection = new SqlConnection(conStr))
                {
                    sqlConnection.Open();
                    cmd = new SqlCommand("SP_ReturnUser", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dataAdapter = new SqlDataAdapter(cmd);
                    comandBuilder = new SqlCommandBuilder(dataAdapter);
                    cache = new Cache();
                    //fill the dataset from the cached data
                    dataSet = (DataSet)cache["DATASET"];

                    if (dataSet.Tables["Users"].Rows.Count > 0)
                    {
                        DataRow row = dataSet.Tables["Users"].Rows[0];
                        //Invoked cached data method
                        dataSet = ReturnCachedDatq();
                        DataRow newRow = dataSet.Tables["Users"].Rows[0];
                        row["UserName"] = newRow["UserName"].ToString();
                        row["UserEmail"] = newRow["UserEmail"].ToString();
                        row["UserPassword"] = newRow["UserPassword"].ToString();

                        //update the database
                        dataAdapter.Update(dataSet, "Users");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        //Insert new data
        public bool InsertData(string userName, string userEmail, string userPassword)
        {
            using (sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                cmd = new SqlCommand("Sp_InsertUser", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                param = new SqlParameter("@UserName", userName);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@UserEmail", userEmail);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@UserPassword", userPassword);
                cmd.Parameters.Add(param);

                int rowInserted = cmd.ExecuteNonQuery();
                if (rowInserted == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //update User Table in database
        public bool UpdatDataBase(int userId, string userName, string userEmail, string userPassword)
        {
            using (sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();

                cmd = new SqlCommand("SP_Update_Users", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                param = new SqlParameter("@UserID", userId);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@UserName", userName);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@UserEmail", userEmail);
                cmd.Parameters.Add(param);

                param = new SqlParameter("@UserPassword", userPassword);
                cmd.Parameters.Add(param);

                int rowUpdate = cmd.ExecuteNonQuery();

                if (rowUpdate == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        //delete
        public bool Delete(int id)
        {
            using (sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                cmd = new SqlCommand("SP_Delete_User", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                param = new SqlParameter("@UserID", id);
                cmd.Parameters.Add(param);
                int rowAffect = cmd.ExecuteNonQuery();
                if(rowAffect == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }
    }
}