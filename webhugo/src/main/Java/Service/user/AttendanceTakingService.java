package Service.user;

import DAO.user.AttendanceTakingDAO;
import Model.AttendanceTaking;

import java.util.List;

public class AttendanceTakingService {
    public List<AttendanceTaking> getLichSu(int idhocsinh)
    {
        return (new AttendanceTakingDAO().getDiemDanh(idhocsinh));
    }

}
