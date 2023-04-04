public class Circle : Shape
{
    int _radius;
    public Circle(string color, int radius) : base(color)
    {
    }

    public override double GetArea()
    {
        return _radius * 3.14;
    }
}