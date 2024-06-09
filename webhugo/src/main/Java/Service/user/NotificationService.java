package Service.user;

import DAO.user.NotificationDAO;
import Model.Notification;

import java.util.List;

public class NotificationService {
    public List<Notification> getThongBao(String tendangnhap){
        return (new NotificationDAO().getThongBao(tendangnhap));
    }
}
