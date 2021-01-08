using doan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class ChiTietPhieuBanDAO
    {
        public static DataTable SelectAll()
        {
            string sql = "select * from ChiTietPhieuBan";
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable insert(ChiTietPhieuBanDTO pb)
        {
            string sql = string.Format("Insert into ChitietPhieuBan values ('{0}', '{1}', " +
                "'{2}', '{3}', '{4}')", pb.MaPhieuBanHang, pb.MaGao, pb.MaKH, pb.SoLuongMua, pb.GiaHienTai);
            return SqlProvider.ExecuteQuery(sql);

        }

        public static DataTable insert(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }
    }
}
