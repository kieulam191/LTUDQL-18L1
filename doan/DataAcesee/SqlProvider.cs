using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class SqlProvider
    {
        public static string connectionString = @"Data Source=desktop-ftf5mtp\sqlexpress;Initial Catalog=QuanLyCuaHangBanGao;User ID=sa;Password=2012";
        public static SqlConnection connection = null;
        public static void openConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }

            if (connection != null)
            {
                connection.Open();
            }
        }

        public static void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public static void ExecuteNoneQuery(string sql)
        {
            openConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            command.ExecuteNonQuery();
            closeConnection();
        }

        public static int ExecuteNonQuery (CommandType cmdType, string strsql, params SqlParameter[] parameters)
        {
            try
            {
                openConnection();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = strsql;
                command.CommandType = cmdType;

                if(parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                closeConnection();
            }
        }

        public static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            adapter.Fill(dt);
            return dt;
        }
    }
}
