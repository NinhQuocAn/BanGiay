using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so ga: ");
            int soGa = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so bo: ");
            int soBo = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so lon: ");
            int soLon = int.Parse(Console.ReadLine());
            int soChan = (soGa * 2) + (soBo * 4) + (soLon * 4);
            Console.WriteLine("--->Tong cong co " + soChan + " chan");
            Console.ReadKey();
        }
    }
}
