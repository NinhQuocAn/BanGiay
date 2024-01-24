using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu nhat: ");
            float so1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            float so2 = float.Parse(Console.ReadLine());
            float tong = so1 + so2;
            if (tong > 100)
            {
                Console.WriteLine("--->Tong hai so lon hon 100");
            }
            else
            {
                Console.WriteLine("--->Tong hai so nho hon 100");
            }
            Console.ReadKey();
        }
    }    
}

