package Model;

public class RouteSchedule {
    private int MaLichTrinh;
    private int MaTuyenDuong;
    private String ThuTrongTuan;
    private String GioKhoiHanh;

    public RouteSchedule(){}

    public int getMaLichTrinh() {
        return MaLichTrinh;
    }

    public void setMaLichTrinh(int maLichTrinh) {
        MaLichTrinh = maLichTrinh;
    }

    public int getMaTuyenDuong() {
        return MaTuyenDuong;
    }

    public void setMaTuyenDuong(int maTuyenDuong) {
        MaTuyenDuong = maTuyenDuong;
    }

    public String getThuTrongTuan() {
        return ThuTrongTuan;
    }

    public void setThuTrongTuan(String thuTrongTuan) {
        ThuTrongTuan = thuTrongTuan;
    }

    public String getGioKhoiHanh() {
        return GioKhoiHanh;
    }

    public void setGioKhoiHanh(String gioKhoiHanh) {
        GioKhoiHanh = gioKhoiHanh;
    }
}
