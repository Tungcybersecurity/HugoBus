package Model;

public class AttendanceTaking {
    private int MaDiemDanh;
    private int MaPhanCong;
    private String NgayDiemDanh;
    private String ThoiGianDiemDanh;
    private short DaDon;

    public AttendanceTaking(){}

    public int getMaDiemDanh() {
        return MaDiemDanh;
    }

    public void setMaDiemDanh(int maDiemDanh) {
        MaDiemDanh = maDiemDanh;
    }

    public int getMaPhanCong() {
        return MaPhanCong;
    }

    public void setMaPhanCong(int maPhanCong) {
        MaPhanCong = maPhanCong;
    }

    public String getNgayDiemDanh() {
        return NgayDiemDanh;
    }

    public void setNgayDiemDanh(String ngayDiemDanh) {
        NgayDiemDanh = ngayDiemDanh;
    }

    public String getThoiGianDiemDanh() {
        return ThoiGianDiemDanh;
    }

    public void setThoiGianDiemDanh(String thoiGianDiemDanh) {
        ThoiGianDiemDanh = thoiGianDiemDanh;
    }

    public short getDaDon() {
        return DaDon;
    }

    public void setDaDon(short daDon) {
        DaDon = daDon;
    }
}
