using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class Banve : Form
    {
        private SoundPlayer _soundPlayer_pay;
        DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter da;
        ChuyenbayBLL bll_Chuyenbay;
        string tmp_maDG;
        string tmp_maVE;
        string tmp_maHK;
        //
        DTO.Vechuyenbay dtoVeChuyenBay;
        DTO.Hanhkhach dtoKhachHang;
        BLL.VechuyenbayBLL busVeChuyenBay;
        BLL.HanhkhachBLL busKhachHang;
        //
        BLL.VechuyenbayBLL bllVCB;
        

        public Banve()
        {
            InitializeComponent();

            dc = new DataConnection();
            bll_Chuyenbay = new ChuyenbayBLL();
            busVeChuyenBay = new BLL.VechuyenbayBLL();
            busKhachHang = new BLL.HanhkhachBLL();
            bllVCB = new BLL.VechuyenbayBLL();

            _soundPlayer_pay = new SoundPlayer(Properties.Resources.pay);
        }

        private void LoadDaTatxtSoGheTrong()
        {
            if (comboBox_hv.SelectedValue != null)
            {
                BLL.TinhtrangveBLL busTinhTrangVe = new BLL.TinhtrangveBLL();
                textBox_slghetrong.Text = busTinhTrangVe.GetSoGheTrongOfMaChuyenBayAndMaHangVe(textBox_MaCB.Text, comboBox_hv.SelectedValue.ToString());
            }
        }

        private void TaoLai()
        {
            
            //TaoBangDSVeChuyenBay();
            textBox_TGbay.Clear();
            textBox_CMND.Clear();
            textBox_SDT.Clear();
            textBox_TenKH.Clear();
            LoadDaTatxtSoGheTrong();
            string maSanBayDi = comboBox_sbdi.SelectedValue.ToString();
            string maSanBayDen = comboBox_sbden.SelectedValue.ToString();
            DateTime ngayKH = dateTimePicker_thoigian1.Value;
            DateTime ngayKH2 = dateTimePicker_thoigian2.Value;
            string tmp = dateTimePicker_thoigian1.Value.ToShortDateString();

            TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKH, ngayKH2, tmp);

        }

        private void KhoiTaoGiaoDien()
        {
             comboBox_sbden.SelectedValue = 2;
            
            //ChuyenbayBLL busChuyenBay = new ChuyenbayBLL();
            //DataTable dtChuyenBay = new DataTable();

            //dtChuyenBay = busChuyenBay.Get();
            //comboBox_MaCB.DataSource = dtChuyenBay;
            //comboBox_MaCB.DisplayMember = "MACB";
            //comboBox_MaCB.ValueMember = "MACB";

            BLL.HangveBLL busHangVe = new BLL.HangveBLL();
            DataTable dtHangVe = new DataTable();

            dtHangVe = busHangVe.getHangveKhadungbyMACB(textBox_MaCB.Text);
            comboBox_hv.DataSource = dtHangVe;
            comboBox_hv.DisplayMember = "TENHV";
            comboBox_hv.ValueMember = "MAHV";

            //TaoBangDSVeChuyenBay();
        }

        public void ShowComboBoxDi()
        {


            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from SANBAY WHERE TINHTRANG=N'Hoạt động'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            
            DataTable table = new DataTable();
            da.Fill(table);
            comboBox_sbdi.DataSource = table;
            comboBox_sbdi.DisplayMember = "TENSANBAY";
            comboBox_sbdi.ValueMember = "MASB";

        }

        public void ShowComboBoxDen()
        {
            
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from SANBAY WHERE TINHTRANG=N'Hoạt động'", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);


            comboBox_sbden.DataSource = table;
            comboBox_sbden.DisplayMember = "TENSANBAY";
            comboBox_sbden.ValueMember = "MASB";


        }

        public void ShowComboBoxHv()
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from HANGVE", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);


            comboBox_hv.DataSource = table;
            comboBox_hv.DisplayMember = "TENHV";
            comboBox_hv.ValueMember = "MAHV";


        }

      

        private void Banve_Load(object sender, EventArgs e)
        {

            comboBox_sbden.Focus();
           
            this.dateTimePicker_thoigian1.MinDate = DateTime.Now;
            this.dateTimePicker_thoigian2.MinDate = DateTime.Now;
            this.ShowComboBoxDi();
            this.ShowComboBoxDen();
            String.Format("{0:n0}", textBox_gia.Text); // No digits after the decimal point. Output: 9,876
            //this.ShowComboBoxHv();
           

        }

        private void TaoBangDSChuyenBayTheoYeuCau(string maSanBayDen, string maSanBayDi, DateTime thoiGianKH, DateTime thoiGianKH2, string tmp)
        {
            DataTable dtChuyenBay = bll_Chuyenbay.Search(maSanBayDen, maSanBayDi, thoiGianKH, thoiGianKH2, tmp);
            dataGridView_tracuu.DataSource = dtChuyenBay;
            dataGridView_tracuu.Sort(dataGridView_tracuu.Columns[0], ListSortDirection.Descending);
            dataGridView_tracuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_tracuu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void button_Timkiem_Click(object sender, EventArgs e)
        {

            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                MessageBox.Show("Sân bay đi và sân bay đến không thể trùng nhau", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_sbden.SelectedValue = 2;
            }


            if (comboBox_sbdi.Text != "" && comboBox_sbden.Text != "" && dateTimePicker_thoigian1.Text != "")
            {
                try
                {
                    string maSanBayDi = comboBox_sbdi.SelectedValue.ToString();
                    string maSanBayDen = comboBox_sbden.SelectedValue.ToString();
                    DateTime ngayKH = dateTimePicker_thoigian1.Value;
                    DateTime ngayKH2 = dateTimePicker_thoigian2.Value;
                    string tmp = dateTimePicker_thoigian1.Value.ToShortDateString();

                    TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKH, ngayKH2, tmp);
                }
                catch (Exception a)
                {

                }
                finally
                {
                    // TaoLai();
                }


            }
            else
            {
                //MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
            //string maSanBayDi = comboBox_sbdi.SelectedValue.ToString();
            //string maSanBayDen = comboBox_sbden.SelectedValue.ToString();
            //DateTime ngayKH = dateTimePicker_thoigian.Value;

            //TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp = comboBox_sbden.Text;
            comboBox_sbden.Text = comboBox_sbdi.Text;
            comboBox_sbdi.Text = tmp;
        }

        private void dataGridView_tracuu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {


                textBox_MaTB.Text = dataGridView_tracuu.Rows[index].Cells[1].Value.ToString();
                ////
                textBox_MaCB.Text = dataGridView_tracuu.Rows[index].Cells[0].Value.ToString();
                ////
                comboBox_hv.Text = dataGridView_tracuu.Rows[index].Cells[4].Value.ToString();

                
            }
        }



        private void TaoBangDSVeChuyenBay()
        {
            DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
            dataGridView_ve.DataSource = dtVeChuyenBay;
            dataGridView_ve.Sort(dataGridView_ve.Columns[0], ListSortDirection.Descending);
            dataGridView_ve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ve.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

        }



        private void button_Muave_Click(object sender, EventArgs e)
        {
            if (textBox_slghetrong.Text == "0" || textBox_slghetrong.Text == "")
            {
                MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_MaCB.Text.Trim() != "" && textBox_CMND.Text.Trim() != "" && textBox_TenKH.Text.Trim() != "" && textBox_SDT.Text.Trim() != "" && comboBox_hv.Text.Trim() != "")
            {
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé mua";
                    DataTable dtKhachHang = busKhachHang.GetOfCMND(textBox_CMND.Text);

                    if (dtKhachHang.Rows.Count > 0)
                    {
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAHK"].ToString();
                    }
                    else
                    {

                        dtoKhachHang = new DTO.Hanhkhach(null, textBox_TenKH.Text, textBox_CMND.Text, textBox_SDT.Text);
                        if (!busKhachHang.InsertHanhkhach(dtoKhachHang))
                        {
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TaoLai();
                            return;
                        }
                        dtKhachHang = busKhachHang.GetOfCMND(textBox_CMND.Text);
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAHK"].ToString();
                    }

                    dtoVeChuyenBay = new DTO.Vechuyenbay(null, maKhachHang, textBox_MaCB.Text, comboBox_hv.SelectedValue.ToString(), Convert.ToDecimal(textBox_gia.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
                    if (busVeChuyenBay.InsertVechuyenbay(dtoVeChuyenBay))
                    {
                        _soundPlayer_pay.Play();
                        MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        string get_mahk = GetMAHK(textBox_CMND.Text);
                        ThanhToanHoaDon frm = new ThanhToanHoaDon(GetMAVE(GetMAHK(textBox_CMND.Text), textBox_MaCB.Text, comboBox_hv.SelectedValue.ToString()));
                        //frm.Show();
                        //test show form

                        frm.ShowDialog();



                        dataGridView_tracuu.DataSource = null;
                    }
                    else
                        MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_hv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_hv.SelectedValue != null)
            {

                BLL.DongiaBLL busDonGia = new BLL.DongiaBLL();
                BLL.HangveBLL busHangve = new BLL.HangveBLL();
                ChuyenbayBLL busChuyenbay = new ChuyenbayBLL();
                if (textBox_MaCB.Text == null)
                {
                    return;
                }


                //comboBox_MaCB.SelectedValue.ToString();
                DataTable dtChuyenbay = busChuyenbay.SearchDGbyMACB(textBox_MaCB.Text);
                foreach (DataRow row3 in dtChuyenbay.Rows)
                {
                    tmp_maDG = row3["MADG"].ToString();
                }
                DataTable dtDonGia = busDonGia.SearchDGbymaDG(tmp_maDG);
                DataTable dtTyle = busHangve.SearchTLbyID(comboBox_hv.SelectedValue.ToString());
                float dongia;

                foreach (DataRow row in dtDonGia.Rows)
                {

                    dongia = Int32.Parse(row["DONGIA"].ToString());
                    foreach (DataRow row2 in dtTyle.Rows)
                    {

                        dongia = (dongia * Int32.Parse(row2["TYLE"].ToString())) / 100;
                        textBox_gia.Text = dongia.ToString();
                    }
                }



                LoadDaTatxtSoGheTrong();
            }
        }

        private string GetMAVE(string makhachhang, string machuyenbay, string mahangve)
        {
            BLL.VechuyenbayBLL busVeChuyenbay = new BLL.VechuyenbayBLL();
            //string mave = "123";
            DataTable dtVecb = busVeChuyenbay.FindMAVE(makhachhang, machuyenbay, mahangve);
            foreach (DataRow row in dtVecb.Rows)
            {
                tmp_maVE = row["MAVE"].ToString();
            }

            return tmp_maVE;
        }

        private string GetMAHK(string cmnd)
        {
            BLL.HanhkhachBLL busHanhkhach = new BLL.HanhkhachBLL();
            //string mahk = "123";
            DataTable dtHanhkhach = busHanhkhach.FindMAHK(cmnd);
            foreach (DataRow row in dtHanhkhach.Rows)
            {
                tmp_maHK = row["MAHK"].ToString();
            }


            return tmp_maHK;
        }
        
        

        private void Banve_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();

        }

        //Update giá
        private void textBox_gia_TextChanged(object sender, EventArgs e)
        {
            if (textBox_gia.Text == "")
                return;
            string text = textBox_gia.Text.Replace(",", "");
            decimal value = Convert.ToDecimal(text);
            textBox_gia.Text = string.Format("{0:0,0}", value);
            

        }

        //Tìm kiếm mã vé
        private void textBox_TKMV_TextChanged(object sender, EventArgs e)
        {
            string value = textBox_TKMV.Text;
            if (!string.IsNullOrEmpty(value)) //không rỗng
            {
                DataTable dt = bllVCB.FindVebyMAVE(value);
                dataGridView_ve.DataSource = dt;
            }
            else
            {
                dataGridView_ve.DataSource = null;
            }

        }


        //Ràng buộc nhập số
        private void textBox_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        public void SetNew()
        {

            TaoLai();
        }


        private void button_Datve_Click(object sender, EventArgs e)
        {
            if (textBox_slghetrong.Text == "0" || textBox_slghetrong.Text == "")
            {
                MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_MaCB.Text.Trim() != "" && textBox_CMND.Text.Trim() != "" && textBox_TenKH.Text.Trim() != "" && textBox_SDT.Text.Trim() != "" && comboBox_hv.Text.Trim() != "")
            {
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé đặt";
                    DataTable dtKhachHang = busKhachHang.GetOfCMND(textBox_CMND.Text);

                    if (dtKhachHang.Rows.Count > 0)
                    {
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAHK"].ToString();
                    }
                    else
                    {

                        dtoKhachHang = new DTO.Hanhkhach(null, textBox_TenKH.Text, textBox_CMND.Text, textBox_SDT.Text);
                        if (!busKhachHang.InsertHanhkhach(dtoKhachHang))
                        {
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TaoLai();
                            return;
                        }
                        dtKhachHang = busKhachHang.GetOfCMND(textBox_CMND.Text);
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAHK"].ToString();
                    }

                    dtoVeChuyenBay = new DTO.Vechuyenbay(null, maKhachHang, textBox_MaCB.Text, comboBox_hv.SelectedValue.ToString(), Convert.ToDecimal(textBox_gia.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
                    if (busVeChuyenBay.InsertVechuyenbay(dtoVeChuyenBay))
                    {
                        _soundPlayer_pay.Play();
                        MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string get_mahk = GetMAHK(textBox_CMND.Text);
                        ThanhToanHoaDon frm = new ThanhToanHoaDon(GetMAVE(GetMAHK(textBox_CMND.Text), textBox_MaCB.Text, comboBox_hv.SelectedValue.ToString()));
                        //QL_Sanbay frm = new QL_Sanbay();
                        frm.UIParent = this;
                        frm.Show();
                        dataGridView_ve.DataSource = null;

                    }
                    else
                        MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_chitiet_Click(object sender, EventArgs e)
        {
            
            string get_mahk = GetMAHK(textBox_CMND.Text);
            ThanhToanHoaDon frm = new ThanhToanHoaDon(textBox_getMV.Text);
            textBox_TKMV.Clear();
            textBox_getMV.Clear();
            dataGridView_ve.DataSource = null;
            button_chitiet.Enabled = false;
            frm.ShowDialog();
            button_Timkiem_Click(sender,e);

        }

        private void dataGridView_ve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            if (index >= 0)
            {


                textBox_getMV.Text = dataGridView_ve.Rows[index].Cells[0].Value.ToString();
               
               
            }

        }

        private void textBox_MaCB_TextChanged(object sender, EventArgs e)
        {
            ChuyenbayBLL busChuyenBay = new ChuyenbayBLL();
            DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(textBox_MaCB.Text);
            if (dtChuyenBay.Rows.Count == 0)
            {
                textBox_MaTB.Clear();
                textBox_SBdi.Clear();
                textBox_SBden.Clear();
                textBox_TGkh.Clear();
                textBox_TGbay.Clear();

            }
            else
            {
                DataRow row = dtChuyenBay.Rows[0];
                textBox_MaTB.Text = row["MATB"].ToString();
                textBox_SBdi.Text = row["TENSBDI"].ToString();
                textBox_SBden.Text = row["TENSBDEN"].ToString();
                textBox_TGkh.Text = row["NGAYGIO"].ToString();
                textBox_TGbay.Text = row["THOIGIANBAY"].ToString();

                //
                BLL.HangveBLL busHangVe = new BLL.HangveBLL();
                DataTable dtHangVe = new DataTable();
                dtHangVe = busHangVe.getHangveKhadungbyMACB(textBox_MaCB.Text);
                comboBox_hv.DataSource = dtHangVe;
                comboBox_hv.DisplayMember = "TENHV";
                comboBox_hv.ValueMember = "MAHV";
                //
                LoadDaTatxtSoGheTrong();
                comboBox_hv_SelectedValueChanged(sender, e);
            }
        }

        private void dataGridView_tracuu_DataSourceChanged(object sender, EventArgs e)
        {
            LoadDaTatxtSoGheTrong();
        }

        private void textBox_CMND_TextChanged(object sender, EventArgs e)
        {
            if (textBox_CMND.Text == "")
            {
                textBox_TenKH.ReadOnly = false;
            }
            BLL.HanhkhachBLL busHanhkhach = new BLL.HanhkhachBLL();
           
            DataTable dtKhachHang = busKhachHang.GetOfCMND(textBox_CMND.Text);
            if (dtKhachHang.Rows.Count == 0)
            {
                textBox_TenKH.ReadOnly = false;            
                textBox_TenKH.Clear();
                textBox_SDT.Clear();
            }
            else
            {
                DataRow row = dtKhachHang.Rows[0];
                textBox_TenKH.Text = row["TENHK"].ToString();
                textBox_TenKH.ReadOnly = true;
                //textBox_SDT.Text = row["SDT"].ToString();
                
            }
        }

        private void textBox_getMV_TextChanged(object sender, EventArgs e)
        {
            if (textBox_getMV.Text == "")
            {
                button_chitiet.Enabled = false;
            }
            else
            {
                button_chitiet.Enabled = true;
            }
        }

      
        private void comboBox_sbdi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                MessageBox.Show("Sân bay đi và sân bay đến không thể trùng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //comboBox_sbden.SelectedValue = 1;
                //comboBox_sbdi.SelectedItem 
            }
        }

        private void comboBox_sbden_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_sbdi.Text == comboBox_sbden.Text)
            {
                //MessageBox.Show("Sân bay đi và sân bay đến không thể trùng nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //comboBox_sbden. = 1;
                //comboBox_sbdi.SelectedValue = 2;
            }
        }
    }
}



