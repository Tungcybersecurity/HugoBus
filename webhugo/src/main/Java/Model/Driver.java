package Model;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Driver {
    private int MaTaiXe;
    private String HoTen;
    private String Email;
    private String SoDienThoai;


    public Driver(){} // ham khoi tao

    public String getEmail() {
        return Email;
    }

    public String getSoDienThoai() {
        return SoDienThoai;
    }

    public void setSoDienThoai(String soDienThoai) {
        SoDienThoai = soDienThoai;
    }

    public String getHoTen() {
        return HoTen;
    }

    public void setHoTen(String hoTen) {
        HoTen = hoTen;
    }

    public void setEmail(String email) {
        Email = email;
    }

    public int getMaTaiXe() {
        return MaTaiXe;
    }

    public void setMaTaiXe(int maTaiXe) {
        MaTaiXe = maTaiXe;
    }
}
