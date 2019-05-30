using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeF_08_2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void addTab(UserControl uct, byte typeControl, string name)
        {
            foreach(TabPage i in mainContainer.TabPages)
            {
                if (i.Name == uct.Name)
                {
                    mainContainer.SelectedTab = i;
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = mainContainer.Size;
            tab.Text = name;
            mainContainer.TabPages.Add(tab);
            mainContainer.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void diadanhMenu_Click(object sender, EventArgs e)
        {
           addTab(new Views.TranDau(), 4, "Trận Đấu");
        }

        private void closeTab_Click(object sender, EventArgs e)
        {
            if(mainContainer.TabCount>0)
            mainContainer.TabPages.Remove(mainContainer.SelectedTab);
        }

        private void ngansachMenu_Click(object sender, EventArgs e)
        {
            
            //addTab(new Views.Doi(), 4, "Ngân sách");
        }

    }
}
