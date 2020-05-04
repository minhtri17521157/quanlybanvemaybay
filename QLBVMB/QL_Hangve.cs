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
    public partial class QL_Hangve : Form
    {
        BLL.HangveBLL bllHV;

        public QL_Hangve()
        {
            InitializeComponent();
            bllHV = new BLL.HangveBLL();
        }

        public object UIParent
        {
            set;
            get;
        }

        public void ShowAll_Hangve()
        {
            DataTable dt = bllHV.GetForDisplay();
            dataGridView_hangve.DataSource = dt;
        }

        private void QL_Hangve_Load(object sender, EventArgs e)
        {
            ShowAll_Hangve();
        }

        private void dataGridView_hangve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //_ID = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                textBox_mahv.Text = dataGridView_hangve.Rows[index].Cells["Mã hạng vé"].Value.ToString();
                textBox_tenhv.Text = dataGridView_hangve.Rows[index].Cells["Tên hạng vé"].Value.ToString();
                comboBox_tinhtrang.Text = dataGridView_hangve.Rows[index].Cells["Tình trạng"].Value.ToString();
                textBox_tyle.Text = dataGridView_hangve.Rows[index].Cells["Tỷ lệ (%)"].Value.ToString();
            }
        }


        private bool CheckData()
        {
            //if (string.IsNullOrEmpty(textBox_masb.Text) || string.IsNullOrEmpty(textBox_tensb.Text))
            if (string.IsNullOrEmpty(textBox_tenhv.Text)|| string.IsNullOrEmpty(comboBox_tinhtrang.Text)|| string.IsNullOrEmpty(textBox_tyle.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_mahv.Focus(); //để con trỏ vào đây
                return false;
            }
            return true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTO.Hangve hv = new DTO.Hangve();
                //sb.masb = textBox_masb.Text;
                hv.tenhv = textBox_tenhv.Text;
                hv.tyle = int.Parse(textBox_tyle.Text);
                hv.tinhtrang = comboBox_tinhtrang.Text;

                if (bllHV.InsertHangve(hv))
                {
                    MessageBox.Show("Thêm hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (UIParent is Thaydoiquydinh)
                    {
                        Thaydoiquydinh frm = UIParent as Thaydoiquydinh;
                        frm.Thaydoiquydinh_Load(null, null);

                    }
                    ShowAll_Hangve();
                    textBox_mahv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tenhv.Clear();
                    textBox_tyle.Clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            
            if (CheckData())
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa những hạng vé này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DTO.Hangve hv = new DTO.Hangve();
                    int check=-1;
                    foreach (DataGridViewRow row in dataGridView_hangve.SelectedRows)
                    {

                        hv.mahv = row.Cells[0].Value.ToString();
                        if (bllHV.DeleteHangve(hv))
                        {
                            check = 1;
                            //QL_Hangve_Load(null, null);
                            
                            if (UIParent is Thaydoiquydinh)
                            {
                                Thaydoiquydinh frm = UIParent as Thaydoiquydinh;
                                frm.Thaydoiquydinh_Load(null, null);

                            }
                            //ShowAll_Hangve();
                            textBox_mahv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                            textBox_tenhv.Clear();
                            textBox_tyle.Clear();
                        }
                        else
                        {
                            check = 0;
                            MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("Xóa hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }    
              
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                
                if (bllHV.UpdateHangve(textBox_mahv.Text,textBox_tenhv.Text,comboBox_tinhtrang.Text,textBox_tyle.Text))
                {
                    //QL_Hangve_Load(null, null);
                    MessageBox.Show("Cập nhật hạng vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (UIParent is Thaydoiquydinh)
                    {
                        Thaydoiquydinh frm = UIParent as Thaydoiquydinh;
                        frm.Thaydoiquydinh_Load(null,null); 

                    }
                    ShowAll_Hangve();
                    textBox_mahv.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tenhv.Clear();
                    textBox_tyle.Clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void textBox_tyle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
