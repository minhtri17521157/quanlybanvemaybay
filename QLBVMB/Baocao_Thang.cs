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
    public partial class Baocao_Thang : Form
    {
        int dem=0;
        float dem2 = 0;
        BLL.CTDoanhthuthangBLL busCTDoanhthuthang;
        BLL.TinhtrangveBLL busTinhtrangve;
        BLL.VechuyenbayBLL busVechuyenbay;

        public Baocao_Thang()
        {
            InitializeComponent();
            busCTDoanhthuthang = new BLL.CTDoanhthuthangBLL();
            busTinhtrangve = new BLL.TinhtrangveBLL();
            busVechuyenbay = new BLL.VechuyenbayBLL();

        }





        private void button_tra_cuu_Click(object sender, EventArgs e)
        {

            if (comboBox_thang.Text == "" || textBox_nam.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                DataTable _dt = busCTDoanhthuthang.Get_by_MON_and_Year(comboBox_thang.Text.ToString(), textBox_nam.Text.ToString());

                _dt.Columns.Add("Tỷ lệ (%)", typeof(float));
                _dt.Columns["Tỷ lệ (%)"].SetOrdinal(4);

                int index = _dt.Rows.Count;

                for (int i = 0; i < index; i++)
                {
                    dem += int.Parse(busTinhtrangve.Get_SL_GHE_by_MACB(_dt.Rows[i][1].ToString()));
                    dem2 = float.Parse(busVechuyenbay.Get_SLVE_MUA_by_MACB_MONTH(_dt.Rows[i][1].ToString(),comboBox_thang.Text));

                    //_dt.Rows[i][4] = (float.Parse(busTinhtrangve.Get_SL_GHE_by_MACB(_dt.Rows[i][1].ToString()))
                    //    / 100 * float.Parse(busVechuyenbay.Get_SLVE_MUA_by_MACB_MONTH(_dt.Rows[i][1].ToString(),dem2.ToString())));

                    _dt.Rows[i][4] = (float.Parse(busTinhtrangve.Get_SL_GHE_by_MACB(_dt.Rows[i][1].ToString()))
                        / 100 * dem2);

                }
                
                dataGridView_dthu.DataSource = _dt;

                dataGridView_dthu.Sort(dataGridView_dthu.Columns[0], ListSortDirection.Ascending);
                dataGridView_dthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_dthu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                
            }
        }

        private void textBox_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
