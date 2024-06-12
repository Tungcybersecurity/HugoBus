using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChuyenDAO
    {
        public DataTable doDuLieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT c.idChuyen AS 'ID chuyến', CONCAT(tx.Ho, ' ', tx.Ten) AS 'Họ tên tài xế', CONCAT(bm.Ho, ' ', bm.Ten) AS 'Họ tên bảo mẫu', c.ThuHoatDong AS 'Thứ', CASE WHEN c.BuoiHoatDong = 1 THEN 'Sáng' WHEN c.BuoiHoatDong = 2 THEN 'Chiều' END AS 'Buổi', x.BienSo AS 'Biển số xe', td.PhuongDon AS 'Phường đón', td.TenTruongDen AS 'Trường đến' FROM chuyen AS c JOIN taixe AS tx ON c.idTaiXe = tx.idTaiXe JOIN baomau AS bm ON c.idBaoMau = bm.idBaoMau JOIN xe AS x ON c.idXe = x.idXe JOIN tuyenduong AS td ON c.idTuyenDuong = td.idTuyenDuong;";
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
        public DataTable getIDChuyenByInformation(int idTuyen, int ThuHoatDong, int BuoiHoatDong)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT idChuyen FROM chuyen WHERE idTuyenDuong = @idTuyenDuong AND ThuHoatDong = @ThuHoatDong AND BuoiHoatDong = @BuoiHoatDong";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idTuyenDuong", idTuyen);
                cmd.Parameters.AddWithValue("@ThuHoatDong", ThuHoatDong);
                cmd.Parameters.AddWithValue("@BuoiHoatDong", BuoiHoatDong);
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
