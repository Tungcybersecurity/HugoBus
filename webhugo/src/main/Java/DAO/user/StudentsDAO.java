package DAO.user;

import DAO.GetConnection;
import Model.Students;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

public class StudentsDAO extends GetConnection {

    public Students themThongTin(String tendangnhap,Students hocsinh) throws ParseException
    {
        Connection con=getConnection();
        String sql="insert into hocsinh(ho,ten,gioitinh,ngaysinh,truong,lop,tendangnhap,filepathimage) values(?,?,?,?,?,?,?,?)";
        PreparedStatement pr=null;
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        if(con!=null)
        {
            try {
                Date ngayThang = sdf.parse(hocsinh.getNgaysinh());
                java.sql.Date ngayCapnhattrangthaiSQL = new java.sql.Date(ngayThang.getTime());
                pr=con.prepareStatement(sql);
                pr.setString(1,hocsinh.getHo());
                pr.setString(2,hocsinh.getTen());
                pr.setString(3,hocsinh.getGioitinh());
                pr.setString(4,hocsinh.getNgaysinh());
                pr.setString(5,hocsinh.getTruong());
                pr.setString(6,hocsinh.getLop());
                pr.setString(7,tendangnhap);
                pr.setString(8,hocsinh.getFilepathimage());

                if(pr.executeUpdate() > 0)
                {
                    return hocsinh;
                }
                else
                {
                    return null;
                }
            }catch (SQLException e){
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
                }catch (SQLException e)
                {
                    e.printStackTrace();
                }
            }
        }
        return null;
    }


}
