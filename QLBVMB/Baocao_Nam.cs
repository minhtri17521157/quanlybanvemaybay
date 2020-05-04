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
    public partial class Baocao_Nam : Form
    {
        

        float k1 = 0, k2 = 0;

        BLL.DoanhthuthangBLL busDoanhthuthang;
        BLL.CTDoanhthuthangBLL busCTDoanhthuthang;
        BLL.TinhtrangveBLL busTinhtrangve;
        BLL.VechuyenbayBLL busVechuyenbay;
        BLL.DoanhthunamBLL busDoanhthunam;

        public Baocao_Nam()
        {
            InitializeComponent();
            busDoanhthuthang = new BLL.DoanhthuthangBLL();
            busDoanhthuthang = new BLL.DoanhthuthangBLL();
            busTinhtrangve = new BLL.TinhtrangveBLL();
            busVechuyenbay = new BLL.VechuyenbayBLL();
            busDoanhthunam = new BLL.DoanhthunamBLL();
            busCTDoanhthuthang = new BLL.CTDoanhthuthangBLL();

        }

        private void textBox_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_nam_TextChanged(object sender, EventArgs e)
        {
            label_doanhthu_nam.Text = "";
        }

        private void Baocao_Nam_Load(object sender, EventArgs e)
        {
            String.Format("{0:n0}", label_doanhthu_nam.Text);
        }

        private void button_tra_cuu_Click(object sender, EventArgs e)
        {

            if(textBox_nam.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                DataTable _dt = busDoanhthuthang.Get_report_by__Year(textBox_nam.Text.ToString());

                _dt.Columns.Add("Tỷ lệ (%)", typeof(float));
                _dt.Columns["Tỷ lệ (%)"].SetOrdinal(4);

                int index = _dt.Rows.Count;
                


                for (int i = 0; i < index; i++)
                {

                    DataTable _dt2 = busCTDoanhthuthang.Get_by_MON_and_Year(_dt.Rows[i][1].ToString(), textBox_nam.Text.ToString());
                    


                    _dt2.Columns.Add("Tỷ lệ (%)", typeof(float));
                    _dt2.Columns["Tỷ lệ (%)"].SetOrdinal(4);

                    int index2 = _dt2.Rows.Count;

                    for (int j = 0; j < index2; j++)
                    {
                       // int tmmp = busTinhtrangve.Get_SL_GHE_by_MACB(_dt2)
                       
                        //tongsl_ve += int.Parse(busTinhtrangve.Get_SL_GHE_by_MACB(_dt2.Rows[j][1].ToString()));
                        //tongsl_ve_mua += int.Parse(busVechuyenbay.Get_SLVE_MUA_by_MACB(_dt2.Rows[j][1].ToString()));

                        k1 += float.Parse(busTinhtrangve.Get_SL_GHE_by_MACB(_dt2.Rows[j][1].ToString()));
                        k2 += float.Parse(busVechuyenbay.Get_SLVE_MUA_by_MACB(_dt2.Rows[j][1].ToString()));

                    }

                    //_dt.Rows[i][4] = (float.Parse(tongsl_ve)) / 100 * float.Parse(tongsl_ve_mua);
                    _dt.Rows[i][4] = k1 / 100 *k2;

                    k1 = 0;
                    k2 = 0;
                }
                
                decimal _value = Convert.ToDecimal(busDoanhthunam.Get_doanhthu_NAM(textBox_nam.Text));
                if (_value != 0)
                {
                    String.Format("{0:n0}", _value);
                    label_doanhthu_nam.Text = string.Format("{0:0,0}", _value);
                }
                if (_value == 0)
                {
                    label_doanhthu_nam.Text = busDoanhthunam.Get_doanhthu_NAM(textBox_nam.Text);
                }
                

                dataGridView_dthu.DataSource = _dt;
               

                dataGridView_dthu.Sort(dataGridView_dthu.Columns[0], ListSortDirection.Ascending);
                dataGridView_dthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_dthu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                textBox_nam.Text = "";

            }



        }
    }
}
