using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan.DataAcesee
{
    class TheKhachHangDAO
    {
        public static DataTable select()
        {
            string sql = "select * from TheKhachHang";
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


    }
}
