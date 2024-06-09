package Model;

import java.util.ArrayList;

public class ScheduleStudent {
    private ArrayList<String> thu = new ArrayList<>();
    private ArrayList<String> buoi = new ArrayList<>();

    public ArrayList<String> getThu() {
        return thu;
    }

    public void setThu(String thu) {
        this.thu.add(thu);
    }

    public ArrayList<String> getBuoi() {
        return buoi;
    }

    public void setBuoi(String buoi) {
        this.buoi.add(buoi);
    }

    public ScheduleStudent()
    {

    }


}
