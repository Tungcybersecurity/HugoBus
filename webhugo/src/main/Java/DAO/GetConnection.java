package DAO;

import java.sql.Connection;
import java.sql.DriverManager;

public class GetConnection {
    public  Connection getConnection() {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            String url = "jdbc:mysql://127.0.0.1:3306/bus007";
            String user = "root";
            String password = "tunglanet123";
            return DriverManager.getConnection(url, user, password);
        } catch (Exception e) {
            System.out.println("That bai");
            e.printStackTrace();
            return null;
        }
    }
}
