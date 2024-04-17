package Service.user;

import DAO.user.AddNewStudentsDAO;
import Model.Students;

public class AddNewStudentsService {
    public Students themhocsinh(String session,Students a)
    {
       return (new AddNewStudentsDAO().themThongTin(session,a));
    }
}
