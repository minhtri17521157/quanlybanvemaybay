using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class QL_Sanbay : Form
    {
        SanbayBLL bllSB;
        //DataConnection dc;
        int sl_canxoa;
        bool trigger = false;
        public QL_Sanbay()
        {
            InitializeComponent();
            bllSB = new SanbayBLL();
            label_realslcanxoa.Visible = false;
            label_slcanxoa.Visible = false;
            trigger = true;
            sl_canxoa = -1;
        }

        public QL_Sanbay(int slcanxoa)
        {
            
            InitializeComponent();
            bllSB = new SanbayBLL();
            this.sl_canxoa = slcanxoa;
            button_Add.Visible = false;
            button_Add.Enabled = false;
            button_Update.Visible = false;
            button_Update.Enabled = false;

        }

        public object UIParent
        {
            set;
            get;
        }




        public void ShowAllSanbay()
        {
            DataTable dt = bllSB.getAllSanbay();
            dataGridView_Sanbay.DataSource = dt;
        }

        public void ShowSB_HoatDong()
        {
            DataTable dt = bllSB.getallSanbay_hoatdong();
            dataGridView_Sanbay.DataSource = dt;
            //DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            //checkColumn.Name = "select";
            //checkColumn.HeaderText = "Chọn";
            //checkColumn.Width = 50;
            //checkColumn.ReadOnly = false;
            //checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            //dataGridView_Sanbay.Columns.Add(checkColumn);
            //dataGridView_Sanbay.Columns["select"].DisplayIndex = 0;
        }

        private void QL_Sanbay_Load(object sender, EventArgs e)
        {
            if (sl_canxoa == -1)
            {
                
                button_Add.Visible = true;
                button_Add.Enabled = true;
                button_Update.Visible = true;
                button_Update.Enabled = true;
                ShowAllSanbay();
            }
            else
            {
                ShowSB_HoatDong();
                label_realslcanxoa.Text = sl_canxoa.ToString();
            }
        }

        private bool CheckData()
        {
            //if (string.IsNullOrEmpty(textBox_masb.Text) || string.IsNullOrEmpty(textBox_tensb.Text))
            if (string.IsNullOrEmpty(textBox_tensb.Text) ||string.IsNullOrEmpty(comboBox_hd.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_masb.Focus(); //để con trỏ vào đây
                return false;
            }
            return true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
           
            if (CheckData())
            {
                Sanbay sb = new Sanbay();
                //sb.masb = textBox_masb.Text;
                sb.tensb = textBox_tensb.Text;
                sb.tinhtrang = comboBox_hd.Text;
                
                if (bllSB.InsertSanbay(sb))
                {
                    ShowAllSanbay();
                    textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tensb.Clear();                
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataGridView_Sanbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //_ID = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                textBox_masb.Text = dataGridView_Sanbay.Rows[index].Cells["Mã sân bay"].Value.ToString();
                textBox_tensb.Text = dataGridView_Sanbay.Rows[index].Cells["Tên sân bay"].Value.ToString();
                comboBox_hd.Text = dataGridView_Sanbay.Rows[index].Cells["Tình trạng"].Value.ToString();
            }
        }



        private void button_Update_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Sanbay sb = new Sanbay();

                sb.tensb = textBox_tensb.Text;
                sb.masb = textBox_masb.Text;
                sb.tinhtrang = comboBox_hd.Text;
          

                if (bllSB.UpdateSanbay(sb))
                {
                    ShowAllSanbay();
                    textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tensb.Clear();

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //--------------- MINH CHINH SUA

            //int total = dataGridView_Sanbay.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["select"].Value) == true).Count();
            //if (total > 0)
            //{
            //    for (int i = dataGridView_Sanbay.RowCount - 1; i >= 0; i--)
            //    {
            //        DataGridViewRow row = dataGridView_Sanbay.Rows[i];
            //        if (Convert.ToBoolean(row.Cells["select"].Value) == true)
            //        {
            //            dataGridView_Sanbay.Rows.Remove(row);
            //        }
            //    }
            //}



            //--------------






            if (MessageBox.Show("Bạn có chắc chắn muốn xóa những sân bay này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sanbay sb = new Sanbay();
                
                foreach (DataGridViewRow row in dataGridView_Sanbay.SelectedRows)
                {
                   
                    //sb.id = _ID;

                    sb.masb = row.Cells[0].Value.ToString();
                    if (bllSB.DeleteSanbay(sb))
                    {
                        sl_canxoa -= 1;
                        //ShowAllSanbay();
                        textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                        textBox_tensb.Clear();
                    }
                    else
                        MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (sl_canxoa == -1)
                {
                    ShowAllSanbay();
                }
                else
                {
                    if (trigger != true)
                    {
                        ShowSB_HoatDong();
                    }
                    else
                    {
                        ShowAllSanbay();
                    }
                    if (sl_canxoa == 0)
                    {
                        button_Delete.Enabled = false;

                        if (MessageBox.Show("Cập nhật số lượng sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            if (UIParent is Thaydoiquydinh)
                            {
                                Thaydoiquydinh frm = UIParent as Thaydoiquydinh;
                                frm.UpdateSoluongSB();
                                
                            }
                            
                            this.Dispose();

                            
                        }
                    }
                }
                


            }
        }

      

        private void dataGridView_Sanbay_SelectionChanged(object sender, EventArgs e)
        {
            if (trigger != true)
            {
                if (dataGridView_Sanbay.SelectedRows.Count > 0)
                {
                    //label_realslcanxoa.Text = (sl_canxoa - dataGridView_Sanbay.SelectedRows.Count).ToString();
                    if (dataGridView_Sanbay.SelectedRows.Count > sl_canxoa)
                    {
                        label_realslcanxoa.Text = "";
                        if (button_Delete.Enabled == true)
                        {
                            MessageBox.Show("Bạn đã chọn nhiều hơn số sân bay cần xóa, vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        dataGridView_Sanbay.ClearSelection();
                        label_realslcanxoa.Text = sl_canxoa.ToString();

                    }
                }
            }

        }
    }
}
