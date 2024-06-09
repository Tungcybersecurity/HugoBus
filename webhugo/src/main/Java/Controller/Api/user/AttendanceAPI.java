package Controller.Api.user;

import Model.AttendanceTaking;
import Service.user.AttendanceTakingService;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.util.List;

@WebServlet(value="/api-diemdanh")
public class AttendanceAPI extends HttpServlet {
    AttendanceTakingService service = new AttendanceTakingService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        String tendangnhap = req.getParameter("tendangnhap");
        int idhocsinh = Integer.parseInt(req.getParameter("id"));

        if(tendangnhap!=null)
        {
            List<AttendanceTaking> att = service.getLichSu(idhocsinh);
            mapper.writeValue(resp.getOutputStream(),att);
        }
    }
}
