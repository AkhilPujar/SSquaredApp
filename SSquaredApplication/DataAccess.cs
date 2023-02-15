using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SSquaredApplication
{
    public class DataAccess
    {
        public static DataTable GetAllEmployee()
        {
            SqlDataAdapter adapter;
            string conn = ConfigurationManager.ConnectionStrings["SSQEnterpriseDB"].ConnectionString;
            adapter = new SqlDataAdapter("SSquared_sp_GetAllEmployee", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds;
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetAllManagers()
        {
            SqlDataAdapter adapter;
            string conn = ConfigurationManager.ConnectionStrings["SSQEnterpriseDB"].ConnectionString;
            adapter = new SqlDataAdapter("SSquared_sp_GetAllManagers", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds;
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetSelectedManagerEmplyeee(string manager)
        {
            SqlDataAdapter adapter;
            string conn = ConfigurationManager.ConnectionStrings["SSQEnterpriseDB"].ConnectionString;
            adapter = new SqlDataAdapter("SSquared_sp_GetAllEmployeeForSelectedManager", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@selectedManager", manager);
            DataSet ds;
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetAllRoles()
        {
            SqlDataAdapter adapter;
            string conn = ConfigurationManager.ConnectionStrings["SSQEnterpriseDB"].ConnectionString;
            adapter = new SqlDataAdapter("SSquared_sp_GetAllRole", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds;
            ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}