using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class TheGhiNoDTO
    {
        private string _MaTheGhiNo;
        private string _TenKH;
        private DateTime _NgayNo;
        private double _TienNo;
        private DateTime _NgayDKTraNo;

        public string MaTheGhiNo { get => _MaTheGhiNo; set => _MaTheGhiNo = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public DateTime NgayNo { get => _NgayNo; set => _NgayNo = value; }
        public double TienNo { get => _TienNo; set => _TienNo = value; }
        public DateTime NgayDKTRaNo { get => _NgayDKTraNo; set => _NgayDKTraNo = value; }




    }
}
