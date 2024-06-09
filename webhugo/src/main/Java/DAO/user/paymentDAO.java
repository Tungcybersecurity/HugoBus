package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Model.Payment;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class paymentDAO extends GetConnection {
    CloseConnection close=new CloseConnection();

    public List<Payment> getPayment(int idhopdong ){
        Connection con = getConnection();
        String sql = "select * from thanhtoan where idhopdong=?";
        PreparedStatement pr=null;
        ResultSet rs = null;
        List<Payment> pm =new ArrayList<>();
        if(con!=null)
        {
            try {

                pr = con.prepareStatement(sql);
                pr.setInt(1,idhopdong);
                rs = pr.executeQuery();
                while(rs.next())
                {
                    Payment new_payment = new  Payment();
                    new_payment.setMaHopDong(rs.getInt("idHopDong"));
                    new_payment.setMaThanhToan(rs.getInt("idThanhToan"));
                    new_payment.setSoTienThanhToan(rs.getInt("SoTienCanThanhToan"));
                    new_payment.setNgayThanhToan(rs.getString("NgayThanhToan"));
                    new_payment.setPhuongThucThanhToan(rs.getString("PhuongThucThanhToan"));
                    pm.add(new_payment);

                }
                return pm;
            }catch (SQLException e)
            {
                e.printStackTrace();
                return null;
            }
            finally {
                close.dongKetNoi(con,pr,rs);
            }
        }
        return null;
    }
}
