
Console.Write("Nhap vao canh. hinh` vuong : ");
int a ;
a = int.Parse(Console.ReadLine());
int i, j;
for ( i = 0; i < a; i++)
{
    for ( j = 0; j < a; j++)
    {
        if (i == 0 || i == a - 1 || j == 0 || j == a - 1) {
            Console.Write("*  ");
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.Write("\n");
}
