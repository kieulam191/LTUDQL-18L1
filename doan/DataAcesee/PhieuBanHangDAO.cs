using doan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class PhieuBanHangDAO
    {
        public static DataTable selectAll()
        {
            string sql = "Select * From PhieuBanHang";
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable insert(PhieuBanHangDTO pb)
        {
            string sql = string.Format("INSERT INTO PhieuBanHang VALUES('{0}', '{1}')",pb.MaPBH, pb.NgayBan);
            return SqlProvider.ExecuteQuery(sql);
        }
    }
}
