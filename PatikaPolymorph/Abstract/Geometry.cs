using System.ComponentModel.Design;

namespace PatikaPolymorph.Abstract;

//Abstract base geometry class that has everything that every subclass has to have.
// No objects can be newed.
public abstract class BaseGeometry
{
    //Fields for encapsulation of x and y properties because they cannot be 0 or negative.
    private double _x;
    private double _y;
    
    //Property of type.
    public string Type { get; set; }
    
    
    public double X
    {
        get
        {
            return _x;
        }
        set
        {
            if (value > 0)
            {
                _x = value;
            }
            else
            {
                Console.WriteLine("No doubles under 0 !!!");
            }
        }
    }

    public double Y
    {
        get
        {
            return _y;
        }
        set
        {
            if (value > 0)
            {
                _y = value;
            }
            else
            {
                Console.WriteLine("No doubles under 0 !!!");
            }
        }
    }

    public virtual void CalculateArea()
    {
        Console.WriteLine("Area of the shape is " + (X*Y));
    }

    public void Info()
    {
        Console.WriteLine("x = " + _x + ", y = " + _y);
        Console.WriteLine("Shape type: " + Type);
        CalculateArea();
        Console.WriteLine("\n");
    }
}