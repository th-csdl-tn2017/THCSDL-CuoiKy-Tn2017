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
    public partial class TranDau : UserControl
    {
        public TranDau()
        {
            InitializeComponent();
            this.LoadData();
            this.LoadTinh();
        }

        private void LoadData()
        {
            List<Models.TranDau> l = Controller.TranDau.get();
            this.data.DataSource = l;
            this.data.Columns[0].HeaderText = "Mã ngân sách";
            this.data.Columns[1].HeaderText = "Kinh Phí";
            this.data.Columns[2].HeaderText = "Năm Cấp";
            this.data.Columns[3].Visible = false;
            this.data.Columns[4].HeaderText = "Tên tỉnh";
        }

        private void LoadTinh()
        {
            List<Models.TinhThanh> l = Controller.TinhThanh.get();
            List<Models.TinhThanh> l2 = Controller.TinhThanh.get();
            l.Add(new Models.TinhThanh(0, "Tất cả"));
            this.provinceSearch.DataSource = l;
            this.provinceSearch.DisplayMember = "tentinh";
            this.sl_DoiA.DataSource = l2;
            this.sl_DoiA.DisplayMember = "tentinh";
        }
        private bool check()
        {
            if (
                this.kinhphi.TextLength > 0 
            )
                return true;
            return false;
        }


        private void submit_Click(object sender, EventArgs e)
        {
            Models.TranDau x = new Models.TranDau();
            if (!check())
            {
                MessageBox.Show("Bạn chưa nhập hết dữ liệu!");
                return;
            }
            x.kinhphi = Convert.ToInt32(this.kinhphi.Text.Trim());
            x.namcap = (int)this.year.Value;
            x.matinh = (this.sl_DoiA.SelectedItem as Models.TinhThanh).matinh;
            x.insert();
            this.cancel_Click(sender, e);
            this.LoadData();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.provinceSearch.ResetText();
            this.kinhphi.ResetText();
            this.year.ResetText();
        }

        private void provinceSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matinh = (this.provinceSearch.SelectedItem as Models.TinhThanh).matinh;
                       CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[this.data.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow item in this.data.Rows)
            {
                Models.TranDau i = (item.DataBoundItem as Models.TranDau);
                if (i.matinh != matinh)
                    item.Visible = false;
                else
                    item.Visible = true;
                if (matinh == 0)
                {
                    item.Visible = true;
                }
            }
            currencyManager1.ResumeBinding();
        }
    }
}
