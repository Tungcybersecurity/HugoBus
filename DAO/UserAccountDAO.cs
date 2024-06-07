using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserAccountDAO
    {
        public DataTable doDuLieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Parents GetParentByUserName(string tendangnhap)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select * from phuhuynh where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string ho = reader["ho"].ToString();
                    string ten = reader["ten"].ToString();
                    string gioitinh = reader["gioitinh"].ToString();
                    string ngaysinh = reader["ngaysinh"].ToString();
                    string email = reader["email"].ToString();
                    string sdt = reader["sdt"].ToString();
                    string diachi = reader["diachi"].ToString();
                    string pathimage = reader["filepathimage"].ToString();

                    Parents parent = new Parents(tendangnhap, ho, ten, gioitinh, ngaysinh, email, sdt, diachi, pathimage);
                    return parent;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public string getPassword(string tendangnhap)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select matkhau from taikhoanphuhuynh where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    return reader["matkhau"].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdatePassword(string tendangnhap,string matkhau)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "update taikhoanphuhuynh set matkhau = @matkhau where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand( sql, con);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        } 

        public bool DeleteParentByUserName(string tendangnhap)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "delete from phuhuynh where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateParentByUserName(Parents parent,string tendangnhap)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "update phuhuynh set ho = @ho, ten = @ten, gioitinh = @gioitinh, ngaysinh = @ngaysinh, email = @email, sdt = @sdt, diachi = @diachi, filepathimage = @filepathimage where tendangnhap = @tendangnhap";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ho", parent.Ho);
                cmd.Parameters.AddWithValue("@ten", parent.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", parent.Gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", parent.Ngaysinh);
                cmd.Parameters.AddWithValue("@email", parent.Email);
                cmd.Parameters.AddWithValue("@sdt", parent.Sdt);
                cmd.Parameters.AddWithValue("@diachi", parent.Diachi);
                cmd.Parameters.AddWithValue("@filepathimage", parent.Pathimage);
                cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable doDuLieuTimKiem(string loai,string value)
        {
            string sql = "query";
            if (loai == "Tên")
            {
                string[] result = value.Split(" ", StringSplitOptions.None);
                if (result.Length > 1)
                {
                    string ten = result[result.Length - 1];
                    string ho = string.Join(" ", result, 0, result.Length - 1);
                    sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where ho = @ho and ten = @ten";
                }
                else
                {
                    sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where ten = @ten";
                }
            }
            else if (loai == "Số điện thoại")
            {
                sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where sdt = @sdt";
            }
            else if (loai == "Email")
            {
                sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where email = @value";
            }
            else if (loai == "Địa chỉ")
            {
                sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where diachi = @value";
            }
            else if (loai == "Tên đăng nhập")
            {
                sql = "select tendangnhap,ho,ten,gioitinh,ngaysinh,email,sdt,diachi from phuhuynh where tendangnhap = @value";
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
                else if (loai == "Số điện thoại")
                {
                    cmd.Parameters.AddWithValue("@sdt", value);
                }
                else if (loai == "Email" || loai == "Địa chỉ" || loai == "Tên đăng nhập")
                {
                    cmd.Parameters.AddWithValue("@value", value);
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


    }
}
