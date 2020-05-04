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
    public partial class Thaydoiquydinh : Form
    {
        BLL.QuydinhBLL busQuydinh;
        SanbayBLL busSanbay;
        BLL.HangveBLL busHangve;
        int soluong;
        public Thaydoiquydinh()
        {
            InitializeComponent();
        }

        public void Thaydoiquydinh_Load(object sender, EventArgs e)
        {
            busQuydinh = new BLL.QuydinhBLL();
            busSanbay = new SanbayBLL();
            busHangve = new BLL.HangveBLL();
            DataTable chitiet = busQuydinh.GetAllQuydinh();

            if (chitiet.Rows.Count > 0)
            {
                DataRow row = chitiet.Rows[0];

                this.textBox_tgbaytt.Text = row["TGBAYTOITHIEU"].ToString();
                this.textBox_sbtgtd.Text = row["SOSBTRUNGGIANTOIDA"].ToString();
                this.textBox_tgdungtt.Text = row["TGDUNGTOITHIEU"].ToString();
                this.textBox_ttdungtd.Text = row["TGDUNGTOIDA"].ToString();
                this.textBox_tghuydv.Text = row["TGCHAMNHATHUYVE"].ToString();
                this.textBox_tgchamnhatdv.Text = row["TGCHAMNHATDATVE"].ToString();
                this.label_sbtd.Text = row["SLSANBAYTOIDA"].ToString();
                //this.label_slhv.Text = row["SLHANGVE"].ToString();

                this.textBox_changeslsb.Text = "";
                this.label_slhv.Text = RefreshSoluongHV();
            }

        }

        

        private void button_update_Click(object sender, EventArgs e)
        {
            DTO.Quydinh dto = new DTO.Quydinh(int.Parse(textBox_tgbaytt.Text), int.Parse(textBox_sbtgtd.Text), int.Parse(textBox_tgdungtt.Text), int.Parse(textBox_ttdungtd.Text), int.Parse(textBox_tgchamnhatdv.Text), int.Parse(textBox_tghuydv.Text), int.Parse(label_slhv.Text), int.Parse(label_sbtd.Text));

            if (busQuydinh.UpdateQuydinh(dto))
            {
                MessageBox.Show("Thay đổi quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thaydoiquydinh_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, thay đổi quy định thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            
        }

        private void button_slsanbaytd_Click(object sender, EventArgs e)
        {
            if (textBox_changeslsb.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sân bay tối đa muốn thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(label_sbtd.Text) <= int.Parse(textBox_changeslsb.Text))
            {
                DTO.Quydinh dto = new DTO.Quydinh(int.Parse(textBox_tgbaytt.Text), int.Parse(textBox_sbtgtd.Text), int.Parse(textBox_tgdungtt.Text), int.Parse(textBox_ttdungtd.Text), int.Parse(textBox_tgchamnhatdv.Text), int.Parse(textBox_tghuydv.Text), 0, int.Parse(textBox_changeslsb.Text));
                busQuydinh.UpdateSanBayTD(dto);
                Thaydoiquydinh_Load(sender,e);
            }
            else
            {
                
                DataTable dtSanBay = busSanbay.GetSL_SB_Hoat_Dong();
                if (dtSanBay.Rows.Count > 0)
                {
                    soluong = int.Parse(dtSanBay.Rows[0]["SL"].ToString());
                }

                if (soluong <= int.Parse(textBox_changeslsb.Text))
                {
                    DTO.Quydinh dto = new DTO.Quydinh(int.Parse(textBox_tgbaytt.Text), int.Parse(textBox_sbtgtd.Text), int.Parse(textBox_tgdungtt.Text), int.Parse(textBox_ttdungtd.Text), int.Parse(textBox_tgchamnhatdv.Text), int.Parse(textBox_tghuydv.Text), 0, int.Parse(textBox_changeslsb.Text));
                    busQuydinh.UpdateSanBayTD(dto);
                    Thaydoiquydinh_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Để giảm số lượng sân bay tối đa bạn cần xóa bớt sân bay ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    QL_Sanbay frm = new QL_Sanbay(soluong- int.Parse(textBox_changeslsb.Text));
                    frm.UIParent = this;
                    //show dialog
                    frm.ShowDialog();
                }
                
               
                
            }

        }


        public void UpdateSoluongSB()
        {
            DTO.Quydinh dto = new DTO.Quydinh(int.Parse(textBox_tgbaytt.Text), int.Parse(textBox_sbtgtd.Text), int.Parse(textBox_tgdungtt.Text), int.Parse(textBox_ttdungtd.Text), int.Parse(textBox_tgchamnhatdv.Text), int.Parse(textBox_tghuydv.Text), 0, int.Parse(textBox_changeslsb.Text));
            busQuydinh.UpdateSanBayTD(dto);
            Thaydoiquydinh_Load(null,null);

        }

        public string RefreshSoluongHV()
        {
            DataTable dt = busHangve.Count_SLHV();
            DataRow row = dt.Rows[0];


            return (dt.Rows[0]["SL"].ToString());
        }

        public void UpdateSoluongHV()
        {
            DTO.Quydinh dto = new DTO.Quydinh(int.Parse(textBox_tgbaytt.Text), int.Parse(textBox_sbtgtd.Text), int.Parse(textBox_tgdungtt.Text), int.Parse(textBox_ttdungtd.Text), int.Parse(textBox_tgchamnhatdv.Text), int.Parse(textBox_tghuydv.Text), int.Parse(RefreshSoluongHV()), 0);
            busQuydinh.Update_SL_HangveHienTai(dto);
            Thaydoiquydinh_Load(null, null);

        }


        private void button_slhangve_Click(object sender, EventArgs e)
        {
            QL_Hangve frm = new QL_Hangve();
            frm.UIParent = this;
            frm.ShowDialog();


        }

        private void textBox_tgbaytt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_sbtgtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_tgdungtt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ttdungtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_tghuydv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_tgchamnhatdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_changeslsb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
