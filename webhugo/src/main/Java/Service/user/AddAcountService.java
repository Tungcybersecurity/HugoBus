package Service.user;

import DAO.user.AccountCreationDAO;
import Model.Account;
import Model.Parents;
import Model.RegisterAccount;

public class AddAcountService {
    public boolean kiemTraTaiKhoan(String a)
    {
        return (new AccountCreationDAO().kiemTraTaiKhoan(a));
    }

    public boolean themTaiKhoan(RegisterAccount a)
    {
        return ( new AccountCreationDAO().themTaiKhoan(a));
    }


}
