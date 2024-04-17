package Model;

public class Contract {
    private int MaHopDong;
    private int MaHocsinh;
    private int MaPhuHuynh;
    private String NgayBatDauHopDong;
    private String NgayKetThucHopDong;
    private String NgayDangKy;
    private String GiaTien;

    public Contract(){}

    public int getMaHopDong() {
        return MaHopDong;
    }

    public void setMaHopDong(int maHopDong) {
        MaHopDong = maHopDong;
    }

    public int getMaHocsinh() {
        return MaHocsinh;
    }

    public void setMaHocsinh(int maHocsinh) {
        MaHocsinh = maHocsinh;
    }

    public int getMaPhuHuynh() {
        return MaPhuHuynh;
    }

    public void setMaPhuHuynh(int maPhuHuynh) {
        MaPhuHuynh = maPhuHuynh;
    }

    public String getNgayBatDauHopDong() {
        return NgayBatDauHopDong;
    }

    public void setNgayBatDauHopDong(String ngayBatDauHopDong) {
        NgayBatDauHopDong = ngayBatDauHopDong;
    }

    public String getNgayKetThucHopDong() {
        return NgayKetThucHopDong;
    }

    public void setNgayKetThucHopDong(String ngayKetThucHopDong) {
        NgayKetThucHopDong = ngayKetThucHopDong;
    }

    public String getNgayDangKy() {
        return NgayDangKy;
    }

    public void setNgayDangKy(String ngayDangKy) {
        NgayDangKy = ngayDangKy;
    }

    public String getGiaTien() {
        return GiaTien;
    }

    public void setGiaTien(String giaTien) {
        GiaTien = giaTien;
    }
}
