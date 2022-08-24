using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
namespace WebApplication3
{
    public class DBConnection
    {
        public int ExecuteQuery(string qry)
        {
            string cs = "server=localhost; user Id=root; password=ananta@1332148; Persist Security Info= true; database=ananta";
            MySqlConnection objMySqlConnection = new MySqlConnection(cs);
            MySqlCommand objMySqlCommnand = new MySqlCommand(qry, objMySqlConnection);
            objMySqlConnection.Open();
             int iResult =objMySqlCommnand.ExecuteNonQuery();
            return iResult;
        }

        public DataTable GetDataTable(string qry)
        {
            string cs = "server=localhost; user Id=root; password=ananta@1332148; Persist Security Info= true; database=ananta";
            MySqlConnection objMySqlConnection = new MySqlConnection(cs);
            MySqlDataAdapter objmySqlDataAdapter = new MySqlDataAdapter(qry, objMySqlConnection);
            DataTable dt = new DataTable();
            objmySqlDataAdapter.Fill(dt);
            return dt;
        
        }
    }
}