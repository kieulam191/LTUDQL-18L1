using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class NhaCungCapDTO
    {
        private string maNCC;
        private string tenNCC;
        private string sdt;
        private string diaChi;
        private string tinhTrang;

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
