package DAO.user;

import DAO.CloseConnection;
import DAO.GetConnection;
import Mapper.ModelMapper;
import Model.formContract;
import Model.Contract;
import java.sql.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class ContractDAO extends GetConnection{
    CloseConnection close=new CloseConnection();
    public formContract themHopDong(formContract a,String tendangnhap){
        String[] array1 = a.getTen().split(" ");
        String ten = array1[array1.length -1];
        String ho = "";
        for (int i = 0 ; i <= array1.length - 2 ;i++)
        {
            if(i == array1.length - 2)
            {
                ho+=array1[i];
            }
            else{
                ho += array1[i]+" ";
            }
        }

        Connection con = getConnection();
        String sqlLayId = "select idhocsinh from hocsinh where ho = ? and ten =? and tendangnhap=?";
        String sqlLayIdTram = "select idtram from thongtindiadiemtram where tentram =?";
        String sqlLayIdTruong = "select idtruong from thongtindiadiemtruong where tentruong=?";
        String sqlthemhopdong = "insert into hopdong(idhocsinh,ngaytaohopdong,ngaybatdauhopdong,ngayketthuchopdong,idtramdon,idtruong,idtrangthai) " +
                "values(?,?,?,?,?,?,?)";
        PreparedStatement pr =null;
        ResultSet rs = null;
        if(con!=null)
        {
            try {
                pr= con.prepareStatement(sqlLayId);
                pr.setString(1,ho);
                pr.setString(2,ten);
                pr.setString(3,tendangnhap);

                rs = pr.executeQuery();
                int idhocsinh = 0;
                if(rs.next())
                {
                    idhocsinh = rs.getInt("idHocSinh");
                }

                pr = con.prepareStatement(sqlLayIdTram);
                pr.setString(1,a.getTram());
                rs=pr.executeQuery();
                int idtram = 0;
                if(rs.next())
                {
                    idtram = rs.getInt("idTram");
                }

                pr = con.prepareStatement(sqlLayIdTruong);
                pr.setString(1,a.getTruong());
                rs = pr.executeQuery();
                int idtruong = 0;
                if(rs.next())
                {
                    idtruong = rs.getInt("idtruong");
                }

                pr = con.prepareStatement(sqlthemhopdong);
                pr.setInt(1,idhocsinh);
                pr.setString(2,a.getNgaydangkyhopdong());
                pr.setString(3,a.getNgaybatdauhopdong());
                pr.setString(4,a.getNgayketthuchopdong());
                pr.setInt(5,idtram);
                pr.setInt(6,idtruong);
                pr.setInt(7,5);


                formContract cr = new formContract();
                if(pr.executeUpdate() > 0)
                {
                    String sqlIdHopDong = "select idhopdong from hopdong where idhocsinh = ? and ngaytaohopdong = ?";
                    pr =con.prepareStatement(sqlIdHopDong);
                    pr.setInt(1,idhocsinh);
                    pr.setString(2,a.getNgaydangkyhopdong());

                    rs = pr.executeQuery();

                    int idhopdong = 0;
                    if(rs.next())
                    {
                        idhopdong = rs.getInt("idHopDong");
                    }

                    String sqlThemChiTietHopDong = "insert into chitiethopdong(idhopdong,thutrongtuan,buoi) values(?,?,?)";
                    for (int i =0 ;i < a.getThutrongtuan().length;i++)
                    {
                        pr = con.prepareStatement(sqlThemChiTietHopDong);
                        pr.setInt(1,idhopdong);
                        pr.setString(2,a.getThutrongtuan()[i]);
                        pr.setString(3,a.getBuoi()[i]);
                        if(pr.executeUpdate() < 0)
                        {
                            return null;
                        }
                    }
                    return a;
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

    public boolean capnhattrangthai(int idTrangThai, String ngaycapnhat, int idHopDong) throws ParseException{
        Connection con = getConnection();
        String sql = "update hopdong set NgayCapNhatTrangThai=?, idTrangThai=? where idHopDong=?";
        PreparedStatement pr = null;
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");

        if(con!=null)
        {
            try {
                Date ngayThang = sdf.parse(ngaycapnhat);
                java.sql.Date ngayCapnhattrangthaiSQL = new java.sql.Date(ngayThang.getTime());
                pr=con.prepareStatement(sql);
                pr.setString(1,ngaycapnhat);
                pr.setInt(2,idTrangThai);
                pr.setInt(3, idHopDong);
                if(pr.executeUpdate() > 0)
                {
                    return true;
                }
                else{
                    return false;
                }
            }catch (SQLException e)
            {
                e.printStackTrace();
                return false;
            }finally {
                close.dongKetNoi(con,pr);
            }
        }
        return false;
    }

    public Contract laythongtinhopdongbyid(int idHocSinh) {
        Connection con=getConnection();
        String sql="select * from hopdong where idHocSinh=? and idtrangthai=1";
        PreparedStatement pr=null;
        ResultSet rs=null;
        Contract pa=null;
        if(con!=null)
        {
            try {
                pr=con.prepareStatement(sql);
                pr.setInt(1,idHocSinh);
                rs=pr.executeQuery();
                if(rs.next())
                {
                    pa= ModelMapper.mapResultSetToObject(rs,Contract.class);
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



}