using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Models
{
    class ThanhVien
    {
        public int id_tv { get; set; }
        public int id_doi { get; set; }
        public string ten { get; set; }
        public DateTime ngaysinh {get;set;}

        public ThanhVien()
        {

        }

        public ThanhVien(DataRow row)
        {
            this.set((int)row["id_tv"],
                    (int)row["id_doi"],
                    row["ten"].ToString(),
                    (DateTime)row["ngaysinh"]);
        }

        public ThanhVien(int id_tv, int id_doi, string ten, DateTime ngaysinh)
        {
            this.set(id_tv, id_doi, ten, ngaysinh);
        }

        public void set(int id_tv, int id_doi, string ten, DateTime ngaysinh)
        {
            this.id_tv = id_tv;
            this.id_doi = id_doi;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
        }

        public void insert()
        {
            Connection.ExecuteNonQuery("sp_addThanhVien @id_doi , @ten , @ngaysinh", new object[] { id_doi,ten,ngaysinh });
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getThanhVien @id_doi", new object[] { id_doi });
        }
    }
}
