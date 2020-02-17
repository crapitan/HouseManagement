using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HouseManagement
{
    public class SQLdatabase
    {
        private string SqlCon = "Data Source = fhv-2020-students.database.windows.net;Initial Catalog = FHV-2020-DB1; Integrated Security = True";

        public DataTable ExecuteQuery(string sqlStr)
        {
            SqlConnection con = new SqlConnection(SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            DataTable dt = new DataTable();
            SqlDataAdapter msda = new SqlDataAdapter(cmd);
            msda.Fill(dt);
            con.Close();
            return dt;
        }

        public int ExecuteUpdate(string sqlStr)//用于增删改;
        {
            SqlConnection con = new SqlConnection(@SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            int iud = 0;
            iud = cmd.ExecuteNonQuery();
            con.Close();
            return iud;
        }

    }
}
