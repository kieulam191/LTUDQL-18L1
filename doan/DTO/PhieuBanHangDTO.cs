using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class PhieuBanHangDTO
    {
        private string _maPBH;
        private string _ngayBan;

        public string MaPBH { get => _maPBH; set => _maPBH = value; }
        public string NgayBan { get => _ngayBan; set => _ngayBan = value; }
    }
}
