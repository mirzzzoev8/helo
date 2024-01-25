namespace Task3;

public class Date
{
    int day;
    int month;
    int year;
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public Date() {}
    public Date(int _day) {
        day = _day;
    }
    public Date(int _day, int _month) {
        day = _day;
        month = _month;
    }
    public Date(int _day, int _month,int _year) {
        day = _day;
        month = _month;
        year = _year;
    }
    public void SetDate(int _day, int _month,int _year){
        day = _day;
        month = _month;
        year = _year;
    }
    public int GetDay(){
        return day;
    }
    public int GetMonth(){
        return month;
    }
    public int GetYear(){
        return year;
    }
    public string ToString(){
        return $"{day}/{month}/{year}";
    }
}
