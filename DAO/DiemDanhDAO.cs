using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;
namespace DAO
{
    public class DiemDanhDAO
    {
        public int getIDDiemDanhMoiNhatByID(string idPhanCong)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT MAX(idDiemDanh) AS maxIdDiemDanh FROM ghinhandiemdanh WHERE idPhanCong = @idPhanCong;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idPhanCong", Int32.Parse(idPhanCong));
                MySqlDataReader reader = cmd.ExecuteReader();
                int idDiemDanh = -1;
                if (reader.Read())
                {
                    idDiemDanh = reader.GetInt32("maxIdDiemDanh");
                }
                con.Close();
                return idDiemDanh;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;

            }
        }
        public DataTable getThongTinDiemDanhByID(string idDiemDanh)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT hs.idHocSinh AS 'ID học sinh', CONCAT(hs.Ho, ' ', hs.Ten) AS 'Họ tên học sinh', dd.ThoiGianDiemDanh AS 'Thời gian điểm danh', ttd.TinhTrang AS 'Tình trạng điểm danh' FROM hocsinh AS hs JOIN hopdong AS hd ON hs.idHocSinh = hd.idHocSinh JOIN chitiethopdong AS cthd ON hd.idHopDong = cthd.idHopDong JOIN phancongduadon AS pcdd ON cthd.idChiTiet = pcdd.idChiTiet JOIN ghinhandiemdanh AS dd ON pcdd.idPhanCong = dd.idPhanCong JOIN tinhtrangdiemdanh AS ttd ON dd.idTinhTrangDiemDanh = ttd.idTinhTrangDiemDanh WHERE dd.idDiemDanh = @idDiemDanh;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idDiemDanh", Int32.Parse(idDiemDanh));
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
        public int xoaDiemDanh(string idDiemDanh)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "Delete from ghinhandiemdanh where idDiemDanh=@idDiemDanh";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idDiemDanh", Int32.Parse(idDiemDanh));
                
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
        public int themDiemDanh(string idPhanCong, string thoigian, string idTinhTrang)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "Insert into ghinhandiemdanh(idPhanCong, ThoiGianDiemDanh, idTinhTrangDiemDanh) value(@idPhanCong, @ThoiGianDiemDanh, @idTinhTrangDiemDanh);";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idPhanCong", Int32.Parse(idPhanCong));
                cmd.Parameters.AddWithValue("@ThoiGianDiemDanh", thoigian);
                cmd.Parameters.AddWithValue("idTinhTrangDiemDanh", Int32.Parse(idTinhTrang));
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
        public DataTable doDuLieu(int idPhanCong)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT diemdanh.idDiemDanh as'ID điểm danh', diemdanh.ThoiGianDiemDanh as 'Thời gian điểm danh', ttdd.TinhTrang as 'Tình trạng điểm danh' FROM ghinhandiemdanh as diemdanh, tinhtrangdiemdanh as ttdd WHERE ttdd.idTinhTrangDiemDanh=diemdanh.idTinhTrangDiemDanh AND diemdanh.idPhanCong=@idPhanCong;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idPhanCong", idPhanCong);
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
