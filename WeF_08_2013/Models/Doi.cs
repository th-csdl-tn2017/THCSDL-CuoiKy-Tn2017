using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Models
{
    class Doi
    {
        public int id_doi { get; set; }
        public string tendoi { get; set; }

        public Doi()
        {

        }

        public Doi(DataRow row)
        {
            this.set((int)row["id_doi"],
                    row["tendoi"].ToString());
        }

        public Doi(int id, string ten)
        {
            this.set(id, ten);
        }

        public void set(int id, string ten)
        {
            this.id_doi = id;
            this.tendoi = ten;
        }

        public void insert()
        {
            Connection.ExecuteNonQuery("sp_addDoi @ten", new object[] { tendoi });
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getDoi");
        }
    }
}
