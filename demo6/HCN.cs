namespace demo6;

public class HCN : hinh2D
{
    public int length;
    public int width;


    public void getInfHCN()
    {
        Console.Write("get Length: ");
        length = int.Parse(Console.ReadLine());
        Console.Write("get Width: ");
        width = int.Parse(Console.ReadLine());
    }
    
    public override void Peri()
    {
        Console.WriteLine((length + width) * 2);
    }

    public override void Area()
    {
        Console.WriteLine((length * width));
    }
}