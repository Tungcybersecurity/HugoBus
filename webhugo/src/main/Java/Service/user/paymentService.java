package Service.user;

import DAO.user.paymentDAO;
import Model.Payment;

import java.util.List;

public class paymentService {
    public List<Payment> getInfoPayment(int idhopdong){
        return (new paymentDAO().getPayment(idhopdong));
    }
}
