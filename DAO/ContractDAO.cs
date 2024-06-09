using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;
using System.Web;
using System.Data;

namespace DAO
{
    public class ContractDAO
    {
        public DataTable doDuLieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT hd.idHopDong as 'ID hợp đồng', hd.idHocSinh as 'ID học sinh', hd.NgayTaoHopDong as 'Ngày tạo hợp đồng', hd.NgayBatDau as 'Ngày bắt đầu', hd.NgayKetThuc as 'Ngày kết thúc', hd.NgayCapNhatTrangThai as 'Ngày cập nhật trạng thái', td.TenTram as 'Trạm đón', t.TenTruong as 'Trường đến', tthd.TenTrangThai as 'Trạng thái' FROM hopdong as hd, trangthaihopdong as tthd, thongtindiadiemtram as td, thongtindiadiemtruong as t where hd.idTramDon=td.idTram and hd.idTruong=t.idTruong and hd.idTrangThai=tthd.idTrangThai;";
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
        public DataTable getHopDongHieuLuc() {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idHopDong from hopdong where idTrangThai = 3;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
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

        public DataTable getChiTietHopDongByID(string idHopDong)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select ThuTrongTuan,Buoi from chitiethopdong where idHopDong = @idHopDong";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idHopDong", Int32.Parse(idHopDong));
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

        public int deleteHopDong(string idHopDong)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "delete from chitiethopdong where idHopDong = @idHopDong";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idHopDong", Int32.Parse(idHopDong));
                int rs1 = cmd.ExecuteNonQuery();
                string sql2 = "delete from hopdong where idHopDong = @idHopDong";
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@idHopDong", Int32.Parse(idHopDong));
                int rs2 = cmd2.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public int updateHopDong(string idHopDong, int idTrangThai)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "update hopdong set NgayCapNhatTrangThai = NOW(), idTrangThai = @idTrangThai where idHopDong = @idHopDong";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@idTrangThai", idTrangThai);
                cmd.Parameters.AddWithValue("@idHopDong", Int32.Parse(idHopDong));
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
    }
}
