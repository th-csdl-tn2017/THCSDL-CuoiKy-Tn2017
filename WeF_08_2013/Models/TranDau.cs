using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Models
{
    class TranDau
    {
        public int id_tran { get; set; }
        public int doiA { get; set; }
        public int doiB { get; set; }
        public DateTime ngaydau { get; set; }

        public TranDau()
        {

        }

        public TranDau(DataRow row)
        {
            this.set((int)row["id_tran"],
                    (int)row["doiA"],
                    (int)row["doiB"],
                    (DateTime)row["ngaydau"]);
        }

        public TranDau(int id_tran, int doiA, int doiB, DateTime ngaydau)
        {
            this.set(id_tran, doiA, doiB, ngaydau);
        }

        public void set(int id_tran, int doiA, int doiB, DateTime ngaydau)
        {
            this.id_tran = id_tran;
            this.doiA = doiA;
            this.doiB = doiB;
            this.ngaydau = ngaydau;
        }

        public bool insert()
        {
            int result = Connection.ExecuteNonQuery("exec sp_addTranDau @doiA , @doiB",
                                     new object[] { doiA,doiB});
            return result > 0;
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("sp_getTranDau");
        }
    }
}
