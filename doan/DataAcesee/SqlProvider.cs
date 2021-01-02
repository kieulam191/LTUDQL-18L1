﻿using System;
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
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\phuc\source\repos\QuanLyNhanVien\QuanLyNhanVien\qlnv.mdf;Integrated Security=True";
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

        public static DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
            adapter.Fill(dt);
            return dt;
        }
    }
}