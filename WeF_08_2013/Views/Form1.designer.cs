namespace WeF_08_2013
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.trandauMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doithiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trandauMenu,
            this.doithiMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1008, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // trandauMenu
            // 
            this.trandauMenu.Name = "trandauMenu";
            this.trandauMenu.Size = new System.Drawing.Size(67, 20);
            this.trandauMenu.Text = "Trận Đấu";
            this.trandauMenu.Click += new System.EventHandler(this.diadanhMenu_Click);
            // 
            // doithiMenu
            // 
            this.doithiMenu.Name = "doithiMenu";
            this.doithiMenu.Size = new System.Drawing.Size(57, 20);
            this.doithiMenu.Text = "Đội Thi";
            this.doithiMenu.Click += new System.EventHandler(this.ngansachMenu_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Location = new System.Drawing.Point(0, 27);
            this.mainContainer.MaximumSize = new System.Drawing.Size(1008, 534);
            this.mainContainer.MinimumSize = new System.Drawing.Size(1008, 534);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.SelectedIndex = 0;
            this.mainContainer.Size = new System.Drawing.Size(1008, 534);
            this.mainContainer.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTab});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 26);
            // 
            // closeTab
            // 
            this.closeTab.Name = "closeTab";
            this.closeTab.Size = new System.Drawing.Size(165, 22);
            this.closeTab.Text = "Đóng tab hiện tại";
            this.closeTab.Click += new System.EventHandler(this.closeTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siêu Trí Tuệ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem trandauMenu;
        private System.Windows.Forms.ToolStripMenuItem doithiMenu;
        private System.Windows.Forms.TabControl mainContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeTab;
    }
}

