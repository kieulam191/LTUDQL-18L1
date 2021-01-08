using doan.DataAcesee;
using doan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.BusinessLayer
{
    class PhieuNhapHangBUS
    {
        public DataTable DSCTPhieuNhap()
        {
            ChiTietPhieuNhapDAO dao = new ChiTietPhieuNhapDAO();
            return dao.DanhSachChiTietPhieuNHap();
        }

        public DataTable DSPhieuNhap()
        {
            string sql = "select MaPN from PhieuNhapGao order by MaPN desc";
            return PhieuNhapGaoDAO.select(sql);
        }

        public DataTable DSMaGao()
        {
            string sql = "select MaGao from Gao";
            return GaoDAO.select(sql);
        }

        public DataTable ThemPhieuNhap(PhieuNhapHangDTO phieu)
        {
            string sql = string.Format("INSERT INTO PhieuNhapGao VALUES('{0}', '{1}')",phieu.MaPN, phieu.NgayNhap);
            return PhieuNhapGaoDAO.insert(sql);
        }


        public DataTable LayThongTinGao(string MaGao)
        {
            string sql = string.Format("SELECT * FROM Gao where Magao='{0}'", MaGao);
            return PhieuNhapGaoDAO.select(sql);
        }

        public double LayGiaGaoHienTai(string MaGao)
        {
            string sql = string.Format("SELECT GiaBanRa FROM ChiTietPhieuNhap where Magao='{0}'", MaGao);
            DataTable dt = PhieuNhapGaoDAO.select(sql);
            DataRow row = dt.Rows[0];
            double gia = double.Parse(row["GiaBanRa"].ToString());
            return gia;
        }

        public DataTable LayThongTinPhieuNhap(string MaPhieuNhap)
        {
            string sql = string.Format("Select ct.*, p.NgayNhap from ChiTietPhieuNhap ct JOIN PhieuNhapGao p " +
                "ON CT.MaPhieuNhap = p.MaPN " +
                "JOIN Gao G ON G.MaGao = ct.MaGao " +
                "where MaPhieuNhap = '{0}'", MaPhieuNhap);
            return ChiTietPhieuNhapDAO.select(sql);
        }

       
    }
}
