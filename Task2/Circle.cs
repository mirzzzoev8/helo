using System.Net.NetworkInformation;

namespace Task2;

public class Circle
{
    private double radius { get; set; }
    private double PI = 3.14; 
   
    public Circle(double _radius)
    {
        radius = _radius;
    }
    public void SetRadius(double _radius){
        radius = _radius;
    }
    public double GetRadius(){
        return radius ;
    }
    public double GetArea(){
        return PI * radius * radius ;
    }
    public double GetDiameter(){
        return  radius * 2 ;
    }public double GetCircumference(){
        return   2 * PI * radius ;
    }



    
}
