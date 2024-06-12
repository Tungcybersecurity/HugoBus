using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Chuyen
{
    public partial class Chuyen : Form
    {
        ChuyenBUS service = new ChuyenBUS();
        public Chuyen()
        {
            InitializeComponent();
            loadForm();
        }
        void loadForm()
        {
            tripTable.DataSource = service.doDuLieu();
            tripTable.ReadOnly = true;
        }

        private void tripTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                textBoxTaiXe.Text = tripTable.Rows[dong].Cells[1].Value.ToString();
                textBoxBaoMau.Text = tripTable.Rows[dong].Cells[2].Value.ToString();
                textBoxThu.Text = tripTable.Rows[dong].Cells[3].Value.ToString();
                textBoxBuoi.Text = tripTable.Rows[dong].Cells[4].Value.ToString();
                textBoxXe.Text = tripTable.Rows[dong].Cells[5].Value.ToString();
                textBoxPhuong.Text = tripTable.Rows[dong].Cells[6].Value.ToString();
                textBoxTruong.Text = tripTable.Rows[dong].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
