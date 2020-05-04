using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Sanbay frmSanbay = new QL_Sanbay();
            frmSanbay.ShowDialog();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {

            label_time.Text = DateTime.Now.ToString("HH:mm");
            label_time2.Text = DateTime.Now.ToString("ss");
            label_date.Text = DateTime.Now.ToString("MMMM dd yyyy");
            label_day.Text = DateTime.Now.ToString("dddd");

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            timerClock.Start();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nhậnLịchChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NhanLichChuyenBay frm = new NhanLichChuyenBay();
            frm.ShowDialog();
        }

        private void bánVéĐặtVéTraCứuChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banve frm = new Banve();
            frm.ShowDialog();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thaydoiquydinh frm = new Thaydoiquydinh();
            frm.ShowDialog();
        }

        private void báoCáoDoanhThuThángChuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao_Thang frm = new Baocao_Thang();
            frm.ShowDialog();
        }

        private void báoCáoDoanhThuNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao_Nam frm = new Baocao_Nam();
            frm.ShowDialog();
        }

        private void quảnLýSânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Sanbay frm = new QL_Sanbay();
            frm.ShowDialog();
        }

        private void quảnLýHạngVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Hangve frm = new QL_Hangve();
            frm.ShowDialog();
        }

        private void menuStrip_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
