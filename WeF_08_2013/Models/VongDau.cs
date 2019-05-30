using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Models
{
    class VongDau
    {
        public int id_vongdau { get; set; }
        public int id_tran { get; set; }
        public int vong { get; set; }
        public int diem { get; set; }
        public int id_doithang { get; set; }

        public VongDau()
        {

        }

        public VongDau(DataRow row)
        {
            this.set((int)row["id_vongdau"],
                    (int)row["id_tran"],
                    (int)row["vong"],
                    (int)row["diem"],
                    (int)row["id_doithang"]);
        }

        public VongDau(int id_vongdau, int id_tran,int vong,int diem, int id_doithang)
        {
            this.set(id_vongdau, id_tran,vong, diem, id_doithang);
        }

        public void set(int id_vongdau, int id_tran, int vong, int diem, int id_doithang)
        {
            this.id_vongdau = id_vongdau;
            this.id_tran = id_tran;
            this.vong = vong;
            this.diem = diem;
            this.id_doithang = id_doithang;
        }

        public bool insert()
        {
            int result = Connection.ExecuteNonQuery("exec sp_addVongDau @id_tran , @vong , @diem , @id_doithang",
                                     new object[] { id_tran,vong,diem,id_doithang});
            return result > 0;
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("exec sp_getVongDau @id_tran",
                                     new object[] { id_tran });
        }
    }
}
