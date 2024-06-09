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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            dateTimePickerNgayBatDau.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayBatDau.CustomFormat = "yyyy-MM-dd";
            dateTimePickerNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayKetThuc.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            string NgayBatDau = string.Empty;
            string NgayKetThuc = string.Empty;
            int flag = 0;
            if (dateTimePickerNgayBatDau.Text != string.Empty && dateTimePickerNgayKetThuc.Text != string.Empty)
            {
                NgayBatDau = dateTimePickerNgayBatDau.Text;
                NgayKetThuc = dateTimePickerNgayKetThuc.Text;
                flag++;
            }
            else if (dateTimePickerNgayBatDau.Text != string.Empty && dateTimePickerNgayKetThuc.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhãy ô 'Đến ngày'");
            }
            else if (dateTimePickerNgayBatDau.Text == string.Empty && dateTimePickerNgayKetThuc.Text != string.Empty)
            {
                MessageBox.Show("Hãy nhập ô 'Từ ngày'");
            }

            if (flag != 0)
            {
                dataGridViewThongKe.DataSource = new PaymentBUS().getDataThongKe(NgayBatDau, NgayKetThuc);
                dataGridViewThongKe.ReadOnly = true;
                labelTong.Text = "Tổng: " + (new PaymentBUS().tongThongKe(NgayBatDau,NgayKetThuc)).ToString();
            }
        }
    }
}
