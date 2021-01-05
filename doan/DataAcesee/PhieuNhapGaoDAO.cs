using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class PhieuNhapGaoDAO
    {
        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable insert(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }
    }
}
