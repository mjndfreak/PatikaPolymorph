using PatikaPolymorph.Abstract;

namespace PatikaPolymorph.Concrete;

public class Square : BaseGeometry
{
    // for square constructor both x and y is the same.
    public Square(double x)
    {
        Y = x;
        X = x;
        Type = "Square";
    }
}