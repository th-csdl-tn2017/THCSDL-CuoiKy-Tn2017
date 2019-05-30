using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Controllers
{
    class ThanhVien
    {
        static public List<Models.ThanhVien> get()
        {
            List<Models.ThanhVien> list = new List<Models.ThanhVien>();
            DataTable data = Models.ThanhVien.get();
            foreach (DataRow item in data.Rows)
            {
                Models.ThanhVien row = new Models.ThanhVien(item);
                list.Add(row);
            }
            return list;
        }
    }
}
