using doan.DataAcesee;
using doan.DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan.BusinessLayer
{
    class KhachHangBUS
    {
        public DataTable DSCTKhachHang()
        {
            return KhachHangDAO.selectAll();
        }

        public DataTable DSKhachHang()
        {
            string sql = "select MaKH from KhachHang order by MaKH desc";
            return KhachHangDAO.select(sql);
        }

        public DataTable DSMaThe()
        {
            string sql = "select MaThe from TheKhachHang order by MaThe desc";
            return KhachHangDAO.select(sql);
        }

        public DataTable ThemMaThe(TheKhachHangDTO thekh)
        {
            string sql = string.Format("Insert into TheKhachHang values('{0}', '{1}' ," +
                "'{2}', '{3}' )", thekh.MaThe, thekh.MaKH, thekh.NgayLap, thekh.SoLuongDaMua);
            return TheKhachHangDAO.insert(sql);
        }

        public DataTable ThemMaThe(KhachHangDTO kh)
        {
            string sql = string.Format("Insert into KhachHang values('{0}', '{1}' ," +
                "'{2}', '{3}', '{4}' )", kh.MaKH, kh.TenKH, kh.Sdt, kh.DiaChi, kh.Cmnd);
            return TheKhachHangDAO.insert(sql);
        }

        public DataTable LayThongTinThe(string MaThe)
        {
            string sql = string.Format("Select * from TheKhachHang where MaThe = '{0}'", MaThe);
            return TheKhachHangDAO.select(sql);
        }

        public DataTable LayThongTinKhachHang(string MaKH)
        {
            string sql = string.Format("Select kh.*, tkh.* from KhachHang kh JOIN TheKhachHang tkh On kh.MaKh = tkh.MaKH  where kh.MaKH = '{0}'", MaKH);
            return KhachHangDAO.select(sql);
        }

        public DataTable CapNhatThongTinKhachHang(KhachHangDTO kh)
        {
            string sql = string.Format("UPDATE KhachHang Set TenKH = '{0}', Sdt = '{1}', DiaChi = '{2}', CMND= '{3}'" +
               "WHERE MaKH = '{4}'", kh.TenKH, kh.Sdt, kh.DiaChi, kh.Cmnd, kh.MaKH);
            return KhachHangDAO.update(sql);
        }

        public double LaySoLuongDaMua(string Makh)
        {
            string sql = string.Format("SELECT SoLuongDaMua FROM TheKhachHang where MaKH='{0}'", Makh);
            DataTable dt = TheKhachHangDAO.select(sql);
            DataRow row = dt.Rows[0];
            double gia = double.Parse(row["SoLuongDaMua"].ToString());
            return gia;
        }

        public void CapNhatSoLuongDaMua(string Makh, double soluong)
        {
            string sql = string.Format("UPDATE TheKhachHang Set SoLuongDaMua = '{0}' WHERE MaKH = '{1}'", soluong, Makh);
            DataTable dt =  TheKhachHangDAO.update(sql);
        }

       




    }
}
