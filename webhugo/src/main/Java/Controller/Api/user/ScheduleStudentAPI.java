package Controller.Api.user;

import Model.ScheduleStudent;
import Service.user.InfomationStudentsService;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(value="/api-lichhocsinh")
public class ScheduleStudentAPI extends HttpServlet {
    InfomationStudentsService service = new InfomationStudentsService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        int id = Integer.parseInt(req.getParameter("id"));
        String tendangnhap = req.getParameter("tendangnhap");
        if(tendangnhap!=null) {
            ScheduleStudent sch = service.layLich(id);
            mapper.writeValue(resp.getOutputStream(),sch);
        }

    }
}
