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

    public boolean kiemTraEmail(String email)
    {
        Connection con= new GetConnection().getConnection();
        String sql="select * from taikhoanphuhuynh where Email=?";
        PreparedStatement pr=null;
        ResultSet rs=null;
        if(con!=null)
        {
            try
            {
                pr=con.prepareStatement(sql);
                pr.setString(1,email);
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

    public boolean kiemTraSDT(String sdt)
    {
        Connection con= new GetConnection().getConnection();
        String sql="select * from taikhoanphuhuynh where SoDienThoai=?";
        PreparedStatement pr=null;
        ResultSet rs=null;
        if(con!=null)
        {
            try
            {
                pr=con.prepareStatement(sql);
                pr.setString(1,sdt);
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



  public boolean themTaiKhoan(Account a)
  {
      Connection con=getConnection();
      String sql1="insert into taikhoanphuhuynh(TenDangNhap,MatKhau) values(?,?)";
      PreparedStatement pr=null;
      if(con!=null)
      {
          try {
              pr=con.prepareStatement(sql1);
              pr.setString(1,a.getTendangnhap());
              pr.setString(2,a.getMatkhau());

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

  public Parents themThongTinPhuHuynh(Parents a ) throws ParseException {
      Connection con = getConnection();
      String sql = "insert into phuhuynh(tendangnhap,ho,ten,gioitinh,ngaysinh,email,SĐT) values(?,?,?,?,?,?,?)";
      PreparedStatement pr = null;
      SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");

      if(con!=null)
      {
          try {
              Date ngayThang = sdf.parse(a.getNgaysinh());
              java.sql.Date ngayThangSQL = new java.sql.Date(ngayThang.getTime());
              pr=con.prepareStatement(sql);
              pr.setString(1,a.getTendangnhap());
              pr.setString(2,a.getHo());
              pr.setString(3,a.getTen());
              pr.setString(4,a.getGioitinh());
              pr.setDate(5,ngayThangSQL);
              pr.setString(6,a.getEmail());
              pr.setString(7,a.getSdt());

              if(pr.executeUpdate() > 0)
              {
                  return a;
              }
              else{
                  return null;
              }
          }catch (SQLException e)
          {
                e.printStackTrace();
                return null;
          }finally {
                close.dongKetNoi(con,pr);
          }
      }
      return null;
  }

}


