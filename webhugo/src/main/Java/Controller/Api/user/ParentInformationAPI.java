package Controller.Api.user;

import Model.Account;
import Model.Parents;
import Service.user.InfomationParentService;
import Utils.HttpUtils;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.text.ParseException;

@WebServlet(value="/api-thongtinphuhuynh")
public class ParentInformationAPI extends HttpServlet {

    InfomationParentService info=new InfomationParentService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String value=req.getParameter("tendangnhap"); // lay gia tri cua session
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");
            if(value!=null)
            {
                Parents account=info.thongTinPhuHuynh(value); // lay du lieu
                mapper.writeValue(resp.getOutputStream(),account); // tra ve du lieu json
                System.out.print("Xuat du lieu thanh cong");
            }
            else
            {
                System.out.print("Xuat du lieu khong thanh cong");
                req.getSession().invalidate();// xoa session
            }
    }

    @Override
    // Phương thức này được dùng để :
    // +Khi đăng ký tài khoản thành công vào trang home phải bắt phụ huynh nhập đầy đủ thông tin
    // +Sau khi nhập thong tin rồi sau này phụ huynh cũng có thể sửa
    protected void doPut(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        String value=req.getParameter("tendangnhap");
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");
        Parents pa= HttpUtils.of(req.getReader()).toModel(Parents.class);
        if(value!=null)
        {
            try {
                if(info.suaThongTin(value,pa)==true)   // sua thong tin
                {
                    mapper.writeValue(resp.getOutputStream(),pa); // tra ve json
                }
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }
        }
        else
        {
            System.out.print("Khong the sua");
        }
    }
}
