using PatikaPolymorph.Abstract;

namespace PatikaPolymorph.Concrete;

public class Rectangle : BaseGeometry
{
    public Rectangle(double x, double y)
    {
        X = x;
        Y = y;
        Type = "Rectangle";
    }
}