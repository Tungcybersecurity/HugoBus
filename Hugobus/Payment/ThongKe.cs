using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
namespace GUI.Payment
{
    public partial class ThongKe : Form
    {
        PaymentBUS service = new PaymentBUS();
        public ThongKe()
        {
            InitializeComponent();

        }

        private void buttonLoadTong_Click(object sender, EventArgs e)
        {
            if (radioButtonTongNam.Checked == true)
            {
                dataGridViewTong.DataSource = service.getTongTungNam();
                dataGridViewTong.ReadOnly = true;
                
            }
            if (radioButtonTongQuy.Checked == true)
            {
                dataGridViewTong.DataSource = service.getTongTungQuy();
                dataGridViewTong.ReadOnly = true;
                
            }
            if (radioButtonTongThang.Checked == true)
            {
                dataGridViewTong.DataSource = service.getTongTungThang();
                dataGridViewTong.ReadOnly = true;
            }
        }

        private void buttonLoadTT_Click(object sender, EventArgs e)
        {
            if (radioButtonTTNam.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTNam();
                dataGridViewTT.ReadOnly = true;
                
            }
            if (radioButtonTTQuy.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTQuy();
                dataGridViewTT.ReadOnly = true;
                

            }
            if (radioButtonTTThang.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTThang();
                dataGridViewTT.ReadOnly = true;
                
            }
        }
    }
}
