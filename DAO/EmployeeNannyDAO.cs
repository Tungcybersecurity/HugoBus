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
    public class EmployeeNannyDAO
    {
        public DataTable doDulieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idbaomau,ho,ten,gioitinh,ngaysinh,cccd,email,sđt,diachi from baomau";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Boolean xoa(int id)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "delete from baomau where idbaomau = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean them(Nanny nanny)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "insert into baomau(ho,ten,gioitinh,ngaysinh,cccd,email,sđt,filepathimage,diachi) values(@ho,@ten,@gioitinh,@ngaysinh,@cccd,@email,@sdt,@path,@diachi)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ho", nanny.Ho);
                cmd.Parameters.AddWithValue("@ten", nanny.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", nanny.Gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nanny.Ngaysinh);
                cmd.Parameters.AddWithValue("@cccd", nanny.Cccd);
                cmd.Parameters.AddWithValue("@email", nanny.Email);
                cmd.Parameters.AddWithValue("@sdt", nanny.Sdt);
                cmd.Parameters.AddWithValue("@path", nanny.Pathimage);
                cmd.Parameters.AddWithValue("@diachi", nanny.Diachi);
                cmd.CommandType = CommandType.Text;

                if (cmd.ExecuteNonQuery() > 0) { return true; }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Nanny doTextField(int id)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idbaomau,ho,ten,gioitinh,ngaysinh,cccd,email,sđt,filepathimage,diachi from baomau where idbaomau = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                Nanny nanny = new Nanny();
                while (reader.Read())
                {
                    nanny.Ho = reader["ho"].ToString();
                    nanny.Ten = reader["ten"].ToString();
                    nanny.Email = reader["email"].ToString();
                    nanny.Sdt = reader["sđt"].ToString();
                    nanny.Idbaomau = int.Parse(reader["idbaomau"].ToString());
                    nanny.Gioitinh = reader["gioitinh"].ToString();
                    nanny.Cccd = reader["cccd"].ToString();
                    nanny.Ngaysinh = reader["ngaysinh"].ToString();
                    nanny.Pathimage = reader["filepathimage"].ToString();
                    nanny.Diachi = reader["diachi"].ToString();
                }
                return nanny;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool sua(Nanny nanny)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "update baomau set ho=@ho , ten=@ten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, cccd=@cccd , email=@email, sđt=@sdt, filepathimage =@filepath, diachi=@diachi where idbaomau = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ho", nanny.Ho);
                cmd.Parameters.AddWithValue("@ten", nanny.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", nanny.Gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nanny.Ngaysinh);
                cmd.Parameters.AddWithValue("@cccd", nanny.Cccd);
                cmd.Parameters.AddWithValue("@email", nanny.Email);
                cmd.Parameters.AddWithValue("@sdt", nanny.Sdt);
                cmd.Parameters.AddWithValue("@filepath", nanny.Pathimage);
                cmd.Parameters.AddWithValue("@diachi", nanny.Diachi);
                cmd.Parameters.AddWithValue("@id", nanny.Idbaomau);

                cmd.CommandType = CommandType.Text;
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
            finally { con.Close(); }
        }

        public DataTable doDuLieuTimKiem(string loai, string value)
        {
            string sql = "query";
            if (loai == "Tên")
            {
                string[] result = value.Split(" ", StringSplitOptions.None);
                if (result.Length > 1)
                {
                    string ten = result[result.Length - 1];
                    string ho = string.Join(" ", result, 0, result.Length - 1);
                    sql = "select * from baomau where ho = @ho and ten = @ten";
                }
                else
                {
                    sql = "select * from baomau where ten = @ten";
                }
            }
            else if (loai == "Số điện thoại")
            {
                sql = "select * from baomau where sđt = @sdt";
            }
            else if (loai == "Email")
            {
                sql = "select * from baomau where email = @value";
            }
            else if (loai == "Địa chỉ")
            {
                sql = "select * from baomau where diachi = @value";
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
                else if (loai == "Email" || loai == "Địa chỉ")
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

        public DataTable getListJob(int idbaomau, string ngay)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT \r\n    thongtindiadiemtram.tentram, \r\n    thongtindiadiemtruong.tentruong,\r\n    chitiethopdong.buoi,\r\n    hocsinh.idhocsinh,\r\n    hocsinh.ho, \r\n    hocsinh.ten,\r\n    phancongduadon.idchuyen\r\n    \r\nFROM \r\n    phancongduadon \r\nJOIN \r\n    chuyen ON phancongduadon.idchuyen = chuyen.idchuyen \r\nJOIN \r\n    chitiethopdong ON phancongduadon.idchitiet = chitiethopdong.idchitiet \r\nJOIN \r\n    hopdong ON chitiethopdong.idhopdong = hopdong.idhopdong \r\nJOIN \r\n    thongtindiadiemtram ON hopdong.idtramdon = thongtindiadiemtram.idtram \r\nJOIN \r\n    thongtindiadiemtruong ON hopdong.idtruong = thongtindiadiemtruong.idtruong \r\nJOIN \r\n    hocsinh ON hopdong.idhocsinh = hocsinh.idhocsinh \r\nWHERE \r\n    chuyen.idtaixe = @id \r\n    AND phancongduadon.ngayduadon = @ngay;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idbaomau);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
