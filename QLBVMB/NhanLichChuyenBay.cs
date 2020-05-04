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
    public partial class NhanLichChuyenBay : Form
    {
        DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter da;
        DTO.Chuyenbay dtoChuyenBay;
        DTO.Quydinh dtoQuyDinh;
        DTO.Tinhtrangve dtoTinhtrangve;
      

       
        DTO.Chitietchuyenbay dtoChitietchuyenbay;

        BLL.QuydinhBLL busQuyDinh;
        ChuyenbayBLL busChuyenbay;
        BLL.ChitietchuyenbayBLL busChitietchuyenbay;
        BLL.TinhtrangveBLL busTinhtrangve;
        BLL.HangveBLL busHangve;
        int trigger = -1;

        public NhanLichChuyenBay()
        {
            InitializeComponent();
            dc = new DataConnection();
            busQuyDinh = new BLL.QuydinhBLL();
            busChuyenbay = new ChuyenbayBLL();
            busChitietchuyenbay = new BLL.ChitietchuyenbayBLL();
            busTinhtrangve = new BLL.TinhtrangveBLL();
            busHangve = new BLL.HangveBLL();

            dtoQuyDinh = new DTO.Quydinh(0,0,0,0,0,0,0,0);
            dtoChuyenBay = new DTO.Chuyenbay("0","0",DateTime.Now,1,"0");
            dtoChitietchuyenbay = new DTO.Chitietchuyenbay("", "", "", 0, "");
            dtoTinhtrangve = new DTO.Tinhtrangve("","","",0,0,0);
            

            busQuyDinh.Get_Infor(dtoQuyDinh);
           
        }

       

        private void NhanLichChuyenBay_Load(object sender, EventArgs e)
        {
            
           

            trigger = 0;
            ShowComboBoxListSanBay(comboBox_sbdi);
            ShowComboBoxListSanBay(comboBox_sbden);
            ShowComboBoxListSanBay(comboBox_sb_trung_gian);
            Show_Hang_Ve(comboBox_hangve);
            String.Format("{0:n0}", comboBox_giave.Text);
            Show_Gia_Ve(comboBox_giave);
            decimal value = Convert.ToDecimal((comboBox_giave.Text).ToString());
            String.Format("{0:n0}", comboBox_giave.Text);
            textBox_macb.Text = TaoMaChuyenBay();
            comboBox_sbden.SelectedValue = 2;

            //pictureBox_check.Visible = false;
            //label_tuyenbay_khadung.Visible = false;

        }


        public void ShowComboBoxListSanBay(ComboBox sbay)
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from SANBAY WHERE TINHTRANG=N'Hoạt động'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            sbay.DataSource = table;
            sbay.DisplayMember = "TENSANBAY";
            sbay.ValueMember = "MASB";

        }

        public void Show_Hang_Ve(ComboBox cb)
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from HANGVE WHERE TINHTRANG=N'Khả dụng'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cb.DataSource = table;
            cb.DisplayMember = "TENHV";
            cb.ValueMember = "MAHV";

        }

        public void Show_Gia_Ve(ComboBox cb)
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from DONGIA", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);


            



            cb.DataSource = table;
            //cb.DisplayMember = "DONGIA";
            cb.DisplayMember = "DONGIA";
            cb.ValueMember = "MADG";

        }

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT* FROM CHUYENBAY ORDER BY MACB DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaChuyenBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "CB000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maChuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maChuyenBay) + 1;
            int temp = count;
            string strSoKhong = "";
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 4 - dem; i++)
            {
                strSoKhong += "0";
            }
            return "CB" + strSoKhong + count;
        }

        private void textBox_thoigiandung_TextChanged(object sender, EventArgs e)
        {
            if(textBox_thoigiandung.Text == null||textBox_thoigiandung.Text=="")
            {
                return;
            }
            if ((int.Parse(textBox_thoigiandung.Text) < dtoQuyDinh.tgdungtoithieu || int.Parse(textBox_thoigiandung.Text) > dtoQuyDinh.tgdungtoida) )
            {
                label_note.ForeColor = Color.Red;
                label_note.Text = "*Thời gian dừng phải lớn hơn hoặc bằng " + dtoQuyDinh.tgdungtoithieu + " phút và nhỏ hơn hoặc bằng " + dtoQuyDinh.tgdungtoida + " phút!";
            }
            else
            {
                label_note.Text = "";
            }
        }

        private void textBox_thoigianbay_TextChanged(object sender, EventArgs e)
        {
            if (textBox_thoigianbay.Text == null || textBox_thoigianbay.Text == "")
            {
                return;
            }
            if (int.Parse(textBox_thoigianbay.Text) < dtoQuyDinh.tgbaytoithieu)
            {
                label_note_tgbay.ForeColor = Color.Red;
                label_note_tgbay.Text = "*Thời gian bay tối thiểu là " + dtoQuyDinh.tgbaytoithieu + " phút!";
            }
            else
            {
                label_note_tgbay.Text = "";
            }
        }

       

        private void textBox_note_ghichu_TextChanged(object sender, EventArgs e)
        {

            if (textBox_note_ghichu.Text == null || textBox_note_ghichu.Text == "")
            {
                return;
            }
            if (textBox_note_ghichu.Text.Length>=100)
            {

                label_ghichu_note.ForeColor = Color.Red;
                label_ghichu_note.Text = "*Ghi chú chỉ chứa tối đa 100 ký tự!";
            }
            else
            {
                label_ghichu_note.Text = "";
            }

        }

        private void button_them_sb_tg_Click(object sender, EventArgs e)
        {
            if (dataGridView_sbtrunggian.Rows.Count+1 > int.Parse(busQuyDinh.Get_So_Sanbay_TG_toida()))
            {
                MessageBox.Show(string.Format("Số lượng sân bay trung gian tối đa quy định là {0}", busQuyDinh.Get_So_Sanbay_TG_toida()), "Results", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
                
            }


            if(comboBox_sbdi.Text==comboBox_sbden.Text)
            {

                MessageBox.Show("Sân bay đi và sân bay đến bị trùng xin vui lòng chọn lại trước khi thêm sân bay trung gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
            foreach (DataGridViewRow row in dataGridView_sbtrunggian.Rows)
            {
               
                if (comboBox_sb_trung_gian.Text == row.Cells[2].Value.ToString())
                {
                    MessageBox.Show("Sân bay trung gian đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
            }


            if (comboBox_sb_trung_gian.Text == comboBox_sbdi.Text || comboBox_sb_trung_gian.Text == comboBox_sbden.Text)
            {
                MessageBox.Show("Sân bay trung gian phải khác sân bay đến và sân bay đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox_thoigiandung.Text == "")
            {
                MessageBox.Show("Chưa nhập thời gian dừng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((int.Parse(textBox_thoigiandung.Text) < dtoQuyDinh.tgdungtoithieu || int.Parse(textBox_thoigiandung.Text) > dtoQuyDinh.tgdungtoida))
            {
                MessageBox.Show("Thời gian dừng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (textBox_note_ghichu.Text == "")
            //{
            //    MessageBox.Show("Thời gian dừng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            else
            {


                int index = dataGridView_sbtrunggian.Rows.Add();

                dataGridView_sbtrunggian.Rows[index].Cells[1].Value = index + 1;
                dataGridView_sbtrunggian.Rows[index].Cells[2].Value = comboBox_sb_trung_gian.Text;
                dataGridView_sbtrunggian.Rows[index].Cells[3].Value = textBox_thoigiandung.Text;
                dataGridView_sbtrunggian.Rows[index].Cells[4].Value = textBox_note_ghichu.Text;

                textBox_note_ghichu.Text = "";
                textBox_thoigiandung.Text = "";
                
            }

        }


        private void button_xoa_sb_tg_Click(object sender, EventArgs e)
        {

            int total = dataGridView_sbtrunggian.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["select"].Value) == true).Count();
            if (total > 0)
            {
                for (int i = dataGridView_sbtrunggian.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView_sbtrunggian.Rows[i];
                    if (Convert.ToBoolean(row.Cells["select"].Value) == true)
                    {
                        dataGridView_sbtrunggian.Rows.Remove(row);
                    }
                }
            }
        }

       

        private void textBox_thoigiandung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_thoigianbay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void button_them_hv_Click(object sender, EventArgs e)
        {

            if (textBox_slghe.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (DataGridViewRow row in dataGridView_hangve.Rows)
            {
     
                if (comboBox_hangve.Text == row.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Hạng vé đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }

            if (textBox_slghe.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            int index = dataGridView_hangve.Rows.Add();

                dataGridView_hangve.Rows[index].Cells[1].Value = comboBox_hangve.Text;
                dataGridView_hangve.Rows[index].Cells[2].Value = textBox_slghe.Text;
             

                textBox_slghe.Text = "";
               

            
        }

        private void button_xoa_hangghe_Click(object sender, EventArgs e)
        {
            int total = dataGridView_hangve.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["chon"].Value)==true).Count();
            if (total > 0)
            {
                for (int i = dataGridView_hangve.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView_hangve.Rows[i];
                    if (Convert.ToBoolean(row.Cells["chon"].Value) == true)
                    {
                        dataGridView_hangve.Rows.Remove(row);
                    }
                }
            }

        }



        public static DataTable ToDataTable<T>(IList<T> list)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            return table;
        }


        public string Get_maTB_by_maSB(string masbdi_tmp , string masbden_tmp)
        {
            string temp = "-1";
            SqlConnection con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT MATB FROM TUYENBAY WHERE MASBDI='{0}' AND MASBDEN='{1}'",masbdi_tmp,masbden_tmp);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            try
            {
                DataRow row = dt.Rows[0];

                temp = (dt.Rows[0]["MATB"].ToString());
                return temp;
            }
            catch (Exception e)
            {
                return temp;
            }
           

            
        }


        public string Get_maSBTG_by_tenSB(string _tenSB)
        {

            SqlConnection con = dc.GetConnect();
            string sqlQuery = string.Format("SELECT MASB FROM SANBAY WHERE TENSANBAY=N'{0}'", _tenSB);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            DataRow row = dt.Rows[0];


            return (dt.Rows[0]["MASB"].ToString());

        }

        




        private void button_nhan_lich_Click(object sender, EventArgs e)
        {

            DataTable dt_hangve = (DataTable)dataGridView_hangve.DataSource;

            //Check điều kiện

            if (dataGridView_hangve.Rows.Count == 0 && dataGridView_hangve.Rows.Count == 0)
            {

                MessageBox.Show("Bạn chưa nhập thời gian bay hoặc các hạng vé của chuyến bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (dataGridView_hangve.Rows.Count == 0)
            {

                MessageBox.Show("Bạn chưa nhập các hạng vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (Convert.ToDateTime(dateTimePicker_ngaygio.Text)<=DateTime.Now)
            {
                MessageBox.Show("Ngày khởi hành phải sau ngày giờ hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox_sbdi.Text == "" || comboBox_sbden.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sân bay đến hoặc sân bay đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                MessageBox.Show("Sân bay đến phải khác sân bay đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox_thoigianbay.Text == "")// dataGridView_hangve.Rows.Count==0)
            {
                MessageBox.Show("Bạn chưa nhập thời gian bay!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if(int.Parse(textBox_thoigianbay.Text) < dtoQuyDinh.tgbaytoithieu)
            {
                string message = $"Bạn nhập thời gian bay chưa đúng!\r\nThời gian bay bạn nhập là {textBox_thoigianbay.Text} phút, NHỎ HƠN thời gian bay tối thiểu là {dtoQuyDinh.tgbaytoithieu} phút.";
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Check END

            dtoChuyenBay = new DTO.Chuyenbay(textBox_macb.Text, Get_maTB_by_maSB(comboBox_sbdi.SelectedValue.ToString(),comboBox_sbden.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker_ngaygio.Text), float.Parse(textBox_thoigianbay.Text), comboBox_giave.SelectedValue.ToString());
            if (busChuyenbay.InsertChuyenbay(dtoChuyenBay))
            {
                //MessageBox.Show("Nhận lịch chuyến bay B1 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Xóa trống lại
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra! Nhận lịch chuyến bay thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int check_count = 0;

            foreach (DataGridViewRow row in dataGridView_sbtrunggian.Rows)
            {

                dtoChitietchuyenbay = new DTO.Chitietchuyenbay("", textBox_macb.Text, Get_maSBTG_by_tenSB(row.Cells[2].Value.ToString()),
                    float.Parse(row.Cells[3].Value.ToString()), row.Cells[4].Value.ToString());
                if(busChitietchuyenbay.InsertCTChuyenBay(dtoChitietchuyenbay))
                {
                    check_count++;
                }

            }

            if(check_count==dataGridView_sbtrunggian.Rows.Count)
            {
                check_count = 0;
                //MessageBox.Show("Nhận lịch chuyến bay B2 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhận lịch chuyến bay B2 thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (DataGridViewRow row in dataGridView_hangve.Rows)
            {
                
                dtoTinhtrangve = new DTO.Tinhtrangve("", textBox_macb.Text, busHangve.Get_MAVE_by_TENHV(row.Cells[1].Value.ToString()), int.Parse(row.Cells[2].Value.ToString()), int.Parse(row.Cells[2].Value.ToString()), 0);
                
                if (busTinhtrangve.InsertTinhtrangve(dtoTinhtrangve))
                {
                    check_count++;
                }

            }

            if (check_count == dataGridView_hangve.Rows.Count)
            {
                check_count = 0;
                MessageBox.Show("Nhận lịch chuyến bay thành công\r\n Hoàn tất nhận lịch chuyến bay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanLichChuyenBay_Load(sender, e);
                textBox_thoigianbay.Clear();
                textBox_thoigiandung.Clear();
                textBox_slghe.Clear();

                pictureBox_check.Visible = false;
                label_tuyenbay_khadung.Visible = false;

                textBox_thoigianbay.Clear();

                dataGridView_hangve.Rows.Clear();
                dataGridView_hangve.Refresh();

                dataGridView_sbtrunggian.Rows.Clear();
                dataGridView_sbtrunggian.Refresh();
            }
            else
            {
                MessageBox.Show("Nhận lịch chuyến bay B3 thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void comboBox_sbden_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

            trigger = 1;
            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                label_note_check2sb.Visible = true;
                label_note_check2sb.ForeColor = Color.Red;
                label_note_check2sb.Text = "*Sân bay đến phải khác sân bay đi!";
            }
            else { label_note_check2sb.Visible = false; }


            if (comboBox_sbden.Text != "" && trigger == 1)
            {

                if (Get_maTB_by_maSB(comboBox_sbdi.SelectedValue.ToString(), comboBox_sbden.SelectedValue.ToString()) != "-1")
                {


                    pictureBox_check.Image = Properties.Resources.okay;
                    pictureBox_check.Visible = true;
                    label_tuyenbay_khadung.ForeColor = Color.Black;
                    label_tuyenbay_khadung.Text = "Tồn tại tuyến bay giữa hai sân bay trên";
                }
                else
                {
                    pictureBox_check.Visible = true;
                    pictureBox_check.Image = Properties.Resources.btnCancel;
                    label_tuyenbay_khadung.Visible = true;
                    label_tuyenbay_khadung.ForeColor = Color.Red;
                    label_tuyenbay_khadung.Text = "Không tồn tại tuyến bay giữa hai sân bay trên";
                }
            }
        }


        

        private void comboBox_sbdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            trigger = 1;
            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                label_note_check2sb.Visible = true;
                label_note_check2sb.ForeColor = Color.Red;
                label_note_check2sb.Text = "*Sân bay đến phải khác sân bay đi!";
            }
            else { label_note_check2sb.Visible = false; }


            if (comboBox_sbden.Text != ""&& trigger==1)
            {
                if (Get_maTB_by_maSB(comboBox_sbdi.SelectedValue.ToString(), comboBox_sbden.SelectedValue.ToString()) != "-1")
                {


                    pictureBox_check.Image = Properties.Resources.okay;
                    pictureBox_check.Visible = true;
                    label_tuyenbay_khadung.ForeColor = Color.Black;
                    label_tuyenbay_khadung.Text = "Tồn tại tuyến bay giữa hai sân bay trên";
                }
                else
                {

                    pictureBox_check.Image = Properties.Resources.btnCancel;
                    label_tuyenbay_khadung.Visible = true;
                    label_tuyenbay_khadung.ForeColor = Color.Red;
                    label_tuyenbay_khadung.Text = "Không tồn tại tuyến bay giữa hai sân bay trên";
                }
            }
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            string tmp = comboBox_sbden.Text;
            comboBox_sbden.Text = comboBox_sbdi.Text;
            comboBox_sbdi.Text = tmp;
            comboBox_sbden_SelectionChangeCommitted(sender, e);
            comboBox_sbdi_SelectionChangeCommitted(sender, e);
        }

        








    }
}
