// See https://aka.ms/new-console-template for more information

class Program
{
    static Boolean snt(int n)
    {
        if (n < 2)
        {
            return false;
        }
        int can_bac_hai = (int)Math.Sqrt(n);
        int i;
        for (i = 2; i <= can_bac_hai; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(String[] agrs)
    {
        // check a co phai snt hay khong       
        Console.Write("Nhap a = ");
        int a;
        a = int.Parse(Console.ReadLine());
        if (snt(a))
        {
            Console.WriteLine(a + " la so nguyen to");
        }
        else
        {
            Console.WriteLine(a + " khong phai la so nguyen to");
        }
        
        // hien thi snt tu 1 -  a
        
        Console.Write("Cac so nguyen to tu 1 - a la : ");
        for (int i = 0; i <= a; i++)
        {
            if (snt(i))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}


