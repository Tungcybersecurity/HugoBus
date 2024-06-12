using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI.Contract
{
    public partial class ContractDetails : Form
    {
        ContractMain form;
        public ContractDetails(ContractMain f)
        {
            form = f;
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            
            tbxIDHopDong.Text = form.idhopdong;
            tbxIDHocSinh.Text = form.idhocsinh;
            tbxNgayTao.Text = form.ngaytao;
            tbxNgayBatDau.Text = form.ngaybatdau;
            tbxNgayKetThuc.Text = form.ngayketthuc;
            tbxTramDon.Text = form.tramdon;
            tbxTruongDen.Text = form.truongden;
            cbxTrangThai.Text = form.trangthai;
            tbxNgayCapNhat.Text = form.ngaycapnhat;
            if (form.trangthai == "Hủy" || form.trangthai == "Hết hiệu lực")
            {
                buttonCapNhatTrangThai.Enabled = false;
            }
            DataTable dt = new ContractBUS().getChiTietHopDongByID(form.idhopdong);
            int c = dt.Rows.Count;
            for (int i = 0; i < c; i++)
            {
                DataRow dr = dt.Rows[i];
                string thu = dr["ThuTrongTuan"] + "";
                string buoi = dr["Buoi"] + "";
                if (buoi == "Sáng ")
                {
                    if (thu == "2")
                    {
                        checkboxSang2.Checked = true;
                    }
                    if (thu == "3")
                    {
                        checkboxSang3.Checked = true;
                    }
                    if (thu == "4")
                    {
                        checkboxSang4.Checked = true;
                    }
                    if (thu == "5")
                    {
                        checkboxSang5.Checked = true;
                    }
                    if (thu == "6")
                    {
                        checkboxSang6.Checked = true;
                    }
                    if (thu == "7")
                    {
                        checkboxSang7.Checked = true;
                    }
                }
                else if (buoi == "Chiều")
                {
                    if (thu == "2")
                    {
                        checkboxChieu2.Checked = true;
                    }
                    if (thu == "3")
                    {
                        checkboxChieu3.Checked = true;
                    }
                    if (thu == "4")
                    {
                        checkboxChieu4.Checked = true;
                    }
                    if (thu == "5")
                    {
                        checkboxChieu5.Checked = true;
                    }
                    if (thu == "6")
                    {
                        checkboxChieu6.Checked = true;
                    }
                    if (thu == "7")
                    {
                        checkboxChieu7.Checked = true;
                    }
                }
                else
                {
                    if (thu == "2")
                    {
                        checkboxChieu2.Checked = true;
                        checkboxSang2.Checked = true;
                    }
                    if (thu == "3")
                    {
                        checkboxChieu3.Checked = true;
                        checkboxSang3.Checked = true;
                    }
                    if (thu == "4")
                    {
                        checkboxChieu4.Checked = true;
                        checkboxSang4.Checked = true;
                    }
                    if (thu == "5")
                    {
                        checkboxChieu5.Checked = true;
                        checkboxSang5.Checked = true;
                    }
                    if (thu == "6")
                    {
                        checkboxChieu6.Checked = true;
                        checkboxSang6.Checked = true;
                    }
                    if (thu == "7")
                    {
                        checkboxChieu7.Checked = true;
                        checkboxSang7.Checked = true;
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.loadForm();
            this.Close();
        }

        private void buttonCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            cbxTrangThai.Enabled = true;
            buttonLuu.Enabled = true;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            int idTT = cbxTrangThai.SelectedIndex + 1;
            //MessageBox.Show(idTT.ToString());
            int rs = new ContractBUS().updateTrangThai(form.idhopdong, idTT);
            if (rs > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                string loai = "1";
                string TenThongBao = "Hợp đồng: ID = " + form.idhopdong + ", trạng thái: " + cbxTrangThai.Text;
                int tbhd = new ThongBaoBUS().themThongBaoHopDong(TenThongBao, loai, form.idhopdong);
                if (tbhd > 0)
                {
                    MessageBox.Show("Đã thêm thông báo về tình trạng hợp đồng hiện tại cho phụ huynh Thông báo: " + TenThongBao);
                }
            }
            else
            {
                return;
            }
        }
    }
}
