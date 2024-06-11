using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaymentDAO
    {
        public DataTable getTongTungThang()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT CONCAT(LPAD(MONTH(NgayThanhToan), 2, '0'), '/', YEAR(NgayThanhToan)) AS ThangNam, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY YEAR(NgayThanhToan), MONTH(NgayThanhToan) ORDER BY YEAR(NgayThanhToan), MONTH(NgayThanhToan);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public DataTable getTongTungQuy()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT CONCAT('Q', QUARTER(NgayThanhToan), '/', YEAR(NgayThanhToan)) AS QuyNam, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY YEAR(NgayThanhToan), QUARTER(NgayThanhToan) ORDER BY YEAR(NgayThanhToan), QUARTER(NgayThanhToan);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public DataTable getTongTungNam()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT YEAR(NgayThanhToan) AS Nam, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY YEAR(NgayThanhToan) ORDER BY YEAR(NgayThanhToan);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public DataTable getTTNam()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "WITH RevenueByYear AS (SELECT YEAR(NgayThanhToan) AS Nam, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY YEAR(NgayThanhToan) ORDER BY YEAR(NgayThanhToan)) SELECT Nam, TongDoanhThu, IFNULL(((TongDoanhThu - LAG(TongDoanhThu) OVER (ORDER BY Nam)) / LAG(TongDoanhThu) OVER (ORDER BY Nam)) * 100, 0) AS TyLeTangTruong FROM RevenueByYear;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public DataTable getTTQuy()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "WITH RevenueByQuarter AS (SELECT CONCAT(YEAR(NgayThanhToan), '-Q', QUARTER(NgayThanhToan)) AS Quy, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY YEAR(NgayThanhToan), QUARTER(NgayThanhToan) ORDER BY YEAR(NgayThanhToan), QUARTER(NgayThanhToan)) SELECT Quy, TongDoanhThu, IFNULL(((TongDoanhThu - LAG(TongDoanhThu) OVER (ORDER BY Quy)) / LAG(TongDoanhThu) OVER (ORDER BY Quy)) * 100, 0) AS TyLeTangTruong FROM RevenueByQuarter;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public DataTable getTTThang()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "WITH RevenueByMonth AS (SELECT DATE_FORMAT(NgayThanhToan, '%Y-%m') AS Thang, SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan GROUP BY DATE_FORMAT(NgayThanhToan, '%Y-%m') ORDER BY DATE_FORMAT(NgayThanhToan, '%Y-%m')) SELECT Thang, TongDoanhThu, IFNULL(((TongDoanhThu - LAG(TongDoanhThu) OVER (ORDER BY Thang)) / LAG(TongDoanhThu) OVER (ORDER BY Thang)) * 100, 0) AS TyLeTangTruong FROM RevenueByMonth;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
        public DataTable doDuLieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT idThanhToan as 'ID thanh toán', idHopDong as 'ID hợp đồng', SoTienCanThanhToan as 'Số tiền thanh toán', NgayThanhToan as 'Ngày thanh toán', PhuongThucThanhToan as 'Phương thức thanh toán' FROM thanhtoan;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        public int themThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "INSERT INTO thanhtoan (NgayThanhToan, SoTienCanThanhToan, PhuongThucThanhToan, idHopDong) VALUES (@NgayThanhToan, @SoTienCanThanhToan, @PhuongThucThanhToan, @idHopDong)";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                cmd.Parameters.AddWithValue("@SoTienCanThanhToan", soTienThanhToan);
                cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                cmd.Parameters.AddWithValue("@idHopDong", idHopDong);
                int rs1 = cmd.ExecuteNonQuery();
                con.Close();
                return rs1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int suaThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan, string idThanhToan)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "UPDATE thanhtoan SET SoTienCanThanhToan = @SoTienCanThanhToan, PhuongThucThanhToan = @PhuongThucThanhToan, idHopDong = @idHopDong, NgayThanhToan = @NgayThanhToan WHERE idThanhToan = @idThanhToan;";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idThanhToan", idThanhToan);
                cmd.Parameters.AddWithValue("@NgayThanhToan", ngayThanhToan);
                cmd.Parameters.AddWithValue("@SoTienCanThanhToan", soTienThanhToan);
                cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                cmd.Parameters.AddWithValue("@idHopDong", idHopDong);
                int rs1 = cmd.ExecuteNonQuery();
                con.Close();
                return rs1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int xoaThanhToan(string idThanhToan)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "DELETE FROM thanhtoan WHERE idThanhToan = @idThanhToan;";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idThanhToan", idThanhToan);
                int rs1 = cmd.ExecuteNonQuery();
                con.Close();
                return rs1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public long tongThongKe(string NgayBatDau, string NgayKetThuc)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT SUM(SoTienCanThanhToan) AS TongDoanhThu FROM thanhtoan WHERE NgayThanhToan BETWEEN @NgayBatDau AND @NgayKetThuc";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    long tongDoanhThu = Convert.ToInt64(result);
                    return tongDoanhThu;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;

            }
        }
        public DataTable getDataThongKe(string NgayBatDau, string NgayKetThuc)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT idThanhToan as 'ID thanh toán', idHopDong as 'ID hợp đồng', SoTienCanThanhToan as 'Số tiền thanh toán', NgayThanhToan as 'Ngày thanh toán', PhuongThucThanhToan as 'Phương thức thanh toán' FROM thanhtoan WHERE NgayThanhToan BETWEEN @NgayBatDau AND @NgayKetThuc";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
        public DataTable getIDHopDong()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idHopDong from hopdong where idTrangThai=2;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
    }
}
