namespace demo6;

public class HT : hinh2D
{
    public int r;

    public void getInfHT()
    {
        
        Console.Write("Get r: ");
        r = int.Parse(Console.ReadLine());
    }
    
    public override void Peri()
    {
        Console.WriteLine((r * 2) * 3.14);
    }

    public override void Area()
    {
        Console.WriteLine((r * r) * 3.14);
    }
}