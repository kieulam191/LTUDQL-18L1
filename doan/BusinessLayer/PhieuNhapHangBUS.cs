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


        public void LayThongTin()
        {
            
        }
    }
}
