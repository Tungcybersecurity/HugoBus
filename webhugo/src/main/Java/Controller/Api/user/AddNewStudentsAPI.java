package Controller.Api.user;

import Model.Students;
import Service.user.AddNewStudentsService;
import Utils.HttpUtils;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(value="/api-themhocsinh")
public class AddNewStudentsAPI extends HttpServlet {

    AddNewStudentsService service = new AddNewStudentsService();
    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        Students a= HttpUtils.of(req.getReader()).toModel(Students.class);

        String value=req.getParameter("tendangnhap");

        if(value!=null)
        {
            try {
                if(service.themhocsinh(value,a)!=null)
                {
                    mapper.writeValue(resp.getOutputStream(),a);
                    resp.getWriter().write("Thêm học sinh thành công");
                }
                else
                {
                    resp.getWriter().write("Thêm học sinh không thành công");

                }
            }catch (Exception e)
            {
                resp.getWriter().write("Thêm học sinh không thành công");
                e.printStackTrace();
            }

        }
        else
        {
            req.getSession().invalidate();
            resp.getWriter().write("Chưa đăng nhập");
        }

    }
}
