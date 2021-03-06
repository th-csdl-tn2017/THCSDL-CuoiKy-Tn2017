﻿using System;
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
    public partial class VongDau : Form
    {
 
        private int id_tran;
        public VongDau(int id_tran)
        {
            InitializeComponent();
            this.id_tran = id_tran;
            LoadData();
        }

        private void LoadData()
        {
            List<Models.VongDau> l = Controllers.VongDau.get(id_tran);
            this.data.DataSource = l;
            this.data.Columns[0].HeaderText = "Mã";
            this.data.Columns[1].Visible = false;
            this.data.Columns[2].HeaderText = "Vòng";
            this.data.Columns[3].HeaderText = "Điểm đội thắng";
            this.data.Columns[4].HeaderText = "Mã đội thắng";
        }


        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = data.CurrentRow;
            if (!row.IsNewRow)
            {
                Models.VongDau x = (Models.VongDau)this.data.CurrentRow.DataBoundItem;
                new CauHoi(x.id_vongdau).Show();
            }
        }

    }
}
