package Controller.Api.user;

import Model.Contract;
import Service.user.ContractService;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.text.ParseException;

@WebServlet(value="/api-thongtinhopdong")
public class ContractInformationAPI extends HttpServlet  {
    ContractService contract = new ContractService();
    @Override
    protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper=new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");

        String value = (String) req.getSession().getAttribute("tendangnhap");
        int id = Integer.parseInt(req.getParameter("idhocsinh"));
        if(id!=0 && value!=null)
        {

                Contract result = contract.layThongtinHopDongById(id);
                mapper.writeValue(resp.getOutputStream(), result);
        }
        else
        {
            resp.getWriter().write("Chưa đăng nhập");
        }
    }
}
