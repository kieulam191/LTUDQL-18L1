using doan.DataAcesee;
using doan.DTO;
using doan.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.BusinessLayer
{
    class NhaCungCapBUS
    {
        public DataTable DSNhaCungCap()
        {
            return NhaCungCapDAO.selectAll();
        }

        public DataTable DSTenNCC()
        {
            string sql = "Select MaNCC From NhaCungCap order by MaNCC desc";
            return NhaCungCapDAO.select(sql);
        }
        public DataTable ThemNhaCungCap(NhaCungCapDTO ncc)
        {
            string sql = string.Format(@"Insert into NhaCungCap VALUES('{0}',N'{1}','{2}', N'{3}', N'{4}')", ncc.MaNCC, ncc.TenNCC, ncc.Sdt, ncc.DiaChi, ncc.TinhTrang);
            return NhaCungCapDAO.insert(sql);
        }

        public DataTable CapNhatNhaCungCap(NhaCungCapDTO ncc)
        {
            string sql = string.Format("UPDATE NhaCungCap Set TenNCC = N'{0}', Sdt = '{1}', DiaChi = N'{2}', TinhTrang= N'{3}'" +
                "WHERE MaNCC = '{4}'", ncc.TenNCC, ncc.Sdt, ncc.DiaChi, ncc.TinhTrang, ncc.MaNCC);
            return NhaCungCapDAO.update(sql);
        }


        public DataTable XoaNhaCungCap(string MaNCC)
        {
            string sql = string.Format("DELETE NhaCungCap WHERE MaNCC = '{0}'", MaNCC);
            return NhaCungCapDAO.delete(sql);
        }

        public DataTable LayThongTinNhaCungCap(string MaNCC)
        {
            string sql = string.Format("Select * from NhaCungCap where  MaNCC = '{0}'", MaNCC);
            return NhaCungCapDAO.select(sql);
        }

       
    }
}
