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

namespace GUI.Employee.BaoMau
{
    public partial class ADD : Form
    {
        EmployeeNannyBUS service = new EmployeeNannyBUS();
        string valuecccd = "";
        public ADD()
        {
            InitializeComponent();
            reset();
            comboBox1.SelectedIndex = 0; // Đặt giá trị mặc định
        }
        public void reset()
        {
            labelErrorHo.Text = "";
            labelErrorTen.Text = "";
            labelErroDiaChi.Text = "";
            labelErrorSDT.Text = "";
            labelErroEmail.Text = "";
            labelErrorCCCD.Text = "";
        }
       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Kiemtra k = new Kiemtra();
            string ho = textBoxHo.Text;
            string ten = textBoxTen.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            string ngaysinh = selectedDate.ToString("dd/MM/yyyy");
            string diachi = textBoxDia.Text;
            string sdt = textBoxSDT.Text;
            string email = textBoxEmail.Text;
            string gioitinh = comboBox1.SelectedItem.ToString();
            string cccd = textBoxCCCD.Text;


            bool isValid = true;
            reset(); // Reset thông báo lỗi trước khi kiểm tra lại

            if (!k.kiemTraTen(ho))
            {
                labelErrorHo.ForeColor = Color.Red;
                labelErrorHo.Text = "Nhập họ không chính xác";
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
            if (!k.kiemTraSDT(sdt))
            {
                labelErrorSDT.ForeColor = Color.Red;
                labelErrorSDT.Text = "Nhập số điện thoại không chính xác";
                isValid = false;
            }
            if (!k.kiemTraEmail(email))
            {
                labelErroEmail.ForeColor = Color.Red;
                labelErroEmail.Text = "Nhập địa chỉ email không chính xác";
                isValid = false;
            }
            if (!k.kiemTraCCCD(cccd))
            {
                labelErrorCCCD.ForeColor = Color.Red;
                labelErrorCCCD.Text = "Nhập căn cước không chính xác";
                isValid = false;
            }
            if (pictureBox1 == null)
            {
                isValid = false;
                MessageBox.Show("Vui lòng thêm ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (isValid)
            {
                // Giả sử idtaixe là tự động tăng trong cơ sở dữ liệu
                Nanny nanny = new Nanny(ho, ten, gioitinh, ngaysinh, cccd, email, sdt, diachi,valuecccd);

                if (service.themNanny(nanny))
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // image file path
                valuecccd = open.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxHo.Text = "";
            textBoxTen.Text = "";

            textBoxDia.Text = "";
            textBoxSDT.Text = "";
            textBoxEmail.Text = "";
            textBoxCCCD.Text = "";
        }
    }
}
