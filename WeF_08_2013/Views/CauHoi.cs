using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeF_08_2013.Views
{
    public partial class CauHoi : Form
    {
        private int id_vongdau;
        public CauHoi(int id_vongdau)
        {
            InitializeComponent();
            this.id_vongdau = id_vongdau;
            LoadData();
            
        }
        private void LoadData()
        {
            List<Models.CauHoi> l = Controllers.CauHoi.get(id_vongdau);
            this.data.DataSource = l;
            this.data.Columns[0].Visible = false;
            this.data.Columns[1].HeaderText = "Mã vòng";
            this.data.Columns[2].HeaderText = "Nội dung";
            this.data.Columns[3].HeaderText = "Đáp án";
            this.data.Columns[4].HeaderText = "Điểm";
        }
    }
}
