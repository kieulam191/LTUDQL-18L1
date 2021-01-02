using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DTO
{
    class LoaiGaoDTO
    {
        private string _maLoai;
        private string _tenLoai;

        public string MaLoai { get => _maLoai; set => _maLoai = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }
    }
}
