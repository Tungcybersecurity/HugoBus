package Controller.Api.user;

import Model.Contract;
import Model.DetailsContract;
import Model.Payment;
import Model.Students;
import Service.user.*;
import Utils.HttpUtils;
import com.fasterxml.jackson.core.type.TypeReference;
import com.google.gson.Gson;
import org.codehaus.jackson.map.ObjectMapper;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.BufferedReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

@WebServlet(value="/api-chitiethopdong")
public class DetailsContractAPI extends HttpServlet {

    DetailsContractService service = new DetailsContractService();

    public StringBuilder JsonBuilder(BufferedReader reader) {
        StringBuilder jsonBuilder = new StringBuilder();
        String line;

        try {
            while ((line = reader.readLine()) != null) {
                jsonBuilder.append(line);
            }
            reader.close();
            return jsonBuilder;
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }

    @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
        ObjectMapper mapper = new ObjectMapper();
        req.setCharacterEncoding("UTF-8");
        resp.setContentType("application/json");


        String value = (String) req.getSession().getAttribute("tendangnhap");

        String idhopdong = req.getParameter("idhopdong");

        if (value != null && idhopdong != null) {
            Gson gson = new Gson();

            // mapping array json vào mảng doi tuong detailcontract
            DetailsContract[] objects = gson.fromJson(JsonBuilder(req.getReader()).toString(), DetailsContract[].class);

            for (DetailsContract x : objects) {
                x.setIdhopdong(Integer.parseInt(idhopdong));   // gian idhopdong vao
                try {
                    if (service.themchitiethopdong(x) == true) {
                        continue;
                    } else {
                        resp.getWriter().write("Thêm chi tiet hop dong that bai");
                        break;
                    }
                } catch (Exception e) {
                    resp.getWriter().write("Thêm hơp đồng không thành công");
                    e.printStackTrace();

                }

            }
        }

    }

        public class forrmHopDong {
            public int idhopdong;
            public String ten;
            public String ngaydangky;
            public int tien;
            public String ngaythanhtoan;
            public String lop;
            public String truong;
            public String tinhtrang;

            public forrmHopDong() {

            }

            public int getIdhopdong() {
                return idhopdong;
            }

            public void setIdhopdong(int idhopdong) {
                this.idhopdong = idhopdong;
            }

            public String getTen() {
                return ten;
            }

            public void setTen(String ten) {
                this.ten = ten;
            }

            public String getNgaydangky() {
                return ngaydangky;
            }

            public void setNgaydangky(String ngaydangky) {
                this.ngaydangky = ngaydangky;
            }

            public int getTien() {
                return tien;
            }

            public void setTien(int tien) {
                this.tien = tien;
            }

            public String getNgaythanhtoan() {
                return ngaythanhtoan;
            }

            public void setNgaythanhtoan(String ngaythanhtoan) {
                this.ngaythanhtoan = ngaythanhtoan;
            }

            public String getLop() {
                return lop;
            }

            public void setLop(String lop) {
                this.lop = lop;
            }

            public String getTruong() {
                return truong;
            }

            public void setTruong(String truong) {
                this.truong = truong;
            }

            public String getTinhtrang() {
                return tinhtrang;
            }

            public void setTinhtrang(String tinhtrang) {
                this.tinhtrang = tinhtrang;
            }
        }

        InfomationStudentsService student = new InfomationStudentsService();
        ContractService contract = new ContractService();
        paymentService paymentservice = new paymentService();
        StatusContractService status = new StatusContractService();
        @Override
        protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
            ObjectMapper mapper = new ObjectMapper();
            req.setCharacterEncoding("UTF-8");
            resp.setContentType("application/json");

            String value = req.getParameter("tendangnhap");
            if (value != null) {
                List<Students> st = student.thongtin(value);
                if (st != null && !st.isEmpty()) {
                    List<forrmHopDong> form = new ArrayList<>();
                    for (Students a : st) {
                        forrmHopDong f = new forrmHopDong();
                        f.setTen(a.getHo() + " " + a.getTen());
                        f.setLop(a.getLop());
                        f.setTruong(a.getTruong());
                        int id = a.getIdhocsinh();
                        Contract con = contract.layThongtinHopDongById(id);
                        if (con != null) {
                            f.setIdhopdong(con.getIdhopdong());
                            f.setNgaydangky(con.getNgaytaohopdong());
                            f.setTinhtrang(status.getTrangThai(con.getIdtrangthai()));
                            List<Payment> pm = paymentservice.getInfoPayment(f.getIdhopdong());
                            if (pm != null && !pm.isEmpty()) {
                                for (Payment i : pm) {
                                    forrmHopDong paymentForm = new forrmHopDong();
                                    paymentForm.setTen(f.getTen());
                                    paymentForm.setLop(f.getLop());
                                    paymentForm.setTruong(f.getTruong());
                                    paymentForm.setIdhopdong(f.getIdhopdong());
                                    paymentForm.setNgaydangky(f.getNgaydangky());
                                    paymentForm.setTinhtrang(f.getTinhtrang());
                                    paymentForm.setNgaythanhtoan(i.getNgayThanhToan());
                                    paymentForm.setTien(i.getSoTienThanhToan());
                                    form.add(paymentForm);
                                }
                            } else {
                                mapper.writeValue(resp.getOutputStream(), null);
                                return;
                            }
                        } else {
                            mapper.writeValue(resp.getOutputStream(), null);
                            return;
                        }
                    }
                    mapper.writeValue(resp.getOutputStream(), form);
                } else {
                    mapper.writeValue(resp.getOutputStream(), null);
                }
            } else {
                req.getSession().invalidate();
                mapper.writeValue(resp.getOutputStream(), null);
            }
        }

}
