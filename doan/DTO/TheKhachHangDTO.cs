using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class TheKhachHangDTO
    {
        private string _maThe;
        private string _maKH;
        private string _ngayLap;
        private int _soLuongDaMua;

        public string MaThe { get => _maThe; set => _maThe = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public int SoLuongDaMua { get => _soLuongDaMua; set => _soLuongDaMua = value; }
    }
}
