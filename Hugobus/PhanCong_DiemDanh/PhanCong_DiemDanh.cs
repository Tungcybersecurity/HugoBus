using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Google.Protobuf;
namespace GUI.PhanCong_DiemDanh
{
    public partial class PhanCong_DiemDanh : Form
    {
        PhanCongBUS service = new PhanCongBUS();
        DiemDanhBUS service2 = new DiemDanhBUS();
        int nhanThem = 0;
        public string idTinhTrang = string.Empty;
        public string idDiemDanh = string.Empty;
        public string idPhanCong = string.Empty;
        public string NgayDuaDon_CPC = string.Empty;
        public string NgayBatDau_CPC = string.Empty;
        public string NgayKetThuc_CPC = string.Empty;
        public string Thu_CPC = string.Empty;
        public string Buoi_CPC = string.Empty;
        public string idHopDong_CPC = string.Empty;
        public string Phuong_CPC = string.Empty;
        public string Truong_CPC = string.Empty;
        public string idChiTiet_CPC = string.Empty;
        public PhanCong_DiemDanh()
        {
            InitializeComponent();
            loadForm();
        }

        public void GETVALUE(string value)
        {
            textBoxIDChuyen.Text = value;
        }

        public void loadForm()
        {
            NgayDuaDon_CPC = string.Empty;
            phancongTable.DataSource = service.duLieu();
            phancongTable.ReadOnly = true;
            chuaphancongTable.DataSource = service.duLieuChuaPhanCong();
            chuaphancongTable.ReadOnly = true;
            buttonLocChuyen.Enabled = false;
            textBoxIDChuyen.Enabled = false;
            textBoxIDChuyen.Text = string.Empty;
            dateTimePickerNgayDiemDanh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayDiemDanh.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            nhanThem = 0;

            loadForm();
        }

        private void phancongTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                idPhanCong = phancongTable.Rows[dong].Cells[0].Value.ToString();


            }
            catch
            {

            }
            if (idPhanCong != string.Empty)
            {
                dataGridViewDiemDanh.DataSource = service2.doDuLieu(int.Parse(idPhanCong));
                dataGridViewDiemDanh.ReadOnly = true;
            }
        }

        private void buttonLocChuyen_Click(object sender, EventArgs e)
        {
            TimChuyen form = new TimChuyen(this);
            form.mydata = new TimChuyen.GETDATA(GETVALUE);
            form.ShowDialog();
        }

        private void chuaphancongTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                idHopDong_CPC = chuaphancongTable.Rows[dong].Cells[0].Value.ToString();
                NgayBatDau_CPC = chuaphancongTable.Rows[dong].Cells[1].Value.ToString();
                NgayKetThuc_CPC = chuaphancongTable.Rows[dong].Cells[2].Value.ToString();
                idChiTiet_CPC = chuaphancongTable.Rows[dong].Cells[3].Value.ToString();

                Thu_CPC = chuaphancongTable.Rows[dong].Cells[4].Value.ToString();
                Buoi_CPC = chuaphancongTable.Rows[dong].Cells[5].Value.ToString();
                Phuong_CPC = chuaphancongTable.Rows[dong].Cells[6].Value.ToString();
                Truong_CPC = chuaphancongTable.Rows[dong].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        List<DateTime> GetNextDays(DateTime startDate, DateTime endDate)
        {
            List<DateTime> days = new List<DateTime>();

            DateTime currentDate = startDate;
            DayOfWeek targetDay = new DayOfWeek();
            if (Thu_CPC == "2")
            {
                targetDay = DayOfWeek.Monday;
            }
            if (Thu_CPC == "3")
            {
                targetDay = DayOfWeek.Tuesday;
            }
            if (Thu_CPC == "4")
            {
                targetDay = DayOfWeek.Wednesday;
            }
            if (Thu_CPC == "5")
            {
                targetDay = DayOfWeek.Thursday;
            }
            if (Thu_CPC == "6")
            {
                targetDay = DayOfWeek.Friday;
            }
            if (Thu_CPC == "7")
            {
                targetDay = DayOfWeek.Saturday;
            }
            int count = 0;
            int totalDays = (endDate - startDate).Days;
            if (totalDays == 30)
            {
                count = 4;
            }
            else if (totalDays == 90)
            {
                count = 12;
            }
            else if (totalDays == 180)
            {
                count = 24;
            }
            if (currentDate.DayOfWeek != targetDay)
            {
                currentDate = currentDate.AddDays((int)targetDay - (int)currentDate.DayOfWeek);
                if (currentDate < startDate)
                {
                    currentDate = currentDate.AddDays(7);
                }
            }


            while (currentDate <= endDate && days.Count < count)
            {
                days.Add(currentDate);
                currentDate = currentDate.AddDays(7);
            }

            return days;
        }


        private void buttonThem_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.ParseExact(NgayBatDau_CPC, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(NgayKetThuc_CPC, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            List<DateTime> ngay = GetNextDays(startDate, endDate);
            //NgayDuaDon_CPC = ngay[0].ToString("yyyy-MM-dd");
            if (nhanThem == 0)
            {
                nhanThem = 1;
                buttonLocChuyen.Enabled = true;
            }
            else
            {
                if (textBoxIDChuyen.Text == string.Empty || textBoxIDChuyen.Text == "Không có chuyến" || textBoxIDChuyen.Text == "Chưa chọn chuyến")
                {
                    MessageBox.Show("Không thể thêm");
                    nhanThem = 0;
                    loadForm();
                    return;
                }
                else
                {
                    int flag = 0;

                    foreach (DateTime day in ngay)
                    {
                        string NgayDuaDon = day.ToString("yyyy-MM-dd");
                        int kq = new PhanCongBUS().themPhanCong(idChiTiet_CPC, textBoxIDChuyen.Text, NgayDuaDon);
                        if (kq <= 0)
                        {
                            flag = 1;
                        }
                    }

                    if (flag == 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        nhanThem = 0;
                        loadForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                        nhanThem = 0;
                        loadForm();
                    }
                }
            }
        }

        private void buttonDiemDanh_Click(object sender, EventArgs e)
        {
            if (idTinhTrang == string.Empty)
            {
                MessageBox.Show("Hãy chọn tình trạng điểm danh");
                return;

            }
            string thoigian = dateTimePickerNgayDiemDanh.Value.ToString("yyyy-MM-dd HH:mm:ss");
            int kq = new DiemDanhBUS().themDiemDanh(idPhanCong, thoigian, idTinhTrang);
            if (kq > 0)
            {
                MessageBox.Show("Điểm danh thành công");
                int idDD = new DiemDanhBUS().getIDDiemDanhByID(idPhanCong);
                DataTable thongtin = new DiemDanhBUS().getThongTinDiemDanhByID(idDD.ToString());
                string tenThongBao = "Điểm danh: Em " + thongtin.Rows[0][1].ToString() + "(ID=" + thongtin.Rows[0][0].ToString() + "), thời gian :" + thongtin.Rows[0][2].ToString() + ", tình trạng: " + thongtin.Rows[0][3].ToString();
                string loai = "2";
                string idDiemDanh = idDD.ToString();
                int tbdd = new ThongBaoBUS().themThongBaoDiemDanh(tenThongBao, loai, idDiemDanh);
                if (tbdd > 0)
                {
                    MessageBox.Show("Đã gửi thông báo tình trạng điểm danh đến phụ huynh");
                }
                dataGridViewDiemDanh.DataSource = service2.doDuLieu(int.Parse(idPhanCong));
                dataGridViewDiemDanh.ReadOnly = true;
            }
            else
            {

                MessageBox.Show("Điểm danh thất bại");
            }
        }

        private void dataGridViewDiemDanh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                idDiemDanh = dataGridViewDiemDanh.Rows[dong].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void buttonXoaDD_Click(object sender, EventArgs e)
        {
            if (idDiemDanh == string.Empty)
            {
                MessageBox.Show("Hãy chọn hàng điểm danh cần xóa");
                return;
            }
            else
            {
                int kq = new DiemDanhBUS().xoaDiemDanh(idDiemDanh);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewDiemDanh.DataSource = service2.doDuLieu(int.Parse(idPhanCong));
                    dataGridViewDiemDanh.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void comboBoxDiemDanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTinhTrang = (comboBoxDiemDanh.SelectedIndex + 1).ToString();

        }



        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (idPhanCong == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng dữ liệu trong bảng ĐẢ PHÂN CÔNG");
                return;
            }
            else
            {
                int kq = new PhanCongBUS().xoaPhanCong(idPhanCong);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    loadForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    loadForm();
                }
            }
        }

        private void PhanCong_DiemDanh_Load(object sender, EventArgs e)
        {

        }
    }
}
