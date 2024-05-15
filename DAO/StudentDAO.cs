using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAO
{
    public class StudentDAO
    {
        public DataTable doDuLieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select * from hocsinh";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter dataAdapter  = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                con.Close();
                return dt;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }

        }

        public Parents thongTinChiTietHocSinh(String tendangnhap)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();

            try
            {
                con.Open();
                string sql = "select diachi,sdt,ho,ten from phuhuynh where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                MySqlDataReader reader = cmd.ExecuteReader();

                Parents pr = new Parents();
                while (reader.Read())
                {
                    pr.Sdt = reader["SDT"].ToString();
                    pr.Ho = reader["Ho"].ToString();
                    pr.Ten = reader["Ten"].ToString();
                    pr.Diachi = reader["DiaChi"].ToString();
                }

                return pr;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { 
                
                con.Close() ;
                
            }
        }

        public bool xoaHocSinh(int id)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();

            try
            {
                con.Open();
                string sql = "delete from hocsinh where idhocsinh = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally { 
                con.Close();
            }
        }

        public DataTable doDuLieuTimKiem(string loai , string value)
        {
            string sql = "query";
            if (loai == "Tên")
            {
                string[] result = value.Split(" ", StringSplitOptions.None);
                if (result.Length > 1)
                {
                    string ten = result[result.Length - 1];
                    string ho = string.Join(" ", result, 0, result.Length - 1);
                    sql = "select * from hocsinh where ho=@ho and ten = @ten";
                }
                else
                {
                    sql = "select * from hocsinh where ten = @ten";
                }
            }
            else if (loai == "Trường")
            {
                sql = "select * from hocsinh where truong = @truong";
            }
            else if (loai == "Tên đăng nhập")
            {
                sql = "select * from hocsinh where tendangnhap = @tendangnhap";
            }
            else
            {
                sql = "select * from hocsinh where idhocsinh = @id";
            }

            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Tạo các tham số và thêm chúng vào Parameters của MySqlCommand
                if (loai == "Tên")
                {
                    string[] result = value.Split(" ", StringSplitOptions.None);
                    if (result.Length > 1)
                    {
                        string ten = result[result.Length - 1];
                        string ho = string.Join(" ", result, 0, result.Length - 1);
                        cmd.Parameters.AddWithValue("@ho", ho);
                        cmd.Parameters.AddWithValue("@ten", ten);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ten", value);
                    }
                }
                else if (loai == "Trường")
                {
                    cmd.Parameters.AddWithValue("@truong", value);
                }
                else if (loai == "Tên đăng nhập")
                {
                    cmd.Parameters.AddWithValue("@tendangnhap", value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@id", value);
                }

                // Thực hiện truy vấn và lấy dữ liệu
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                // Đóng kết nối sau khi hoàn thành
                con.Close();
            }

        }
        public static void Main(string[] args)
        { 
        }
    }
}
