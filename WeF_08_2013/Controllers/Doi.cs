using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Controllers
{
    class Doi
    {
        static public List<Models.Doi> get()
        {
            List<Models.Doi> list = new List<Models.Doi>();
            DataTable data = Models.Doi.get();
            foreach (DataRow item in data.Rows)
            {
                Models.Doi row = new Models.Doi(item);
                list.Add(row);
            }
            return list;
        }
    }
}
