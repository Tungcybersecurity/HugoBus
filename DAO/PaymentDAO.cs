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

        public int themThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan) {
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
        public int suaThanhToan(string idHopDong, int soTienThanhToan, string ngayThanhToan, string phuongThucThanhToan, string idThanhToan) {
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
