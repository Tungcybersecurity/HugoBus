using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Employee.BaoMau.anh
{
    public partial class Detail : Form
    {
        EmployeeNannyBUS service = new EmployeeNannyBUS();
        int id = 0;
        string filepathold = "";
        public void setForm(Nanny nanny)
        {
            id = nanny.Idbaomau;
            textBoxHo.Text = nanny.Ho;
            textBoxTen.Text = nanny.Ten;
            textBoxDia.Text = nanny.Diachi;
            textBoxCCCD.Text = nanny.Cccd;
            textBoxGioiTinh.Text = nanny.Gioitinh;
            textBoxEmail.Text = nanny.Email;
            textBoxNgaySInh.Text = nanny.Ngaysinh;
            textBoxSDT.Text = nanny.Sdt;
            filepathold = nanny.Pathimage;
            bool isImageLoaded = false; // Biến boolean để đánh dấu xem hình ảnh đã được tải hay chưa

            string filePath = nanny.Pathimage; // Đường dẫn tới tệp hình ảnh từ đối tượng driver
            try
            {
                if (!string.IsNullOrEmpty(filePath))
                {
                    // Tạo một đối tượng hình ảnh từ đường dẫn
                    Image image = Image.FromFile(filePath);

                    // Gán hình ảnh cho PictureBox
                    pictureBox1.Image = image;

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
        public Detail(Nanny nanny)
        {
            InitializeComponent();
            setForm(nanny);

        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        public void reset()
        {
            labelErrorNgaySinh.Text = "";
            labelErrorTen.Text = "";
            labelErroDiaChi.Text = "";
            labelErrorSDT.Text = "";
            labelErroEmail.Text = "";
            labelErrorCCCD.Text = "";
            labelErroHo.Text = "";
            labelErrorGioiTinh.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Kiemtra k = new Kiemtra();
            Nanny nanny = new Nanny();
            nanny.Idbaomau = id;
            nanny.Ho = textBoxHo.Text;
            nanny.Ten = textBoxTen.Text;
            nanny.Cccd = textBoxCCCD.Text;
            nanny.Diachi = textBoxDia.Text;
            nanny.Gioitinh = textBoxGioiTinh.Text;
            nanny.Email = textBoxEmail.Text;
            nanny.Ngaysinh = textBoxNgaySInh.Text;
            nanny.Sdt = textBoxSDT.Text;
            nanny.Pathimage = filepathold;
            if (pictureBox1.ImageLocation != null)
            {
                nanny.Pathimage = pictureBox1.ImageLocation;
            }

            bool isValid = true;
            reset(); // Reset thông báo lỗi trước khi kiểm tra lại

            if (!k.kiemTraTen(nanny.Ho))
            {
                labelErroHo.ForeColor = Color.Red;
                labelErroHo.Text = "Nhập họ không chính xác";
                isValid = false;
            }
            if (!k.kiemTraTen(nanny.Ten))
            {
                labelErrorTen.ForeColor = Color.Red;
                labelErrorTen.Text = "Nhập tên không chính xác";
                isValid = false;
            }
            if (!k.kiemTraDiaChi(nanny.Diachi))
            {
                labelErroDiaChi.ForeColor = Color.Red;
                labelErroDiaChi.Text = "Nhập địa chỉ không chính xác";
                isValid = false;
            }
            if (nanny.Gioitinh != "Nam" && nanny.Gioitinh != "Nữ")
            {
                labelErrorGioiTinh.ForeColor = Color.Red;
                labelErrorGioiTinh.Text = "Giới tính không hợp lệ";
                isValid = false;
            }
            if (!k.kiemTraSDT(nanny.Sdt))
            {
                labelErrorSDT.ForeColor = Color.Red;
                labelErrorSDT.Text = "Nhập số điện thoại không chính xác";
                isValid = false;
            }
            if (!k.kiemTraEmail(nanny.Email))
            {
                labelErroEmail.ForeColor = Color.Red;
                labelErroEmail.Text = "Nhập địa chỉ email không chính xác";
                isValid = false;
            }
            if (!k.kiemTraCCCD(nanny.Cccd))
            {
                labelErrorCCCD.ForeColor = Color.Red;
                labelErrorCCCD.Text = "Nhập căn cước không chính xác";
                isValid = false;
            }
            if (nanny.Ngaysinh.Length != 10)
            {
                labelErrorNgaySinh.ForeColor = Color.Red;
                labelErrorNgaySinh.Text = "Ngày sinh không hợp lệ";
                isValid = false;
            }
            if (pictureBox1 == null)
            {
                isValid = false;
                MessageBox.Show("Vui lòng thêm ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isValid)
            {
                if (service.sua(nanny) == true)
                {
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = open.FileName;
                // image file path

            }
        }
    }
}
