package Model;

public class PublicNotice {
    private int MaThongBaoCongKhai;
    private String TieuDe;
    private String NoiDung;
    private String NgayGui;
    private short DaXem;

    public PublicNotice(){}

    public int getMaThongBaoCongKhai() {
        return MaThongBaoCongKhai;
    }

    public void setMaThongBaoCongKhai(int maThongBaoCongKhai) {
        MaThongBaoCongKhai = maThongBaoCongKhai;
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

    public short getDaXem() {
        return DaXem;
    }

    public void setDaXem(short daXem) {
        DaXem = daXem;
    }
}
