using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Controllers
{
    class CauHoi
    {
        static public List<Models.CauHoi> get(int id_vongdau)
        {
            List<Models.CauHoi> list = new List<Models.CauHoi>();
            DataTable data = Models.CauHoi.get(id_vongdau);
            foreach (DataRow item in data.Rows)
            {
                Models.CauHoi row = new Models.CauHoi(item);
                list.Add(row);
            }
            return list;
        }
    }
}
