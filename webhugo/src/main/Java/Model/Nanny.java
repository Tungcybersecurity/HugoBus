package Model;

public class Nanny {
    private int MaBaoMau;
    private String HoTen;
    private String Email;
    private String SoDienThoai;

    public Nanny(){}

    public String getEmail() {
        return Email;
    }

    public int getMaBaoMau() {
        return MaBaoMau;
    }

    public void setMaBaoMau(int maBaoMau) {
        MaBaoMau = maBaoMau;
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
}
