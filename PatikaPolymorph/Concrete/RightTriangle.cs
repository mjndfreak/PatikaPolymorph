using PatikaPolymorph.Abstract;

namespace PatikaPolymorph.Concrete;

public class RightTriangle : BaseGeometry
{
    public RightTriangle(double x, double y)
    {
        X = x;
        Y = y;
        Type = "Right Triangle";
    }
    
    //Im overriding the virtual method in base class coz i have to divide it by 2.
    public override void CalculateArea()
    {
        Console.WriteLine("Area of the shape is " + ((X*Y)/2));
    }
}