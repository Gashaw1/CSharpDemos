using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayerPro
{
    public class DataAccess
    {
        SqlConnection sqlConnection { get; set; }
        SqlCommand cmd { get; set; }
        SqlParameter param { get; set; }
        SqlDataAdapter dataAdapter { get; set; }
        DataSet dataSet { get; set; }
        DataTable dataTable { get; set; }
        DataRow dataRow { get; set; }

        string conStr = ConfigurationManager.ConnectionStrings[""].ConnectionString;

        public DataSet ReturnData()
        {
            dataSet = new DataSet();
            try
            {
                using (sqlConnection = new SqlConnection(conStr))
                {
                    cmd = new SqlCommand("SP_GetUser", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {

            }
            return dataSet;
        }
        public DataSet ReturnData(int id)
        {
            dataSet = new DataSet();
            dataTable = new DataTable(); try
            {
                using (sqlConnection = new SqlConnection(conStr))
                {
                    cmd = new SqlCommand("SP_GetUser", sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    param = new SqlParameter("@UserId", id);
                    cmd.Parameters.Add(param);
                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataSet);
                }

            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return dataSet;
        }
        public void UpdateDataSet(DataTable dt)
        {
            dataSet = new DataSet();
            dataSet.Tables.Add(dt);
        }
        public DataTable UpdateDataTable(DataRow dr)
        {
            dataTable = new DataTable();
            dataRow = dataTable.NewRow();
            //dataTable.Rows.InsertAt(dr, 0);
            dataTable.Rows.Add(dr);
            return dataTable;
        }
        //public void g(string[] obj)
        //{
        //    dataRow[""] = obj;

        //    DataRow dr = ds.Tables[0].NewRow();
        //    dr["Column1"] = "value";
        //    dr["Column2"] = "value";
        //    dr["Column3"] = "value";

        //    ds.Tables[0].Rows.Add(dr);
        //}
    }
}