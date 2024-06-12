using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongBaoDAO
    {
        public int themThongBaoHopDong(string TenThongBao, string loai, string idHopDong) {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "INSERT INTO thongbao(TenThongBao,idLoai) VALUES (@TenThongBao,@Loai);";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@TenThongBao", TenThongBao);
                cmd.Parameters.AddWithValue("@Loai", Int32.Parse(loai));
                int rs1 = cmd.ExecuteNonQuery();
                if (rs1 > 0)
                {
                    string sql2 = "SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                    object result = cmd2.ExecuteScalar();
                    int insertedID = Convert.ToInt32(result);
                    string sql3 = "INSERT INTO thongbao_hopdong(idThongBao, idHopDong) VALUES (@idThongBao,@idHopDong);";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, con);
                    cmd3.Parameters.AddWithValue("@idThongBao", insertedID);
                    cmd3.Parameters.AddWithValue("@idHopDong", Int32.Parse(idHopDong));
                    int rs3 = cmd3.ExecuteNonQuery();
                    con.Close();
                    return rs3;
                }
                else
                {
                    con.Close();
                    return 0;
                }    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int themThongBaoDiemDanh(string TenThongBao, string loai, string idDiemDanh)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql1 = "INSERT INTO thongbao(TenThongBao,idLoai) VALUES (@TenThongBao,@Loai);";
                MySqlCommand cmd = new MySqlCommand(sql1, con);
                cmd.Parameters.AddWithValue("@TenThongBao", TenThongBao);
                cmd.Parameters.AddWithValue("@Loai", Int32.Parse(loai));
                int rs1 = cmd.ExecuteNonQuery();
                if (rs1 > 0)
                {
                    string sql2 = "SELECT LAST_INSERT_ID();";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                    object result = cmd2.ExecuteScalar();
                    int insertedID = Convert.ToInt32(result);
                    string sql3 = "INSERT INTO thongbao_diemdanh(idThongBao, idDiemDanh) VALUES (@idThongBao,@idDiemDanh);";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, con);
                   
                    cmd3.Parameters.AddWithValue("@idThongBao", insertedID);
                    cmd3.Parameters.AddWithValue("@idDiemDanh", Int32.Parse(idDiemDanh));
                    int rs3 = cmd3.ExecuteNonQuery();
                    con.Close();
                    return rs3;
                }
                else
                {
                    con.Close();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
