package Controller.Api.user;

import Model.Notification;
import Service.user.NotificationService;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.List;

@WebServlet(value="/api-thongbao")
public class NotificationAPI extends HttpServlet {
    NotificationService service = new NotificationService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        String tendangnhap = req.getParameter("tendangnhap");
        if(tendangnhap != null)
        {
            List<Notification> no = service.getThongBao(tendangnhap);
            mapper.writeValue(resp.getOutputStream(),no);
        }

    }
}
