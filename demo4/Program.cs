
using System.Drawing;

struct product
{ 
    public string name;
    public string producer;
    public int price;
    public string color;
    public string size;
};

//Khai bao 1 mang 5 phan tu cua struct sinhVien

class Program
{
    public static void Main(string[] args)
    {
        int d = 0;
        int max = 0;
        product[] sv = new product[5];

        //Nhap
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Name of Product " + (i + 1) + " : ");
            sv[i].name = Console.ReadLine();
            Console.Write("Name of Producer " + (i + 1) + " : ");
            sv[i].producer = Console.ReadLine();
            Console.Write("Price " + (i + 1) + " : ");
            sv[i].price = int.Parse(Console.ReadLine());
            Console.Write("Color " + (i + 1) + " : ");
            sv[i].color = Console.ReadLine();
            Console.Write("Size " + (i + 1) + " : ");
            sv[i].size = Console.ReadLine();
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (sv[i].price > sv[j].price)
                {
                    d = sv[j].price;
                    sv[j].price = sv[i].price;
                    sv[i].price = d;
                }
            }
        }


        //hien thi
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(("------------------------"));
            Console.WriteLine("All Product");
            Console.WriteLine("Product " + (i + 1) + " : ");
            Console.WriteLine("Name: " + sv[i].name);
            Console.WriteLine("Producer: " + sv[i].producer);
            Console.WriteLine("Price: " + sv[i].price);
            Console.WriteLine("Color: " + sv[i].color);
            Console.WriteLine("Size: " + sv[i].size);
        }

        for (int i = 4; i < 5; i++)
        {
            Console.WriteLine(("------------------------"));
            Console.WriteLine("The Product has hightest price");
            Console.WriteLine("Product " + (5) + " : ");
            Console.WriteLine("Name: " + sv[i].name);
            Console.WriteLine("Producer: " + sv[i].producer);
            Console.WriteLine("Price: " + sv[i].price);
            Console.WriteLine("Color: " + sv[i].color);
            Console.WriteLine("Size: " + sv[i].size);
        }
    }
}