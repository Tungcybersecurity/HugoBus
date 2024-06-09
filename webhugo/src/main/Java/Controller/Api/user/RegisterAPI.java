package Controller.Api.user;

import Model.Account;
import Model.Parents;
import Model.RegisterAccount;
import Service.user.AddAcountService;
import Utils.HttpUtils;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;

@WebServlet(value="/api-dangky")
public class RegisterAPI extends HttpServlet {

    AddAcountService add=new AddAcountService();
    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");
        RegisterAccount a=HttpUtils.of(req.getReader()).toModel(RegisterAccount.class);
        if(add.kiemTraTaiKhoan(a.getTendangnhap())==false)   // kiem tra ten dang nhap co trung khong
        {
            if(add.themTaiKhoan(a)==true) // kiem tra xem dang ky thanh cong khong
            {
                mapper.writeValue(resp.getOutputStream(),a); // tra ve du lieu dang json
            }
        }
        else
        {
            mapper.writeValue(resp.getOutputStream(),null);
        }

    }
}
