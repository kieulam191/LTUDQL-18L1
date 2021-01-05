using doan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class LoaiGaoDAO
    {
        public void insertLoaiGao(LoaiGaoDTO loai)
        {
            string sql = string.Format("INSERT INTO LoaiGao(MaLoai, TenLoai) VALUES('{0}', {1})", loai.MaLoai, loai.TenLoai);
        }

        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }
    }
}
