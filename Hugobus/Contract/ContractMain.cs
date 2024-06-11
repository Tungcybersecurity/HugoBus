using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using BUS;
namespace GUI.Contract
{
    public partial class ContractMain : Form
    {
        ContractBUS service = new ContractBUS();
        public string idhopdong;
        public string idhocsinh;
        public string ngaytao;
        public string ngaybatdau;
        public string ngayketthuc;
        public string ngaycapnhat;
        public string tramdon;
        public string truongden;
        public string trangthai;
        public ContractMain()
        {
            InitializeComponent();
            
            loadForm();
        }

        public void loadForm()
        {
            contractTable.DataSource = service.duLieu();
            contractTable.ReadOnly = true;
            foreach (DataGridViewRow row in contractTable.Rows)
            {
                DataGridViewCell cell = row.Cells["Trạng thái"];
                string status = cell.Value.ToString();
                switch (status)
                {
                    case "Chờ thanh toán":
                        cell.Style.BackColor = Color.Red;
                        break;
                    case "Đang hiệu lực":
                        cell.Style.BackColor = Color.Green;
                        break;
                    case "Hết hiệu lực":
                        cell.Style.BackColor = Color.White;
                        break;
                    case "Chờ xác nhận":
                        cell.Style.BackColor = Color.Yellow;
                        break;
                    default:
                        cell.Style.BackColor = Color.Transparent;
                        break;
                }
            }
        }

        private void contractTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                idhopdong = contractTable.Rows[dong].Cells[0].Value.ToString();
                tbxIDHopDong.Text = idhopdong;
                idhocsinh = contractTable.Rows[dong].Cells[1].Value.ToString();
                tbxIDHocSinh.Text = idhocsinh;
                ngaytao = contractTable.Rows[dong].Cells[2].Value.ToString();
                tbxNgayTao.Text = ngaytao;
                ngaybatdau = contractTable.Rows[dong].Cells[3].Value.ToString();
                tbxNgayBatDau.Text = ngaybatdau;
                ngayketthuc = contractTable.Rows[dong].Cells[4].Value.ToString();
                tbxNgayKetThuc.Text = ngayketthuc;
                ngaycapnhat = contractTable.Rows[dong].Cells[5].Value.ToString();
                tramdon = contractTable.Rows[dong].Cells[6].Value.ToString();
                tbxTramDon.Text = tramdon;
                truongden = contractTable.Rows[dong].Cells[7].Value.ToString();
                tbxTruongDen.Text = truongden;
                trangthai = contractTable.Rows[dong].Cells[8].Value.ToString();
                tbxTrangThai.Text = trangthai;
            }
            catch
            {

            }
        }

        private void buttonChitiet_Click(object sender, EventArgs e)
        {
            ContractDetails form = new ContractDetails(this);
            form.ShowDialog();
        }

        private void contractTable_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            if (e.SortString.Length == 0)
            {
                return;
            }
            string[] strtok = e.SortString.Split(',');
            foreach (string str in strtok)
            {
                string[] columnorder = str.Split(']');
                ListSortDirection lds = ListSortDirection.Ascending;
                if (columnorder[1].Trim().Equals("DESC"))
                {
                    lds = ListSortDirection.Descending;
                }
                contractTable.Sort(contractTable.Columns[columnorder[0].Replace('[', ' ').Trim()], lds);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int row = new ContractBUS().xoaHopDong(idhopdong);
                if (row > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    loadForm();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công.");
                }
            }
        }
    }
}
