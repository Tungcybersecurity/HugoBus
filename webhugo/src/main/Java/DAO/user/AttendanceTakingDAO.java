package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Model.AttendanceTaking;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class AttendanceTakingDAO extends GetConnection {

    public List<AttendanceTaking> getDiemDanh(int idhocsinh)
    {
       Connection con =getConnection();
       String sql = "SELECT \n" +
               "    gndd.thoigiandiemdanh,\n" +
               "    ttdt.tentram,\n" +
               "    ttdt2.tentruong,\n" +
               "    ttdd.tinhtrang\n" +
               "FROM \n" +
               "    hocsinh hs\n" +
               "JOIN \n" +
               "    hopdong hd ON hs.idhocsinh = hd.idhocsinh\n" +
               "JOIN \n" +
               "    chitiethopdong cthd ON hd.idhopdong = cthd.idhopdong\n" +
               "JOIN \n" +
               "    phancongduadon pcda ON cthd.idchitiet = pcda.idchitiet\n" +
               "JOIN \n" +
               "    ghinhandiemdanh gndd ON pcda.idphancong = gndd.idphancong\n" +
               "JOIN \n" +
               "    tinhtrangdiemdanh ttdd ON gndd.idtinhtrangdiemdanh = ttdd.idtinhtrangdiemdanh\n" +
               "JOIN \n" +
               "    thongtindiadiemtram ttdt ON hd.idtramdon = ttdt.idtram\n" +
               "JOIN \n" +
               "    thongtindiadiemtruong ttdt2 ON hd.idtruong = ttdt2.idtruong\n" +
               "WHERE \n" +
               "    hs.idhocsinh = ?";
        PreparedStatement pr =null;
        ResultSet rs = null;
        List<AttendanceTaking> att = new ArrayList<>();
        if(con!=null)
        {
            try {
                pr =  con.prepareStatement(sql);
                pr.setInt(1,idhocsinh);
                rs = pr.executeQuery();
                while(rs.next())
                {
                    AttendanceTaking new_att = new AttendanceTaking();
                    new_att.setTruong(rs.getString("tentruong"));
                    new_att.setTram(rs.getString("tentram"));
                    new_att.setNgaydiemdanh(rs.getString("thoigiandiemdanh"));
                    new_att.setTinhtrang(rs.getString("tinhtrang"));
                    att.add(new_att);
                }
                if(att.size() > 0)
                {
                    return att;
                }
                else{
                    return null;
                }

            }catch(SQLException e)
            {
                e.printStackTrace();
                return null;
            }finally {
                CloseConnection close = new CloseConnection();
                close.dongKetNoi(con,pr,rs);
            }
        }
        return null;
    }
}
