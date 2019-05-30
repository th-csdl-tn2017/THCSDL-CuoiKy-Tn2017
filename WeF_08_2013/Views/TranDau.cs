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
            this.LoadDoiA();
            this.LoadDoiB();
        }

        private void LoadData()
        {
            List<Models.TranDau> l = Controllers.TranDau.get();
            this.data.DataSource = l;
            this.data.Columns[0].HeaderText = "Mã trận";
            this.data.Columns[1].HeaderText = "Đội 1";
            this.data.Columns[2].HeaderText = "Đội 2";
            this.data.Columns[3].HeaderText = "Ngày đấu";
        }

        private void LoadDoiA()
        {
            List<Models.Doi> l = Controllers.Doi.get();
            this.sl_DoiA.DataSource = l;
            this.sl_DoiA.DisplayMember = "tendoi";
        }
        private void LoadDoiB()
        {
            List<Models.Doi> l = Controllers.Doi.get();
            this.sl_DoiB.DataSource = l;
            this.sl_DoiB.DisplayMember = "tendoi";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Models.TranDau x = new Models.TranDau();
            x.doiA = (this.sl_DoiA.SelectedItem as Models.Doi).id_doi;
            x.doiB = (this.sl_DoiB.SelectedItem as Models.Doi).id_doi;
            x.insert();
            this.LoadData();
        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data.CurrentRow;
            if (!row.IsNewRow)
            {
                Models.TranDau x = (Models.TranDau)this.data.CurrentRow.DataBoundItem;
                new VongDau(x.id_tran).Show();
            }
        }
    }
}
