using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.DataAcesee
{
    class GaoDAO
    {
        public static DataTable select(string sql)
        {
            return SqlProvider.ExecuteQuery(sql);
        }
    }
}
