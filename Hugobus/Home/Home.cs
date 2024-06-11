using GUI.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Home
{

    public partial class Home : Form
    {
        private bool isactive = false;
        private Form activeform=null;
        public Home()
        {
            InitializeComponent();
        }

        private void disableButton()
        {
            foreach (Control button in panelMenu.Controls)
            {
                if (button.GetType() == typeof(Button))
                {
                    button.BackColor = Color.MediumSeaGreen;
                }
            }
        }

        private void OpenChildForm(Form child, object btnSender)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            UpdateButtoApperance((Button)btnSender);
            activeform = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(child);
            this.panelDisplay.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void UpdateButtoApperance(Button button)
        {
          
                disableButton();
                button.BackColor = Color.LightGreen;
                //button.FlatAppearance.BorderColor = Color.White;
           
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new Student.StudentMain(), sender);
            labelHome.Text = "Thông tin học sinh";
        }

        private void buttonQlTaiKhoan_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new UserAccount.useraccount(),sender);
            labelHome.Text = "Thông tin tài khoản";
        }

        private void buttonQLHợpĐồng_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new Contract.ContractMain(), sender);
            labelHome.Text = "Thông tin hợp đồng";
        }

        private void buttonQLChuyen_Click(object sender, EventArgs e)
        {

            isactive = !isactive;
            OpenChildForm(new Chuyen.Chuyen(), sender);
            labelHome.Text = "Thông tin chuyến";
        }

        private void buttonQLPhanCong_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new PhanCong_DiemDanh.PhanCong_DiemDanh(), sender);
            labelHome.Text = "Quản lý phân công";
        }

        private void buttonQLDoanhThu_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new Payment.PaymentMain(), sender);
            labelHome.Text = "Doanh thu";
        }

        private void buttonQLNhanVien_Click(object sender, EventArgs e)
        {
            isactive = !isactive;
            OpenChildForm(new Employee.Employee(),sender);
            labelHome.Text = "Thông tin nhân viên";
        }
    }
}
