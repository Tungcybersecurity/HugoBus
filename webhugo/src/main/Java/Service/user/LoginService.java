package Service.user;

import DAO.user.LoginDAO;
import Model.Account;

public class LoginService {

    public boolean kiemTraTaiKhoan(Account a)
    {
        if(new LoginDAO().dangNhap(a) != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Account thongTin(Account a)
    {
        return (new LoginDAO().dangNhap(a));
    }

    public String TenDangNhap (Account a)
    {
        return ( new LoginDAO().layTenDangNhap(a));
    }
}
