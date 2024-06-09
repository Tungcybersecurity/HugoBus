package Service.user;

import Model.Account;
import DAO.user.*;
import Model.Parents;

import java.text.ParseException;

public class InfomationParentService {
    public Parents thongTinPhuHuynh(String session)
    {
        InformationParentDAO pr=new InformationParentDAO();
        return (pr.xuatThongTinPhuHuynh(session));
    }

    public Boolean suaThongTin(String session,Parents a) throws ParseException
    {
        return(new InformationParentDAO().suaThongTinPhuHuynh(session,a));
    }

    public Boolean kiemTraEmail(String email)
    {
        return (new InformationParentDAO().kiemTraEmail(email));
    }

    public Boolean  kiemTraSDT(String sdt)
    {
        return (new InformationParentDAO().kiemTraSDT(sdt));
    }
}
