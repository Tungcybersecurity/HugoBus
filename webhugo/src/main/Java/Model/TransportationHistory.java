package Model;

public class TransportationHistory {
    private int MaLichSuDuaDon;
    private int  MaHocSinh;
    private int MaTaiXe;
    private String Ngay;
    private String ThoiGianDi;
    private String ThoiGianDen;

    public TransportationHistory(){}

    public int getMaLichSuDuaDon() {
        return MaLichSuDuaDon;
    }

    public void setMaLichSuDuaDon(int maLichSuDuaDon) {
        MaLichSuDuaDon = maLichSuDuaDon;
    }

    public int getMaHocSinh() {
        return MaHocSinh;
    }

    public void setMaHocSinh(int maHocSinh) {
        MaHocSinh = maHocSinh;
    }

    public int getMaTaiXe() {
        return MaTaiXe;
    }

    public void setMaTaiXe(int maTaiXe) {
        MaTaiXe = maTaiXe;
    }

    public String getNgay() {
        return Ngay;
    }

    public void setNgay(String ngay) {
        Ngay = ngay;
    }

    public String getThoiGianDi() {
        return ThoiGianDi;
    }

    public void setThoiGianDi(String thoiGianDi) {
        ThoiGianDi = thoiGianDi;
    }

    public String getThoiGianDen() {
        return ThoiGianDen;
    }

    public void setThoiGianDen(String thoiGianDen) {
        ThoiGianDen = thoiGianDen;
    }
}
