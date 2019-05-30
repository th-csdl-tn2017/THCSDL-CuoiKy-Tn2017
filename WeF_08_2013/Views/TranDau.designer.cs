namespace WeF_08_2013.Views
{
    partial class TranDau
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data = new System.Windows.Forms.DataGridView();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.addedit = new System.Windows.Forms.Panel();
            this.sl_DoiA = new System.Windows.Forms.ComboBox();
            this.lb_DoiA = new System.Windows.Forms.Label();
            this.lb_TaoTranDau = new System.Windows.Forms.Label();
            this.lb_DanhSachTrandau = new System.Windows.Forms.Label();
            this.lb_DoiB = new System.Windows.Forms.Label();
            this.sl_DoiB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.addedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(234, 51);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(774, 483);
            this.data.TabIndex = 3;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(145, 181);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(16, 181);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(75, 23);
            this.btn_Tao.TabIndex = 4;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.submit_Click);
            // 
            // addedit
            // 
            this.addedit.Controls.Add(this.sl_DoiB);
            this.addedit.Controls.Add(this.lb_DoiB);
            this.addedit.Controls.Add(this.sl_DoiA);
            this.addedit.Controls.Add(this.lb_DoiA);
            this.addedit.Controls.Add(this.btn_Huy);
            this.addedit.Controls.Add(this.btn_Tao);
            this.addedit.Controls.Add(this.lb_TaoTranDau);
            this.addedit.Dock = System.Windows.Forms.DockStyle.Left;
            this.addedit.Location = new System.Drawing.Point(0, 0);
            this.addedit.Name = "addedit";
            this.addedit.Size = new System.Drawing.Size(234, 534);
            this.addedit.TabIndex = 2;
            // 
            // sl_DoiA
            // 
            this.sl_DoiA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_DoiA.FormattingEnabled = true;
            this.sl_DoiA.Location = new System.Drawing.Point(90, 84);
            this.sl_DoiA.Name = "sl_DoiA";
            this.sl_DoiA.Size = new System.Drawing.Size(130, 21);
            this.sl_DoiA.TabIndex = 10;
            // 
            // lb_DoiA
            // 
            this.lb_DoiA.AutoSize = true;
            this.lb_DoiA.Location = new System.Drawing.Point(13, 87);
            this.lb_DoiA.Name = "lb_DoiA";
            this.lb_DoiA.Size = new System.Drawing.Size(33, 13);
            this.lb_DoiA.TabIndex = 9;
            this.lb_DoiA.Text = "Đội A";
            // 
            // lb_TaoTranDau
            // 
            this.lb_TaoTranDau.AutoSize = true;
            this.lb_TaoTranDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaoTranDau.Location = new System.Drawing.Point(43, 25);
            this.lb_TaoTranDau.Name = "lb_TaoTranDau";
            this.lb_TaoTranDau.Size = new System.Drawing.Size(118, 20);
            this.lb_TaoTranDau.TabIndex = 2;
            this.lb_TaoTranDau.Text = "Tạo Trận Đấu";
            // 
            // lb_DanhSachTrandau
            // 
            this.lb_DanhSachTrandau.AutoSize = true;
            this.lb_DanhSachTrandau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DanhSachTrandau.Location = new System.Drawing.Point(548, 15);
            this.lb_DanhSachTrandau.Name = "lb_DanhSachTrandau";
            this.lb_DanhSachTrandau.Size = new System.Drawing.Size(167, 20);
            this.lb_DanhSachTrandau.TabIndex = 2;
            this.lb_DanhSachTrandau.Text = "Danh sách trận đấu";
            // 
            // lb_DoiB
            // 
            this.lb_DoiB.AutoSize = true;
            this.lb_DoiB.Location = new System.Drawing.Point(13, 125);
            this.lb_DoiB.Name = "lb_DoiB";
            this.lb_DoiB.Size = new System.Drawing.Size(33, 13);
            this.lb_DoiB.TabIndex = 9;
            this.lb_DoiB.Text = "Đội B";
            // 
            // sl_DoiB
            // 
            this.sl_DoiB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sl_DoiB.FormattingEnabled = true;
            this.sl_DoiB.Location = new System.Drawing.Point(90, 122);
            this.sl_DoiB.Name = "sl_DoiB";
            this.sl_DoiB.Size = new System.Drawing.Size(130, 21);
            this.sl_DoiB.TabIndex = 10;
            // 
            // TranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data);
            this.Controls.Add(this.addedit);
            this.Controls.Add(this.lb_DanhSachTrandau);
            this.MaximumSize = new System.Drawing.Size(1008, 534);
            this.MinimumSize = new System.Drawing.Size(1008, 534);
            this.Name = "TranDau";
            this.Size = new System.Drawing.Size(1008, 534);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.addedit.ResumeLayout(false);
            this.addedit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.Panel addedit;
        private System.Windows.Forms.Label lb_TaoTranDau;
        private System.Windows.Forms.Label lb_DanhSachTrandau;
        private System.Windows.Forms.ComboBox sl_DoiA;
        private System.Windows.Forms.Label lb_DoiA;
        private System.Windows.Forms.ComboBox sl_DoiB;
        private System.Windows.Forms.Label lb_DoiB;
    }
}
