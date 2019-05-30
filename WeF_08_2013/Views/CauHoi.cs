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
    public partial class CauHoi : UserControl
    {
        private bool isEdit = false;

        public CauHoi()
        {
            InitializeComponent();
            LoadData();
            LoadTinh();
        }

        private void LoadData()
        {
            List<Models.CauHoi> l = Controller.CauHoi.get();
            this.data.DataSource = l;
            this.data.Columns[0].HeaderText = "Mã";
            this.data.Columns[1].HeaderText = "Tên hoạt động";
            this.data.Columns[2].HeaderText = "Kinh Phí";
            this.data.Columns[3].HeaderText = "Bắt đầu";
            this.data.Columns[4].HeaderText = "Kết thúc";
            this.data.Columns[5].HeaderText = "Ngân sách";
            this.data.Columns[6].HeaderText = "Tên tỉnh";
        }

        private void LoadTinh()
        {
            List<Models.TinhThanh> l = Controller.TinhThanh.get();
            l.Add(new Models.TinhThanh(0, "Tất cả"));
            this.province.DataSource = l;
            this.province.DisplayMember = "tentinh";
        }

        private bool check()
        {
            if (
                this.tenhd.TextLength > 0 &&
                this.kinhphi.TextLength > 0 &&
                this.idNganSach.TextLength > 0
            )
                return true;
            return false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Models.CauHoi x = new Models.CauHoi();
            if (!check())
            {
                MessageBox.Show("Bạn chưa nhập hết dữ liệu!");
                return;
            }
            x.tenhd = this.tenhd.Text.Trim();
            x.ngaybd = this.start.Value;
            x.ngaykt = this.end.Value;
            x.kinhphi = Convert.ToInt32(this.kinhphi.Text.Trim());
            x.mans = Convert.ToInt32(this.idNganSach.Text.Trim());
            if (this.isEdit)
            {
                x.mahd = ((Models.CauHoi)this.data.CurrentRow.DataBoundItem).mahd;
                if (!x.update())
                {
                    MessageBox.Show("Mã ngân sách không tồn tại!");
                    return;
                }
            }
            else
            {
                if (!x.insert()){
                    MessageBox.Show("Mã ngân sách không tồn tại!");
                    return;
                }
            }
            this.cancel_Click(sender, e);
            this.LoadData();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.isEdit = false;
            this.submit.Text = "Thêm";
            this.tenhd.ResetText();
            this.start.ResetText();
            this.idNganSach.ResetText();
            this.kinhphi.ResetText();
            this.end.ResetText();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn muốn xóa hoạt động này?", "Xác nhận?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (confirm == DialogResult.Yes)
            {
                Models.CauHoi x = new Models.CauHoi();
                x.mahd = ((Models.CauHoi)this.data.CurrentRow.DataBoundItem).mahd;
                x.delete();
                this.cancel_Click(sender, e);
                this.LoadData();
            }
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data.CurrentRow;
            if (!row.IsNewRow)
            {
                Models.CauHoi x = (Models.CauHoi)this.data.CurrentRow.DataBoundItem;
                this.isEdit = true;
                this.submit.Text = "Sửa";
                this.tenhd.Text = x.tenhd;
                this.start.Value = x.ngaybd ;
                this.idNganSach.Text = x.mans.ToString();
                this.kinhphi.Text = x.kinhphi.ToString();
                this.end.Value = x.ngaykt;
            }
        }

        private void province_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tentinh = (this.province.SelectedItem as Models.TinhThanh).tentinh;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[this.data.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow item in this.data.Rows)
            {
                Models.CauHoi i = (item.DataBoundItem as Models.CauHoi);
                if (i.tentinh != tentinh)
                    item.Visible = false;
                else
                    item.Visible = true;
                if (tentinh == "Tất cả")
                {
                    item.Visible = true;
                }
            }
            currencyManager1.ResumeBinding();
        }
    }
}
