using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class ThayDoiQDDTO
    {
        private double _GiaBanRa;
        private int _SoLuongSP;
        private DateTime _NgayNo;

        public double GiaBanRa { get => _GiaBanRa; set => _GiaBanRa = value; }
        public int SoLuongSP { get => _SoLuongSP; set => _SoLuongSP = value; }
        public DateTime NgayNo { get => _NgayNo; set => _NgayNo = value; }
    }
}
