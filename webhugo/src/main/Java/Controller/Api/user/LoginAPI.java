package Controller.Api.user;

import Model.Account;
import Service.user.LoginService;
import Utils.HttpUtils;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;

@WebServlet(value="/api-login")
public class LoginAPI extends HttpServlet {

    LoginService login=new LoginService();

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        HttpSession session=req.getSession(); // tao session
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        Account account= HttpUtils.of(req.getReader()).toModel(Account.class);
        String sessionValue=null;
        if(login.kiemTraTaiKhoan(account)==true)
        {
            String tendangnhap=login.TenDangNhap(account);// lay tendangnhap

            session.setAttribute("tendangnhap",tendangnhap); // gian tendangnhap vao session
            System.out.print("Đăng nhập thành công");


            mapper.writeValue(resp.getOutputStream(),account); // tra ve du lieu json

        }
        else
        {
            System.out.print("Đăng nhập không thành công");
            session.invalidate(); // xoa session
        }

    }
}
