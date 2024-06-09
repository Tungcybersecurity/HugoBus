package Model;

import com.fasterxml.jackson.annotation.JsonProperty;

public class DetailsContract {

    @JsonProperty("idchitiet")
    private int idchitiet;

    @JsonProperty("thutrongtuan")
    private int thutrongtuan;

    @JsonProperty("buoi")
    private String buoi;

    @JsonProperty("idhopdong")
    private int idhopdong;

    public DetailsContract(){
    }

    public DetailsContract(int idchitiet, int thutrongtuan, String buoi, int idhopdong) {
        this.idchitiet = idchitiet;
        this.thutrongtuan = thutrongtuan;
        this.buoi = buoi;
        this.idhopdong = idhopdong;
    }

    public int getIdchitiet() {
        return idchitiet;
    }

    public void setIdchitiet(int idchitiet) {
        this.idchitiet = idchitiet;
    }

    public int getThutrongtuan() {
        return thutrongtuan;
    }

    public void setThutrongtuan(int thutrongtuan) {
        this.thutrongtuan = thutrongtuan;
    }

    public String getBuoi() {
        return buoi;
    }

    public void setBuoi(String buoi) {
        this.buoi = buoi;
    }

    public int getIdhopdong() {
        return idhopdong;
    }

    public void setIdhopdong(int idhopdong) {
        this.idhopdong = idhopdong;
    }
}