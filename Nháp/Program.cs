using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nháp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thu nhat: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu hai: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu ba: ");
            int so3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu tu: ");
            int so4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu nam: ");
            int so5 = int.Parse(Console.ReadLine());
            int soMax = so1;
            if (so2 > soMax)
            {
                soMax = so2;
            }
            if (so3 > soMax)
            {
                soMax = so3;
            }
            if (so4 > soMax)
            {
                soMax = so4;
            }
            if (so5 > soMax)
            {
                soMax = so5;
            }
            Console.WriteLine("So lon nhat trong 5 so la: " + soMax);
            Console.ReadKey();
        }
    }
}
