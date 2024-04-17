package Model;

public class PersonalNotice {
    private int MaThongBao;
    private int MaPhuHuynh;
    private String TieuDe;
    private String NoiDung;
    private String NgayGui;
    private String ThoiGianGui;
    private short DaXem;

    public PersonalNotice(){}

    public int getMaThongBao() {
        return MaThongBao;
    }

    public void setMaThongBao(int maThongBao) {
        MaThongBao = maThongBao;
    }

    public int getMaPhuHuynh() {
        return MaPhuHuynh;
    }

    public void setMaPhuHuynh(int maPhuHuynh) {
        MaPhuHuynh = maPhuHuynh;
    }

    public String getTieuDe() {
        return TieuDe;
    }

    public void setTieuDe(String tieuDe) {
        TieuDe = tieuDe;
    }

    public String getNoiDung() {
        return NoiDung;
    }

    public void setNoiDung(String noiDung) {
        NoiDung = noiDung;
    }

    public String getNgayGui() {
        return NgayGui;
    }

    public void setNgayGui(String ngayGui) {
        NgayGui = ngayGui;
    }

    public String getThoiGianGui() {
        return ThoiGianGui;
    }

    public void setThoiGianGui(String thoiGianGui) {
        ThoiGianGui = thoiGianGui;
    }

    public short getDaXem() {
        return DaXem;
    }

    public void setDaXem(short daXem) {
        DaXem = daXem;
    }
}
