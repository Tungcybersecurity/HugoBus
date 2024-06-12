using BUS;
using DTO;
using GUI.Student.InfomationStudent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace GUI.Student
{
    public partial class StudentMain : Form
    {
        StudentBUS service = new StudentBUS();
        public StudentMain()
        {
            InitializeComponent();
            dataGridViewHocSinh.DataSource = service.duLieu();

        }

        private void Event_CellClík(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void content(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHocSinh.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewHocSinh.Columns[e.ColumnIndex].Name == "ColumnChiTiet")
            {
                int rowIndex = e.RowIndex;
                Students st = new Students();

                st.Idhocsinh = int.Parse(dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnId"].Value.ToString());
                st.Ho = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnHo"].Value.ToString();
                st.Ten = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnTen"].Value.ToString();
                st.Gioitinh = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnGioiTinh"].Value.ToString();
                st.Ngaysinh = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnNgaySinh"].Value.ToString();
                st.Truong = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnTruong"].Value.ToString();
                st.Lop = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnLop"].Value.ToString();
                st.Tendangnhap = dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnTenDangNhap"].Value.ToString();
                st.Filepathimage = dataGridViewHocSinh.Rows[rowIndex].Cells["Columnfilepath"].Value.ToString();
                Parents pr = service.thongTinChiTietHocSinh(st.Tendangnhap);

                InfoStudent2 student2 = new InfoStudent2(st, pr);
                student2.ShowDialog();

            }
            else if (dataGridViewHocSinh.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewHocSinh.Columns[e.ColumnIndex].Name == "ColumnDelete")
            {
                int rowIndex = e.RowIndex;

                int idhocsinh = int.Parse(dataGridViewHocSinh.Rows[rowIndex].Cells["ColumnId"].Value.ToString());

                if (service.xoaHocSinh(idhocsinh) == true)
                {
                    MessageBox.Show("Dữ liệu đã được xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewHocSinh.DataSource = service.duLieu();
                }
                else
                {
                    MessageBox.Show("Không thể xoá dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewHocSinh.DataSource = service.duLieu();
            timer1.Start();
        }

        private void load(object sender, EventArgs e)
        {
            comboBoxTimKiem.SelectedIndex = 0;
            timer1.Start();
        }



        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string selected = comboBoxTimKiem.SelectedItem.ToString();
            string textbox = textBoxTimKiem.Text.ToString();
            if (!string.IsNullOrEmpty(selected) && !string.IsNullOrEmpty(textbox))
            {
                dataGridViewHocSinh.DataSource = service.duLieuTimKiem(selected, textbox);
            }
        }
    }
}
