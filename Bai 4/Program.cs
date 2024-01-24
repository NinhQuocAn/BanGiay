using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao thang muon kiem tra: ");
            int thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("--->thang " + thang + " la mua xuan");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("--->thang " + thang + " la mua ha");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("--->thang " + thang + " la mua thu");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("--->thang " + thang + " la mua dong");
                    break;
                default:
                    Console.WriteLine("Lam gi co thang day ma nhap!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
