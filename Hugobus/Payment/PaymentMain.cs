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
namespace GUI.Payment
{
    public partial class PaymentMain : Form
    {
        int nhanThem = 0;
        int nhanSua = 0;
        string NgayThanhToan = string.Empty;
        string idThanhToan = string.Empty;
        PaymentBUS service = new PaymentBUS();
        public PaymentMain()
        {
            InitializeComponent();
            loadForm();
        }
        public void loadForm()
        {
            paymentTable.DataSource = service.duLieu();
            paymentTable.ReadOnly = true;
            textBoxIDHopDong.Enabled = false;
            comboBoxPhuongThuc.Enabled = false;
            textBoxSoTien.Enabled = false;
            dateTimePickerNgayThanhToan.Enabled = false;
            textBoxIDHopDong.Text = string.Empty;
            comboBoxPhuongThuc.Text = string.Empty;
            textBoxSoTien.Text = string.Empty;
            dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Custom;
            //            dateTimePickerNgayThanhToan.MinDate = DateTime.Now;
            dateTimePickerNgayThanhToan.CustomFormat = "yyyy-MM-dd";
            dateTimePickerNgayThanhToan.Text = string.Empty;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            nhanSua = 0;
            nhanThem = 0;
            loadForm();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (nhanThem == 0)
            {
                nhanThem = 1;
                comboBoxPhuongThuc.Enabled = true;
                dateTimePickerNgayThanhToan.Enabled = true;
                return;
            }
            else
            {
                if (textBoxIDHopDong.Text != string.Empty && comboBoxPhuongThuc.Text != string.Empty && textBoxSoTien.Text != string.Empty && dateTimePickerNgayThanhToan.Text != string.Empty)
                {

                    int kq = new PaymentBUS().suaThanhToan(textBoxIDHopDong.Text, Int32.Parse(textBoxSoTien.Text), dateTimePickerNgayThanhToan.Text, comboBoxPhuongThuc.Text, idThanhToan);
                    if (kq > 0)
                    {
                        MessageBox.Show("Xác nhận thanh toán thành công");
                        int updateTrangThai = new ContractBUS().updateTrangThai(textBoxIDHopDong.Text, 7);
                        string loai = "1";
                        string TenThongBao = "Hợp đồng: ID = " + textBoxIDHopDong.Text + ", trạng thái: Đã thanh toán, chờ hiệu lực";
                        int tbhd = new ThongBaoBUS().themThongBaoHopDong(TenThongBao, loai, textBoxIDHopDong.Text);
                        if (tbhd > 0)
                        {
                            MessageBox.Show("Đã thêm thông báo về tình trạng hợp đồng hiện tại cho phụ huynh. Thông báo: " + TenThongBao);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận thất bại");
                    }
                    //MessageBox.Show(comboBoxIDHopDong.Text + ", " + comboBoxPhuongThuc.Text + ", " + textBoxSoTien.Text + ", " + dateTimePickerNgayThanhToan.Text);
                    nhanThem = 0;
                    loadForm();
                    return;
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (nhanSua == 0)
            {
                nhanSua = 1;
                comboBoxPhuongThuc.Enabled = true;
                textBoxSoTien.Enabled = true;
                dateTimePickerNgayThanhToan.Enabled = true;
                return;
            }
            else
            {
                if (textBoxIDHopDong.Text != string.Empty && comboBoxPhuongThuc.Text != string.Empty && textBoxSoTien.Text != string.Empty && dateTimePickerNgayThanhToan.Text != string.Empty)
                {
                    int kq = new PaymentBUS().suaThanhToan(textBoxIDHopDong.Text, Int32.Parse(textBoxSoTien.Text), dateTimePickerNgayThanhToan.Text, comboBoxPhuongThuc.Text, idThanhToan);
                    if (kq > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                    nhanSua = 0;
                    loadForm();
                    return;
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (idThanhToan == string.Empty)
            {
                MessageBox.Show("Hãy chọn 1 thanh toán");
                return;
            }
            else
            {
                if (NgayThanhToan == string.Empty || NgayThanhToan == null)
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }
                int kq = new PaymentBUS().xoaThanhToan(idThanhToan);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadForm();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }
            }
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ThongKe form = new ThongKe();
            form.ShowDialog();
        }

        private void paymentTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                idThanhToan = paymentTable.Rows[dong].Cells[0].Value.ToString();
                textBoxIDHopDong.Text = paymentTable.Rows[dong].Cells[1].Value.ToString();
                textBoxSoTien.Text = paymentTable.Rows[dong].Cells[2].Value.ToString();
                dateTimePickerNgayThanhToan.Text = paymentTable.Rows[dong].Cells[3].Value.ToString();
                comboBoxPhuongThuc.Text = paymentTable.Rows[dong].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
