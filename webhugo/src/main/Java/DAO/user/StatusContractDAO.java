package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Model.Contract;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class StatusContractDAO extends GetConnection {
    CloseConnection close=new CloseConnection();

    public String getTinhTrang(int id){
        Connection con = getConnection();
        String sql = "select tentrangthai from trangthaihopdong where idtrangthai = ?";
        PreparedStatement pr =null;
        ResultSet rs = null;
        if(con!=null)
        {
            try {
                pr=con.prepareStatement(sql);
                pr.setInt(1,id);
                rs = pr.executeQuery();
                if(rs.next())
                {
                    return rs.getString("TenTrangThai");
                }
                return null;

            }catch (SQLException e)
            {
                e.printStackTrace();
                return null;
            }finally {
                close.dongKetNoi(con,pr,rs);
            }
        }
        return null;
    }
}
