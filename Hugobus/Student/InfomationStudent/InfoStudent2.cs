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
using System.Net;

namespace GUI.Student.InfomationStudent
{
    public partial class InfoStudent2 : Form
    {
        Students getst= new Students();
        Parents getpr = new Parents();
        StudentBUS service = new StudentBUS();
        public InfoStudent2(Students st,Parents pr)
        {
            InitializeComponent();
            getst = st;
            getpr = pr;
            setFieldText();
        }

        private void setFieldText()
        {
            textBoxDiaChi.Text = getpr.Diachi;
            textBoxPhuHuynh.Text = getpr.Ho + " " + getpr.Ten;
            textBoxSDT.Text = getpr.Sdt;
            textBoxHọ.Text = getst.Ho;
            textBoxTen.Text= getst.Ten;
            textBoxGioiTinh.Text=getst.Gioitinh;
            textBoxNgaysinh.Text=getst.Ngaysinh;
            textBoxTruong.Text=getst.Truong;
            textBoxLop.Text = getst.Lop;
            labelAccount.Text = "Account:" + getst.Tendangnhap;
            if (!string.IsNullOrEmpty(getst.Filepathimage))
            {
                var request = WebRequest.Create(getst.Filepathimage);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            

        }
        private void InfoStudent2_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
