using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class NhaCungCapDAO
    {
        public static DataTable selectAll()
        {
            string sql = "select * from NhaCungCap";
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable insert(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable update(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable delete(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

    }
}
