package Model;

public class Payment {
    private int MaThanhToan;
    private int MaHopDong;
    private String NgayThanhToan;
    private int SoTienThanhToan;
    private String PhuongThucThanhToan;

    public Payment(){}

    public int getMaThanhToan() {
        return MaThanhToan;
    }

    public void setMaThanhToan(int maThanhToan) {
        MaThanhToan = maThanhToan;
    }

    public int getMaHopDong() {
        return MaHopDong;
    }

    public void setMaHopDong(int maHopDong) {
        MaHopDong = maHopDong;
    }

    public String getNgayThanhToan() {
        return NgayThanhToan;
    }

    public void setNgayThanhToan(String ngayThanhToan) {
        NgayThanhToan = ngayThanhToan;
    }

    public int getSoTienThanhToan() {
        return SoTienThanhToan;
    }

    public void setSoTienThanhToan(int soTienThanhToan) {
        SoTienThanhToan = soTienThanhToan;
    }

    public String getPhuongThucThanhToan() {
        return PhuongThucThanhToan;
    }

    public void setPhuongThucThanhToan(String phuongThucThanhToan) {
        PhuongThucThanhToan = phuongThucThanhToan;
    }
}
