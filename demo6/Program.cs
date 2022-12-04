namespace demo6;


class Program
{
    public static void Main()
    {
        int[] aHCN = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Get HCN " +(i+1));
            HCN hcn = new HCN();
            hcn.getInfHCN();
            Console.WriteLine("======================");
            Console.Write("Perimeter: ");
            hcn.Peri();
            Console.WriteLine("------------------");
            Console.Write("Area: ");
            hcn.Area();
        }

        HT ht = new HT();
        ht.getInfHT();
        Console.WriteLine("======================");
        Console.Write("Perimeter: ");
        ht.Peri();
        Console.WriteLine("------------------");
        Console.Write("Area: ");
        ht.Area();

    }
}