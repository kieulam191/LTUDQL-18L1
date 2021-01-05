using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class ChiTietPhieuNhapDTO
    {
       
        private string _maPhieuNhap;
        private string _maGao;
        private int _soLuongNhap;
        private double _giaBanRa;
        private double _giaMuaVao;
        private string _maNCC;

        public string MaPhieuNhap { get => _maPhieuNhap; set => _maPhieuNhap = value; }
        public string MaGao { get => _maGao; set => _maGao = value; }
        public int SoLuongNhap { get => _soLuongNhap; set => _soLuongNhap = value; }
        public double GiaBanRa { get => _giaBanRa; set => _giaBanRa = value; }
        public string MaNCC { get => _maNCC; set => _maNCC = value; }
        public double GiaMuaVao { get => _giaMuaVao; set => _giaMuaVao = value; }
    }
}
