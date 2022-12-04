
Console.Write("Nhap vao 1 so bat ki : ");
int n = int.Parse(Console.ReadLine());
int s = 1;
for (int i = 1; i <= n; i++)
{
    s = i * s;
}

Console.Write(n + "! = ");
Console.Write(s);