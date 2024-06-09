package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Model.Account;
import Model.Parents;
import Model.RegisterAccount;

import java.sql.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class AccountCreationDAO extends GetConnection{

    CloseConnection close=new CloseConnection();
    public  boolean kiemTraTaiKhoan(String account)
    {
        Connection con= new GetConnection().getConnection();
        String sql="select * from taikhoanphuhuynh where TenDangNhap=?";
        PreparedStatement pr=null;
        ResultSet rs=null;
        if(con!=null)
        {
            try
            {
                pr=con.prepareStatement(sql);
                pr.setString(1,account);
                rs=pr.executeQuery();
                if(rs.next())
                {
                    return true;
                }
                return false;

            }catch (SQLException e)
            {
                e.printStackTrace();
                return false;
            }finally {
                close.dongKetNoi(con,pr,rs);
            }
        }
        return false;

    }


  public boolean themTaiKhoan(RegisterAccount a)
  {
      Connection con=getConnection();
      String sql1="insert into taikhoanphuhuynh(TenDangNhap,MatKhau) values(?,?)";
      String sql2="insert into phuhuynh(tendangnhap,ho,ten,gioitinh,email,sdt,diachi) values(?,?,?,?,?,?,?)"; // them tendangnhap vao phuhuynh
      PreparedStatement pr=null;
      if(con!=null)
      {
          try {
              pr=con.prepareStatement(sql1);
              pr.setString(1,a.getTendangnhap());
              pr.setString(2,a.getMatkhau());

              pr.executeUpdate();

              pr=con.prepareStatement(sql2);

              pr.setString(1,a.getTendangnhap());
              pr.setString(2,a.getHo());
              pr.setString(3,a.getTen());
              pr.setString(4,a.getGioitinh());
              pr.setString(5,a.getEmail());
              pr.setString(6,a.getSodienthoai());
              pr.setString(7,a.getDiachi());
              pr.executeUpdate();


              return true;
          }catch (SQLException e){
              e.printStackTrace();
              return false;
          }
          finally {

          }
      }
      return false;
  }



}


