using demo5;

class Program
{
    public static void Main()
    {
        HCN a;
        HCN hcn = new HCN();
        double[] arr = new Double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Insert length and width HCN "+ (i+1));
            hcn.insert();
            Console.WriteLine("====================");
            hcn.getArea();
            hcn.getPerimeter();
        }

        
    }
}