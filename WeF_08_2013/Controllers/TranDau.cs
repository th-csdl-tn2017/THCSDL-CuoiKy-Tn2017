﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Controllers
{
    class TranDau
    {
        static public List<Models.TranDau> get()
        {
            List<Models.TranDau> list = new List<Models.TranDau>();
            DataTable data = Models.TranDau.get();
            foreach (DataRow item in data.Rows)
            {
                Models.TranDau row = new Models.TranDau(item);
                list.Add(row);
            }
            return list;
        }
    }
}
