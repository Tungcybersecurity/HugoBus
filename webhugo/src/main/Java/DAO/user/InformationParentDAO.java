package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Mapper.ModelMapper;
import Model.Account;
import Model.Parents;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class InformationParentDAO extends GetConnection {
    CloseConnection close = new CloseConnection();
    public Parents xuatThongTinPhuHuynh(String tendangnhap)
    {
        Connection con=getConnection();
        String sql="select * from phuhuynh where TenDangNhap=?";
        PreparedStatement pr=null;
        ResultSet rs=null;
        Parents pa=null;
        if(con!=null)
        {
            try {
                pr=con.prepareStatement(sql);
                pr.setString(1,tendangnhap);
                rs=pr.executeQuery();
                if(rs.next())
                {
                    pa= ModelMapper.mapResultSetToObject(rs,Parents.class);
                }
                return pa;
            }catch (SQLException | IllegalAccessException | InstantiationException e){
                e.printStackTrace();
                return null;
            }
            finally {
                try {
                    if(con!=null)
                    {
                        con.close();
                    }
                    if(pr!=null)
                    {
                        pr.close();
                    }
                    if(rs!=null)
                    {
                        pr.close();
                    }
                }catch (SQLException e){
                    e.printStackTrace();
                }
            }
        }
        return null;
    }


    public Boolean kiemTraEmail(String email)
    {
        Connection con = getConnection();
        String sql = "select 1 from phuhuynh where email = ? ";
        PreparedStatement pr = null;
        ResultSet rs = null;
        if (con!=null)
        {
           try {
               pr=con.prepareStatement(sql);
               pr.setString(1,email);

               rs=pr.executeQuery();

               if(rs.next())
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }catch (SQLException e)
           {
               e.printStackTrace();
               return false;
           }
           finally {
               close.dongKetNoi(con,pr,rs);
           }

        }
        return false;
    }

    public Boolean kiemTraSDT(String sdt)
    {
        Connection con = getConnection();
        String sql = "select 1 from phuhuynh where sdt = ? ";
        PreparedStatement pr = null;
        ResultSet rs = null;
        if (con!=null)
        {
            try {
                pr=con.prepareStatement(sql);
                pr.setString(1,sdt);

                rs=pr.executeQuery();

                if(rs.next())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch (SQLException e)
            {
                e.printStackTrace();
                return false;
            }
            finally {
                close.dongKetNoi(con,pr,rs);
            }

        }
        return false;
    }

    public Boolean suaThongTinPhuHuynh(String tendangnhap, Parents phuhuynh) throws ParseException
    {
        Connection con=getConnection();
        String sql="update phuhuynh set Ho=?,Ten=?,GioiTinh=?,NgaySinh=?,email=?,sdt=?,diachi=?,filepathimage=? where TenDangNhap=?";
        PreparedStatement pr=null;
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        if(con!=null)
        {
            try {
                Date ngayThang = sdf.parse(phuhuynh.getNgaysinh());
                java.sql.Date ngayCapnhattrangthaiSQL = new java.sql.Date(ngayThang.getTime());
                pr=con.prepareStatement(sql);
                pr.setString(1,phuhuynh.getHo());
                pr.setString(2,phuhuynh.getTen());
                pr.setString(3,phuhuynh.getGioitinh());
                pr.setString(4,phuhuynh.getNgaysinh());
                pr.setString(5,phuhuynh.getEmail());
                pr.setString(6,phuhuynh.getSdt());
                pr.setString(7,phuhuynh.getDiachi());
                pr.setString(8,phuhuynh.getFilepathimage());
                pr.setString(9,tendangnhap);
                pr.executeUpdate();
                return true;
            }catch (SQLException e)
            {
                e.printStackTrace();
                return false;
            }finally {
                try {
                    if(con!=null)
                    {
                        con.close();
                    }
                    if(pr!=null)
                    {
                        pr.close();
                    }
                }catch (SQLException e){
                    e.printStackTrace();
                }
            }
        }
        return false;
    }
}
