using BUS;
using DTO;
using GUI.UserAccount.Detail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserAccount
{
    public partial class useraccount : Form
    {
        UserAccountBUS service = new UserAccountBUS();
        public useraccount()
        {
            InitializeComponent();
            dataGridViewUser.DataSource = service.doDuLieu();
        }

        private void contentclick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewUser.Columns[e.ColumnIndex].Name == "ColumnChiTiet")
            {
                string tendangnhap = dataGridViewUser.Rows[e.RowIndex].Cells["Columnaccount"].Value.ToString();
                Parents pr = service.GetParentByUserName(tendangnhap);
                if (pr != null)
                {
                    UserAccount.Detail.Detail new_form = new Detail.Detail(pr);
                    new_form.ShowDialog();
                }

            }
            else if (dataGridViewUser.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewUser.Columns[e.ColumnIndex].Name == "ColumnDelete")
            {

                string tendangnhap = dataGridViewUser.Rows[e.RowIndex].Cells["Columnaccount"].Value.ToString();
                if (service.DeleteParentByUserName(tendangnhap) == true)
                {
                    MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = service.doDuLieu();
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string select = comboBoxTimKiem.SelectedItem.ToString();
            string value = textBoxTimKiem.Text;
            dataGridViewUser.DataSource = service.getSearch(select, value);
        }

        private void contenClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUser.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewUser.Columns[e.ColumnIndex].Name == "ColumnChiTiet")
            {
                string tendangnhap = dataGridViewUser.Rows[e.RowIndex].Cells["Columnaccount"].Value.ToString();
                Parents pr = service.GetParentByUserName(tendangnhap);
                if (pr != null)
                {
                    UserAccount.Detail.Detail new_form = new Detail.Detail(pr);
                    new_form.ShowDialog();
                }

            }
            else if (dataGridViewUser.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridViewUser.Columns[e.ColumnIndex].Name == "ColumnDelete")
            {

                string tendangnhap = dataGridViewUser.Rows[e.RowIndex].Cells["Columnaccount"].Value.ToString();
                if (service.DeleteParentByUserName(tendangnhap) == true)
                {
                    MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
