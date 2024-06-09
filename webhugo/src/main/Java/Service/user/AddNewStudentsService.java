package Service.user;

import DAO.user.StudentsDAO;
import Model.Students;

import java.text.ParseException;

public class AddNewStudentsService {
    public Students themhocsinh(String session,Students a) throws ParseException
    {
       return (new StudentsDAO().themThongTin(session,a));
    }
}
