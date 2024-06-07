using BUS;
using DTO;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI.Employee.TaiXe
{
    public partial class Detail : Form
    {
        EmployeeDriverBus service = new EmployeeDriverBus();
        int id = 0;
        string filepathold = "";
        public void setForm(Driver driver)
        {
            id = driver.Idtaixe;
            textBoxHo.Text = driver.Ho;
            textBoxTen.Text = driver.Ten;
            textBoxDiaChi.Text = driver.Diachi;
            textBoxCCCD.Text = driver.Cccd;
            textBoxGioiTinh.Text = driver.Gioitinh;
            textBoxEmail.Text = driver.Email;
            textBoxNgaySInh.Text = driver.Ngaysinh;
            textBoxSDT.Text = driver.Sdt;
            filepathold = driver.Pathimage;
            bool isImageLoaded = false; // Biến boolean để đánh dấu xem hình ảnh đã được tải hay chưa

            string filePath = driver.Pathimage; // Đường dẫn tới tệp hình ảnh từ đối tượng driver
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
        public Detail(Driver driver)
        {
            InitializeComponent();
            setForm(driver);

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
            Driver driver = new Driver();
            driver.Idtaixe = id;
            driver.Ho = textBoxHo.Text;
            driver.Ten = textBoxTen.Text;
            driver.Cccd = textBoxCCCD.Text;
            driver.Diachi = textBoxDia.Text;
            driver.Gioitinh = textBoxGioiTinh.Text;
            driver.Email = textBoxEmail.Text;
            driver.Ngaysinh = textBoxNgaySInh.Text;
            driver.Sdt = textBoxSDT.Text;
            driver.Pathimage = filepathold;
            if (pictureBox1.ImageLocation != null)
            {
                driver.Pathimage = pictureBox1.ImageLocation;
            }

            bool isValid = true;
            reset(); // Reset thông báo lỗi trước khi kiểm tra lại

            if (!k.kiemTraTen(driver.Ho))
            {
                labelErroHo.ForeColor = Color.Red;
                labelErroHo.Text = "Nhập họ không chính xác";
                isValid = false;
            }
            if (!k.kiemTraTen(driver.Ten))
            {
                labelErrorTen.ForeColor = Color.Red;
                labelErrorTen.Text = "Nhập tên không chính xác";
                isValid = false;
            }
            if (!k.kiemTraDiaChi(driver.Diachi))
            {
                labelErroDiaChi.ForeColor = Color.Red;
                labelErroDiaChi.Text = "Nhập địa chỉ không chính xác";
                isValid = false;
            }
            if(driver.Gioitinh!="Nam" && driver.Gioitinh!="Nữ")
            {
                labelErrorGioiTinh.ForeColor = Color.Red;
                labelErrorGioiTinh.Text = "Giới tính không hợp lệ";
                isValid = false;
            }
            if (!k.kiemTraSDT(driver.Sdt))
            {
                labelErrorSDT.ForeColor = Color.Red;
                labelErrorSDT.Text = "Nhập số điện thoại không chính xác";
                isValid = false;
            }
            if (!k.kiemTraEmail(driver.Email))
            {
                labelErroEmail.ForeColor = Color.Red;
                labelErroEmail.Text = "Nhập địa chỉ email không chính xác";
                isValid = false;
            }
            if (!k.kiemTraCCCD(driver.Cccd))
            {
                labelErrorCCCD.ForeColor = Color.Red;
                labelErrorCCCD.Text = "Nhập căn cước không chính xác";
                isValid = false;
            }
            if(driver.Ngaysinh.Length != 10)
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

            if(isValid)
            {
                if (service.sua(driver) == true)
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
