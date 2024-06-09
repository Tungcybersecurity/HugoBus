package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Model.Notification;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class NotificationDAO extends GetConnection {
    public List<Notification> getThongBao(String tendangnhap){

        Connection con = getConnection();
        String sql="SELECT tb.tenthongbao\n" +
                "FROM thongbao tb\n" +
                "JOIN thongbao_hopdong tbh ON tb.idthongbao = tbh.idthongbao\n" +
                "JOIN hopdong hd ON tbh.idhopdong = hd.idhopdong\n" +
                "JOIN hocsinh hs ON hd.idhocsinh = hs.idhocsinh\n" +
                "WHERE hs.tendangnhap = ?\n" +
                "  AND tb.idloai = 1\n" +
                "\n" +
                "UNION\n" +
                "\n" +
                "-- Truy vấn để lấy các thông báo liên quan đến điểm danh\n" +
                "SELECT tb.tenthongbao\n" +
                "FROM thongbao tb\n" +
                "JOIN thongbao_diemdanh tbd ON tb.idthongbao = tbd.idthongbao\n" +
                "JOIN ghinhandiemdanh gndd ON tbd.iddiemdanh = gndd.iddiemdanh\n" +
                "JOIN phancongduadon pcd ON gndd.idphancong = pcd.idphancong\n" +
                "JOIN chitiethopdong cthd ON pcd.idchitiet = cthd.idchitiet\n" +
                "JOIN hopdong hd ON cthd.idhopdong = hd.idhopdong\n" +
                "JOIN hocsinh hs ON hd.idhocsinh = hs.idhocsinh\n" +
                "WHERE hs.tendangnhap = ?\n" +
                "  AND tb.idloai = 2;";

        PreparedStatement pr = null;
        ResultSet rs = null;
        if(con!=null)
        {
            try {
                pr = con.prepareStatement(sql);
                pr.setString(1,tendangnhap);
                pr.setString(2,tendangnhap);
                rs = pr.executeQuery();
                List<Notification> notifications = new ArrayList<>();
                while(rs.next())
                {
                    Notification no = new Notification();
                    no.setNoidungthongbao(rs.getString("tenthongbao"));
                    notifications.add(no);
                }
                if(notifications.size() > 0)
                {
                    return notifications;
                }
                else
                {
                    return null;
                }

            }catch (SQLException e)
            {
                e.printStackTrace();
                return null;

            }finally {
                CloseConnection close =new CloseConnection();
                close.dongKetNoi(con,pr,rs);
            }
        }
        return null;
    }
}
