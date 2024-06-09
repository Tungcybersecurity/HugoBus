package Service.user;

import DAO.user.ContractDAO;
import Model.Contract;
import Model.formContract;

import java.text.ParseException;

public class ContractService {
    public formContract themHopDong(formContract a,String tendangnhap) throws ParseException
    {
        formContract contract = new ContractDAO().themHopDong(a,tendangnhap);
        return contract;
    }

    public Contract layThongtinHopDongById(int id) {
        return (new ContractDAO().laythongtinhopdongbyid(id));
    }


}
