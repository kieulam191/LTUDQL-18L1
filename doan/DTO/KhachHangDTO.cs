using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class KhachHangDTO
    {
       
        private string _maKH;
        private string _tenKH;
        private string _sdt;
        private string _diaChi;
        private string _cmnd;

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Cmnd { get => _cmnd; set => _cmnd = value; }
       
    }
}
