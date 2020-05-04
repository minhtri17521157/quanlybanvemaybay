using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBVMB
{
    public partial class ThanhToanHoaDon : Form
    {
        private SoundPlayer _soundPlayer_pay;
        BLL.VechuyenbayBLL busVechuyenbay;
        string Mave;

        //public ThanhToanHoaDon(bool check,string ten,string cmnd, string sdt, string mave, string macb, string matb, string masbdi,string masbden, string tgkh,string tgb, string tenhv,string gia )
        public ThanhToanHoaDon(string mave)
        {

            InitializeComponent();
            Mave = mave;
            _soundPlayer_pay = new SoundPlayer(Properties.Resources.pay);


        }


        //Truyền ngược lại form Bán vé

        public object UIParent
        {
            set;
            get;
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy vé chuyến bay này không?", "Xác nhận lại thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                busVechuyenbay.HuyVE(label_maVe.Text);
                ThanhToanHoaDon_Load(sender, e);
                if (UIParent is Banve)
                {
                    Banve frm = UIParent as Banve;
                    frm.SetNew();
                }
            }
        }

        private void ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            //label_gia.Text = string.Format("{0:0,0}", Convert.ToDecimal("50000000"));

            String.Format("{0:n0}", label_gia.Text);
            String.Format("{0:n0}",label_dadong.Text);

            



            busVechuyenbay = new BLL.VechuyenbayBLL();
            DataTable chitiet = busVechuyenbay.FindChitietVE(Mave);

            if (chitiet.Rows.Count > 0)
            {
                DataRow row = chitiet.Rows[0];

                this.label_tenKH.Text = row["TENHK"].ToString();
                this.label_CMND.Text = row["CMND"].ToString();
                this.label_SDT.Text = row["SDT"].ToString();
                this.label_maVe.Text = row["MAVE"].ToString();
                this.label_maCB.Text = row["MACB"].ToString();
                this.label_maTB.Text = row["MACB"].ToString();
                this.label_sbDi.Text = row["TENSBDI"].ToString();
                this.label_sbDen.Text = row["TENSBDEN"].ToString();
                this.label1_tgKH.Text = row["NGAYGIO"].ToString();
                this.label_tgBay.Text = row["THOIGIANBAY"].ToString();
                this.label_tenHV.Text = row["TENHV"].ToString();

                decimal value = Convert.ToDecimal(row["GIA"].ToString());
                this.label_gia.Text = string.Format("{0:0,0}", value);
                //this.label_gia.Text = row["GIA"].ToString();
               



                if (row["LOAIVE"].ToString() == "Vé mua")
                {
                    this.button_thanhtoan.Enabled = false;
                    this.button_huy.Enabled = false;
                    this.label_dead.Visible = false;
                    this.label_stt.Text = "Đã thanh toán";
                    this.label_dadong.Text = this.label_gia.Text;
                 
                    this.label_nggd.Text = row["NGAYGD"].ToString();
                    this.label_ngayhuy.Text = row["NGAYHUY"].ToString();
                    this.label_ngayhuy.Visible = false;
                    this.label_stt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

                }
                if (row["LOAIVE"].ToString() == "Vé đặt")
                {
                    this.button_thanhtoan.Enabled = true;
                    this.label_stt.Text = "Chưa thanh toán";
                    this.label_ngayhuy.Text = row["NGAYHUY"].ToString();
                    this.label_ngayhuy.BackColor = Color.Red;
                    this.label_stt.BackColor = Color.Red;
                    this.label_dadong.Text = "0";
                    this.label_nggd.Text = DateTime.Now.ToString();

                }
                if (row["LOAIVE"].ToString() == "Vé đã hủy")
                {
                    this.button_thanhtoan.Enabled = false;
                    this.button_huy.Enabled = false;
                    this.label_dead.Text = "Ngày hủy vé:";
                    this.label_stt.Text = "Đã hủy vé";
                    this.label_ngayhuy.Text = row["NGAYHUY"].ToString();
                    this.label_ngayhuy.BackColor = Color.Gray;
                    this.label_stt.BackColor = Color.Gray;
                    this.label_dadong.Text = "0";
                    this.label_nggd.Text = DateTime.Now.ToString();
                    

                }

            }
        }

        private void button_thanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán vé chuyến bay này không?", "Xác nhận lại thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busVechuyenbay.ThanhtoanVE(label_maVe.Text))
                {
                    _soundPlayer_pay.Play();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK);
                    ThanhToanHoaDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thanh toán thất bại!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               // busVechuyenbay.ThanhtoanVE(label_maVe.Text);
                //ThanhToanHoaDon_Load(sender, e);
            }

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        private void printDocument_Hoa_don_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int space_offset=30;
            
           // string _mave = "Mã vé: "+ label_maVe.Text;
            //string _hoten = "Họ tên hành khách: " + label_tenKH.Text;
            //string _cmnd = "CMND: " + label_CMND;
            //string _sdt

            //string _

            //graphic.DrawString(" SH Restaurants", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            e.Graphics.DrawString("Đại lý vé máy bay HASAGI", new Font("Times New Roman", 34, FontStyle.Underline), new SolidBrush(Color.Black), new Point(200, 80));
            e.Graphics.DrawString("~Dont just fly, SOAR!~", new Font("Segoe Print", 15, FontStyle.Italic), new SolidBrush(Color.Black), new Point(325, 140)); 
            e.Graphics.DrawString("----------------------------------------", new Font("Times New Roman", 30, FontStyle.Regular), new SolidBrush(Color.Black), new Point(160, 180));
            e.Graphics.DrawString("Vé máy bay", new Font("Times New Roman", 27, FontStyle.Bold), new SolidBrush(Color.Black), new Point(350, 220));
            e.Graphics.DrawString("Thông tin khách hàng", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(200, 300));
            e.Graphics.DrawString("Họ tên hành khách: "+label_tenKH.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340));
            e.Graphics.DrawString("CMND: " + label_CMND.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340+space_offset)); space_offset += 30;
            e.Graphics.DrawString("Số điện thoại: " + label_SDT.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 40;

            e.Graphics.DrawString("Thông tin thanh toán", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(200, 340+space_offset)); space_offset += 40;
            e.Graphics.DrawString("Tình trạng: " + label_stt.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340+space_offset)); space_offset += 30;
            e.Graphics.DrawString("Số tiền đã đóng: " + label_dadong.Text + " VNĐ", new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Ngày giao dịch: " + label_nggd.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            if (label_dadong.Text == "0")
            {
                e.Graphics.DrawString("Ngày quá hạn: " + label_ngayhuy.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 70;
            }
            else
            {
                space_offset += 70;
            }
            int k_offset = space_offset;
            e.Graphics.DrawString("Thông tin vé", new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 40;
            e.Graphics.DrawString("Mã vé: " + label_maVe.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Mã chuyến bay: " + label_maCB.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Mã tuyến bay: " + label_maTB.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Sân bay đi: " + label_sbDi.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Sân bay đến: " + label_sbDen.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Thời gian khởi hành: " + label1_tgKH.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Thời gian bay: " + label_tgBay.Text+" phút", new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Tên hạng vé: " + label_tenHV.Text, new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 30;
            e.Graphics.DrawString("Giá tiền: " + label_gia.Text+" VNĐ", new Font("Times New Roman", 15, FontStyle.Regular), new SolidBrush(Color.Black), new Point(200, 340 + space_offset)); space_offset += 85;
           
            e.Graphics.DrawString("Xin cảm ơn quý khách và kính chúc quý khách thượng lộ bình an!", new Font("Times New Roman", 15, FontStyle.Italic), new SolidBrush(Color.Black), new Point(180, 340 + space_offset)); 
            

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 4);
            Pen blackPen_light = new Pen(Color.Black, 2);
            // Create rectangle.
            Rectangle rect = new Rectangle(20, 20, 811, 1058);
            Rectangle rect_hk = new Rectangle(170, 280, 510, 335);
            Rectangle rect_ve = new Rectangle(170, k_offset-20, 510, 692);
            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);
            e.Graphics.DrawRectangle(blackPen_light, rect_hk);
            e.Graphics.DrawRectangle(blackPen_light,rect_ve);

            //Bitmap bitmap = Properties.Resources.plane;
            Bitmap _bit = ResizeImage(Properties.Resources.plane, 400, 400);
          
            e.Graphics.DrawImage(_bit, 50, 50);
           


        }

        private void button2_Click(object sender, EventArgs e)
        {


            printPreviewDialog_Hoa_don.Document = printDocument_Hoa_don;
            printPreviewDialog_Hoa_don.ShowDialog();

        }
    }
}
