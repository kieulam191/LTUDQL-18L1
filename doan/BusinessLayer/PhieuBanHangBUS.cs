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
    class PhieuBanHangBUS
    {
        public DataTable DSPhieuBan()
        {
            return PhieuBanHangDAO.selectAll();
        }

        public DataTable DSCTPhieuBan()
        {
            return ChiTietPhieuBanDAO.SelectAll();
        }

        public DataTable ThemPhieuBanHang(PhieuBanHangDTO pb)
        {
            return PhieuBanHangDAO.insert(pb);
        }

        public DataTable ThenCTPHieuBanHang(ChiTietPhieuBanDTO pb)
        {
            return ChiTietPhieuBanDAO.insert(pb);
        }



        


    }
}
