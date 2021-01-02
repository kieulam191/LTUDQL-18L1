using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class GaoDTO
    {
        private string _maGao;
        private string _tenSanPham;
        private string _loaiSanPham;
        private double _giaMuaVao;
        private int _soLuongTonKho;

        public string MaGao { get => _maGao; set => _maGao = value; }
        public string TenSanPham { get => _tenSanPham; set => _tenSanPham = value; }
        public string LoaiSanPham { get => _loaiSanPham; set => _loaiSanPham = value; }
        public double GiaMuaVao { get => _giaMuaVao; set => _giaMuaVao = value; }
        public int SoLuongTonKho { get => _soLuongTonKho; set => _soLuongTonKho = value; }
    }
}
