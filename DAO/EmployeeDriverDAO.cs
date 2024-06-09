using DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeDriverDAO
    {
        
        public DataTable doDulieu()
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idtaixe,ho,ten,gioitinh,ngaysinh,cccd,email,sdt,diachi from taixe";
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
                con.Open() ;
                string sql = "delete from taixe where idtaixe =@id";
                MySqlCommand cmd = new MySqlCommand( sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType= CommandType.Text;
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
                Console.WriteLine (e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Boolean them(Driver driver)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "insert into taixe(ho,ten,gioitinh,ngaysinh,cccd,email,sdt,filepathimage,diachi) values(@ho,@ten,@gioitinh,@ngaysinh,@cccd,@email,@sdt,@path,@diachi)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ho", driver.Ho);
                cmd.Parameters.AddWithValue("@ten", driver.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", driver.Gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", driver.Ngaysinh);
                cmd.Parameters.AddWithValue("@cccd", driver.Cccd);
                cmd.Parameters.AddWithValue("@email", driver.Email);
                cmd.Parameters.AddWithValue("@sdt", driver.Sdt);
                cmd.Parameters.AddWithValue("@path", driver.Pathimage);
                cmd.Parameters.AddWithValue("@diachi", driver.Diachi);
                cmd.CommandType = CommandType.Text; 

                if(cmd.ExecuteNonQuery () > 0) { return true; }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }finally { 
                con.Close(); }
        }

        public Driver doTextField(int id )
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "select idtaixe,ho,ten,gioitinh,ngaysinh,cccd,email,sdt,filepathimage,diachi from taixe where idtaixe = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                Driver driver = new Driver();
                while(reader.Read())
                {
                    driver.Ho = reader["ho"].ToString();
                    driver.Ten = reader["ten"].ToString();
                    driver.Email = reader["email"].ToString();
                    driver.Sdt = reader["sdt"].ToString();
                    driver.Idtaixe = int.Parse(reader["idtaixe"].ToString());
                    driver.Gioitinh = reader["gioitinh"].ToString();
                    driver.Cccd = reader["cccd"].ToString();
                    driver.Ngaysinh = reader["ngaysinh"].ToString();
                    driver.Pathimage = reader["filepathimage"].ToString();
                    driver.Diachi = reader["diachi"].ToString();
                }
                return driver;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                con.Close() ;
            }
        }

        public bool sua(Driver driver)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "update taixe set ho=@ho , ten=@ten, gioitinh=@gioitinh, ngaysinh=@ngaysinh, cccd=@cccd , email=@email, sdt=@sdt, filepathimage =@filepath, diachi=@diachi where idtaixe = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ho", driver.Ho);
                cmd.Parameters.AddWithValue("@ten", driver.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", driver.Gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", driver.Ngaysinh);
                cmd.Parameters.AddWithValue("@cccd", driver.Cccd);
                cmd.Parameters.AddWithValue("@email", driver.Email);
                cmd.Parameters.AddWithValue("@sdt", driver.Sdt);
                cmd.Parameters.AddWithValue("@filepath", driver.Pathimage);
                cmd.Parameters.AddWithValue("@diachi", driver.Diachi);
                cmd.Parameters.AddWithValue("@id", driver.Idtaixe);

                cmd.CommandType = CommandType.Text;
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }finally { con.Close(); }  
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
                    sql = "select * from taixe where ho = @ho and ten = @ten";
                }
                else
                {
                    sql = "select * from taixe where ten = @ten";
                }
            }
            else if (loai == "Số điện thoại")
            {
                sql = "select * from taixe where sdt = @sdt";
            }
            else if (loai == "Email")
            {
                sql = "select * from taixe where email = @value";
            }
            else if (loai == "Địa chỉ")
            {
                sql = "select * from taixe where diachi = @value";
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

        public DataTable getListJob(int idtaixe,string ngay)
        {
            Connection connect = new Connection();
            MySqlConnection con = connect.getConnection();
            try
            {
                con.Open();
                string sql = "SELECT \r\n    hs.ho ,\r\n    hs.ten,\r\n    hs.idhocsinh,\r\n    ttdt.tentram,\r\n    ttdtr.tentruong\r\nFROM \r\n    phancongduadon pcd\r\nJOIN \r\n    chuyen c ON pcd.idchuyen = c.idchuyen\r\nJOIN \r\n    hopdong hd ON pcd.idchitiet = hd.idhopdong\r\nJOIN \r\n    chitiethopdong cthd ON hd.idhopdong = cthd.idhopdong\r\nJOIN \r\n    hocsinh hs ON hd.idhocsinh = hs.idhocsinh\r\nJOIN \r\n    thongtindiadiemtram ttdt ON hd.idtramdon = ttdt.idtram\r\nJOIN \r\n    thongtindiadiemtruong ttdtr ON hd.idtruong = ttdtr.idtruong\r\nWHERE \r\n    c.idtaixe = @id\r\n    AND pcd.ngayduadon = @ngay;\r\n";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idtaixe);
                cmd.Parameters.AddWithValue("@ngay",ngay);
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
