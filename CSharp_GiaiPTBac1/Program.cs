using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        double x;
        Console.WriteLine("\n Nhap vao so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Nhap vao so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x + {1} = 0.", a, b);
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("\n Phuong trinh co vo so nghiem.");
            }
            else
            {
                Console.WriteLine("\n Phuong trinh vo nghiem.");
            }
        }
    }
}
