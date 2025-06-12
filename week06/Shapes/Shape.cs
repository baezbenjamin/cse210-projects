using System.Runtime.InteropServices.Marshalling;

public class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return -1;
    }
}

// A better aproach can be:
// public abstract double GetArea();
// I should have also made the class abstract