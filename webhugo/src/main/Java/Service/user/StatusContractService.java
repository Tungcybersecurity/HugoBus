package Service.user;

import DAO.user.StatusContractDAO;

public class StatusContractService {
    public String getTrangThai(int id){
        return (new StatusContractDAO().getTinhTrang(id));
    }
}
