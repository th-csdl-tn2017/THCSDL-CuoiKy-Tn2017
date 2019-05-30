using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WeF_08_2013.Models
{
    class CauHoi
    {
        public int id_cauhoi { get; set; }
        public int id_vongdau { get; set; }
        public string noidung { get; set; }
        public long dapan { get; set; }
        public int diem { get; set; }

        public CauHoi()
        {

        }

        public CauHoi(DataRow row)
        {
            this.set((int)row["id_cauhoi"],
                    (int)row["id_vongdau"],
                    row["noidung"].ToString(),
                    (long)row["dapan"],
                    (int)row["diem"]);
        }

        public CauHoi(int id_cauhoi, int id_vongdau, string noidung, long dapan, int diem)
        {
            this.set(id_cauhoi, id_vongdau, noidung, dapan, diem);
        }

        public void set(int id_cauhoi, int id_vongdau, string noidung, long dapan, int diem)
        {
            this.id_cauhoi = id_cauhoi;
            this.id_vongdau = id_vongdau;
            this.noidung = noidung;
            this.dapan = dapan;
            this.diem = diem;
        }

        public bool insert()
        {
            int result = Connection.ExecuteNonQuery("exec sp_addCauHoi @id_vongdau , @noidung , @dapan , @diem",
                                     new object[] { id_vongdau,noidung,dapan,diem});
            return result > 0;
        }

        static public DataTable get()
        {
            return Connection.ExecuteQuery("exec sp_getCauHoi @id_vongdau",
                                     new object[] { id_vongdau });
        }
    }
}
