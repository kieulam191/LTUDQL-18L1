using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class PhieuNhapHangDTO
    {
        private string _maPN;
        private string _ngayNhap;

        public string MaPN { get => _maPN; set => _maPN = value; }
        public string NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
    }
}
