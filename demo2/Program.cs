Console.Write("Nhap vao 1 so bat ki`: ");
int n = int.Parse(Console.ReadLine());
int dem = 0;

if (n < 2)
{
    Console.WriteLine(n + " khong phai la so nguyen to");
}
else
{
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            dem++;
        }
    }

    if (dem == 2)
    { 
        Console.WriteLine(n + " la so nguyen to");
    }
    else
    {
        Console.WriteLine(n + " khong phai la so nguyen to");
    }
}


