using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Controllers
{
    class VongDau
    {
        static public List<Models.VongDau> get()
        {
            List<Models.VongDau> list = new List<Models.VongDau>();
            DataTable data = Models.VongDau.get();
            foreach (DataRow item in data.Rows)
            {
                Models.VongDau row = new Models.VongDau(item);
                list.Add(row);
            }
            return list;
        }
    }
}
