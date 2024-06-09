package Controller.Api;

import javax.servlet.*;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
public class CorsFilter implements Filter {
    @Override
    public void init(FilterConfig filterConfig)  throws ServletException {
    }

    @Override
    public void doFilter(ServletRequest servletRequest, ServletResponse servletResponse, FilterChain filterChain) throws IOException, ServletException {
        HttpServletResponse response = (HttpServletResponse) servletResponse;

        response.setHeader("Access-Control-Allow-Origin", "*"); // Cho phép truy cập từ mọi nguồn
        response.setHeader("Access-Control-Allow-Methods", "POST, GET, OPTIONS, DELETE, PUT"); // Cho phép các phương thức HTTP
        response.setHeader("Access-Control-Max-Age", "3600"); // Thời gian cache tiêu đề CORS trong trình duyệt, đơn vị là giây
        response.setHeader("Access-Control-Allow-Headers", "Content-Type, Authorization");

        filterChain.doFilter(servletRequest, servletResponse);
    }

    @Override
    public void destroy() {
    }
}
