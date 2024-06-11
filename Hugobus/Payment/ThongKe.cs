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
                chartTong.Series.Clear();
                chartTong.Series.Add("VND");
                foreach (DataGridViewRow row in dataGridViewTong.Rows)
                {
                    try
                    {
                        chartTong.Series["VND"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                    catch
                    {

                    }
                }
            }
            if (radioButtonTongQuy.Checked == true)
            {
                dataGridViewTong.DataSource = service.getTongTungQuy();
                dataGridViewTong.ReadOnly = true;
                chartTong.Series.Clear();
                chartTong.Series.Add("VND");
                foreach (DataGridViewRow row in dataGridViewTong.Rows)
                {
                    try
                    {
                        chartTong.Series["VND"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                    catch
                    {

                    }
                }
            }
            if (radioButtonTongThang.Checked == true)
            {
                dataGridViewTong.DataSource = service.getTongTungThang();
                dataGridViewTong.ReadOnly = true;
                chartTong.Series.Clear();
                chartTong.Series.Add("VND");
                foreach (DataGridViewRow row in dataGridViewTong.Rows)
                {
                    try
                    {
                        chartTong.Series["VND"].Points.AddXY(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                    catch
                    {

                    }

                }
            }
        }

        private void buttonLoadTT_Click(object sender, EventArgs e)
        {
            if (radioButtonTTNam.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTNam();
                dataGridViewTT.ReadOnly = true;
                DataTable dataTable = (DataTable)dataGridViewTT.DataSource;
                chartTT.Series.Clear();

                Series growthSeries = new Series("Tỷ lệ tăng trưởng(%)");
                growthSeries.ChartType = SeriesChartType.Line;

                foreach (DataRow row in dataTable.Rows)
                {
                    string year = row["Nam"].ToString();
                    decimal growthRate = Convert.ToDecimal(row["TyLeTangTruong"]);
                    growthSeries.Points.AddXY(year, growthRate);
                }

                chartTT.Series.Add(growthSeries);
                chartTT.ChartAreas[0].AxisX.Title = "Năm";
                chartTT.ChartAreas[0].AxisY.Title = "Tỷ lệ tăng trưởng (%)";
            }
            if (radioButtonTTQuy.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTQuy();
                dataGridViewTT.ReadOnly = true;
                DataTable dataTable = (DataTable)dataGridViewTT.DataSource;
                chartTT.Series.Clear();

                Series growthSeries = new Series("Tỷ lệ tăng trưởng(%)");
                growthSeries.ChartType = SeriesChartType.Line;

                foreach (DataRow row in dataTable.Rows)
                {
                    string quarter = row["Quy"].ToString();
                    decimal growthRate = Convert.ToDecimal(row["TyLeTangTruong"]);
                    growthSeries.Points.AddXY(quarter, growthRate);
                }

                chartTT.Series.Add(growthSeries);
                chartTT.ChartAreas[0].AxisX.Title = "Quý/Năm";
                chartTT.ChartAreas[0].AxisY.Title = "Tỷ lệ tăng trưởng (%)";

            }
            if (radioButtonTTThang.Checked == true)
            {
                dataGridViewTT.DataSource = service.getTTThang();
                dataGridViewTT.ReadOnly = true;
                DataTable dataTable = (DataTable)dataGridViewTT.DataSource;
                chartTT.Series.Clear();

                Series growthSeries = new Series("Tỷ lệ tăng trưởng(%)");
                growthSeries.ChartType = SeriesChartType.Line;

                foreach (DataRow row in dataTable.Rows)
                {
                    string monthYear = row["Thang"].ToString();
                    decimal growthRate = Convert.ToDecimal(row["TyLeTangTruong"]);
                    growthSeries.Points.AddXY(monthYear, growthRate);
                }

                chartTT.Series.Add(growthSeries);
                chartTT.ChartAreas[0].AxisX.Title = "Tháng/Năm";
                chartTT.ChartAreas[0].AxisY.Title = "Tỷ lệ tăng trưởng(%)";
            }
        }
    }
}
