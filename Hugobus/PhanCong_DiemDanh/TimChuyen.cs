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
namespace GUI.PhanCong_DiemDanh
{
    public partial class TimChuyen : Form
    {
        PhanCong_DiemDanh form;
        int nhanTim = 0;
        public string idChuyenout = string.Empty;
        public delegate void GETDATA(string data);
        public GETDATA mydata;
        public TimChuyen(PhanCong_DiemDanh f)
        {
            form = f;
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            textBoxBuoi.Text = form.Buoi_CPC;
            textBoxPhuongDon.Text = form.Phuong_CPC;
            textBoxThu.Text = form.Thu_CPC;
            textBoxTruongDen.Text = form.Truong_CPC;
            int idTuyen = -1;
            idTuyen = new PhanCongBUS().getIDTuyenDuong(form.Truong_CPC, form.Phuong_CPC);
            int Buoi = (form.Buoi_CPC == "Sáng" ? 1 : 2);
            int Thu = int.Parse(form.Thu_CPC.Split(" ")[1]);
            comboBoxIDChuyen.DataSource = new ChuyenBUS().getIDChuyenByInfor(idTuyen, Thu, Buoi);
            comboBoxIDChuyen.DisplayMember = "idChuyen";
            comboBoxIDChuyen.ValueMember = "idChuyen";
        }

        private void buttonChonChuyen_Click(object sender, EventArgs e)
        {
            nhanTim = 1;
            int gheTrong = int.Parse(textBoxGheTrong.Text);
            if (gheTrong > 0)
            {
                idChuyenout = comboBoxIDChuyen.SelectedValue.ToString();
                mydata(idChuyenout);
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không thể chọn chuyến này do đã hết ghế.");
                idChuyenout = "Không có chuyến";
                return;
            }

        }

        private void comboBoxIDChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)comboBoxIDChuyen.SelectedItem;
            string idChuyenSelected = drv["idChuyen"].ToString();
            // string idChuyenSelected = comboBoxIDChuyen.SelectedValue.ToString();
            int tongGhe = new PhanCongBUS().tongGheByIdChuyen_NgayDuaDon(idChuyenSelected, form.NgayDuaDon_CPC);
            textBoxGheTrong.Text = (26 - tongGhe).ToString();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (nhanTim == 0)
            {
                idChuyenout = "Chưa chọn chuyến";
                mydata(idChuyenout);
                this.Hide();
                this.Close();
            }
            else
            {
                mydata(idChuyenout);
                this.Hide();
                this.Close();
            }
            
        }
    }
}
