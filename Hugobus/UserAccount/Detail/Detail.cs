using BUS;
using DTO;
using GUI.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserAccount.Detail
{
    public partial class Detail : Form
    {
        UserAccountBUS service = new UserAccountBUS();
        string tendangnhap = "";
        string filepath = "";

        public void setForm(Parents pr)
        {
            tendangnhap = pr.Tendangnhap;
            textBoxHo.Text = pr.Ho;
            textBoxTen.Text = pr.Ten;
            textBoxNgaySInh.Text = pr.Ngaysinh;
            textBoxDia.Text = pr.Diachi;
            textBoxGioiTinh.Text = pr.Gioitinh;
            textBoxSDT.Text = pr.Sdt;
            textBoxEmail.Text = pr.Email;
            textBoxTaiKhoan.Text = tendangnhap;
            textBoxMatKhau.Text = service.getPass(tendangnhap);
            bool isImageLoaded = false; // Biến boolean để đánh dấu xem hình ảnh đã được tải hay chưa

            string filePath = pr.Pathimage; // Đường dẫn tới tệp hình ảnh từ đối tượng driver
            try
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    var request = WebRequest.Create(filePath);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                    }

                    // Thiết lập chế độ hiển thị hình ảnh trong PictureBox (tuỳ chọn)
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Zoom để phù hợp với kích thước PictureBox

                    // Đánh dấu việc tải hình ảnh thành công
                    isImageLoaded = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Đã xảy ra lỗi khi tải hình ảnh: " + ex.Message);
            }

        }
        public Detail(Parents pr)
        {
            InitializeComponent();
            setForm(pr);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelSuaHo_Click(object sender, EventArgs e)
        {
            textBoxHo.ReadOnly = false;

        }

        private void labelSuaTen_Click(object sender, EventArgs e)
        {
            textBoxTen.ReadOnly = false;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void labelGioiTinh_Click(object sender, EventArgs e)
        {
            textBoxGioiTinh.ReadOnly = false;
        }

        private void labelSuaNgaySinh_Click(object sender, EventArgs e)
        {
            textBoxNgaySInh.ReadOnly = false;
        }

        private void labelSuaDiaChi_Click(object sender, EventArgs e)
        {
            textBoxDia.ReadOnly = false;
        }

        private void labelsuaSDT_Click(object sender, EventArgs e)
        {
            textBoxSDT.ReadOnly = false;
        }

        private void labelSuaEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = false;
        }

        public void reset()
        {
            labelErrorNgaySinh.Text = "";
            labelErrorTen.Text = "";
            labelErroDiaChi.Text = "";
            labelErrorSDT.Text = "";
            labelErrorEmail.Text = "";
            labelErroHo.Text = "";
            labelErrorGioiTinh.Text = "";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Kiemtra k = new Kiemtra();

            string ho = textBoxHo.Text;
            string ten = textBoxTen.Text;
            string gioitinh = textBoxGioiTinh.Text;
            string ngaysinh = textBoxNgaySInh.Text;
            string email = textBoxEmail.Text;
            string sdt = textBoxSDT.Text;
            string diachi = textBoxDia.Text;
            string matkhau = textBoxMatKhau.Text;
            string filepath = "";

            if (pictureBox1.ImageLocation != null)
            {
                filepath = pictureBox1.ImageLocation.ToString();
            }

            // Tạo đối tượng Parents từ các giá trị lấy được
            Parents parent = new Parents(tendangnhap, ho, ten, gioitinh, ngaysinh, email, sdt, diachi, filepath);

            bool isValid = true;
            reset(); // Reset thông báo lỗi trước khi kiểm tra lại

            if (!k.kiemTraTen(ho))
            {
                labelErroHo.ForeColor = Color.Red;
                labelErroHo.Text = "Nhập họ không chính xác";
                isValid = false;
            }
            if (!k.kiemTraTen(ten))
            {
                labelErrorTen.ForeColor = Color.Red;
                labelErrorTen.Text = "Nhập tên không chính xác";
                isValid = false;
            }
            if (!k.kiemTraDiaChi(diachi))
            {
                labelErroDiaChi.ForeColor = Color.Red;
                labelErroDiaChi.Text = "Nhập địa chỉ không chính xác";
                isValid = false;
            }
            if (gioitinh != "Nam" && gioitinh != "Nữ")
            {
                labelErrorGioiTinh.ForeColor = Color.Red;
                labelErrorGioiTinh.Text = "Giới tính không hợp lệ";
                isValid = false;
            }
            if (!k.kiemTraSDT(sdt))
            {
                labelErrorSDT.ForeColor = Color.Red;
                labelErrorSDT.Text = "Nhập số điện thoại không chính xác";
                isValid = false;
            }
            if (!k.kiemTraEmail(email))
            {
                labelErrorEmail.ForeColor = Color.Red;
                labelErrorEmail.Text = "Nhập địa chỉ email không chính xác";
                isValid = false;
            }
            if (ngaysinh.Length != 10)
            {
                labelErrorNgaySinh.ForeColor = Color.Red;
                labelErrorNgaySinh.Text = "Ngày sinh không hợp lệ";
                isValid = false;
            }


            if (isValid)
            {
                if (service.UpdateParentByUserName(parent, tendangnhap) == true && service.updatePass(tendangnhap, matkhau) == true)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelSuaMatKhau_Click(object sender, EventArgs e)
        {
            textBoxMatKhau.ReadOnly = false;
        }

        private void labelsuaTaiKhoan_Click(object sender, EventArgs e)
        {
            textBoxTaiKhoan.ReadOnly = false;
        }
    }
}
