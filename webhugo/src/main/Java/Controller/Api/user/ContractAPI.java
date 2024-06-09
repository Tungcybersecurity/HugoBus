package Controller.Api.user;

import Model.Contract;
import Model.DetailsContract;
import Model.formContract;
import Model.Students;
import Service.user.ContractService;
import Service.user.InfomationStudentsService;
import Utils.HttpUtils;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import java.io.IOException;
import java.text.ParseException;
import java.util.ArrayList;
import java.util.List;

@WebServlet(value="/api-taohopdong")
public class ContractAPI extends HttpServlet {
    InfomationStudentsService student= new InfomationStudentsService();
    ContractService contract= new ContractService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        String value = (String)req.getSession().getAttribute("tendangnhap");
        if(value!=null)
        {
            List<Students> st = student.thongtin(value);

        }
        else
        {
            req.getSession().invalidate();
            resp.getWriter().write("Chưa đăng nhập");
        }

    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        String value = req.getParameter("tendangnhap");
        if(value!=null)
        {
            formContract ct = HttpUtils.of(req.getReader()).toModel(formContract.class);
            try{
                formContract result=contract.themHopDong(ct,value);
                mapper.writeValue(resp.getOutputStream(),result);
            }catch (ParseException e)
            {
                e.printStackTrace();
                resp.getWriter().write("Thêm hơp đồng không thành công");
            }


        }
        else{
            req.getSession().invalidate();
            resp.getWriter().write("Chưa đăng nhập");
        }

    }
}
