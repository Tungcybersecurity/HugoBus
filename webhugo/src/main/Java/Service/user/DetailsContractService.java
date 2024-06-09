package Service.user;

import DAO.user.DetailsContractDAO;
import Model.DetailsContract;

import java.text.ParseException;

public class DetailsContractService {
    public  Boolean themchitiethopdong(DetailsContract a) throws ParseException
    {
        return ( new DetailsContractDAO().themChiTietHopDong(a));
    }

}
