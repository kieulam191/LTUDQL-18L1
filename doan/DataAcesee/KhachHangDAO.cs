using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class KhachHangDAO
    {
        public static DataTable selectAll()
        {
            string sql = "SELECT TKH.Mathe, kh.* FROM KhachHang KH JOIN TheKhachHang TKH on " +
                "KH.MaKH = TKH.MaKH";
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable update(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

    }
}
