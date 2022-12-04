namespace demo5;

public class HCN
{
    public double length;
    public double width;
    
    public void insert()
    {
        Console.Write("Insert length: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Insert width: ");
        width = double.Parse(Console.ReadLine());
        
    }

    public double getArea()
    {
        return (length * width);
    }

    public double getPerimeter()
    {
        return (length + width) * 2;
    }

    public void show()
    {
        Console.WriteLine("Area and Perimeter");
        Console.WriteLine("Area: " + getArea());
        Console.WriteLine("Perimeter: " + getPerimeter());
    }
    
}