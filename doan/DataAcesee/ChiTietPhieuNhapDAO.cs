using doan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class ChiTietPhieuNhapDAO
    {
        public DataTable DanhSachChiTietPhieuNHap()
        {
            return SqlProvider.ExecuteQuery("Select ct.*, pn.NgayNhap from ChiTietPhieuNhap ct join PhieuNhapGao pn on ct.MaPhieuNhap = pn.MaPN");
        }

        public static DataTable insert(ChiTietPhieuNhapDTO chiTiet)
        {
            string sql = string.Format("INSERT INTO ChiTietPhieuNhap VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", chiTiet.MaPhieuNhap,chiTiet.MaGao,chiTiet.SoLuongNhap,
                chiTiet.GiaBanRa, chiTiet.MaNCC, chiTiet.GiaMuaVao);
            return SqlProvider.ExecuteQuery(sql);
        }

        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }

    }
}
