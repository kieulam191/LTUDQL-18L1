using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class ChiTietPhieuBanDTO
    {
        private string _maPhieuBanHang;
        private string _maGao;
        private string _maKH;
        private int _soLuongMua;
        private double _giaHienTai;

        public string MaPhieuBanHang { get => _maPhieuBanHang; set => _maPhieuBanHang = value; }
        public string MaGao { get => _maGao; set => _maGao = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public int SoLuongMua { get => _soLuongMua; set => _soLuongMua = value; }
        public double GiaHienTai { get => _giaHienTai; set => _giaHienTai = value; }
    }
}
