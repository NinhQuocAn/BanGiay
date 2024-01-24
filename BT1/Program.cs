using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1:
            string ten, queQuan, soThich;
            Console.Write("Moi ban nhap vao ten: ");
            ten = Console.ReadLine();
            Console.Write("Moi nhap vao tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap vao que quan: ");
            queQuan = Console.ReadLine();
            Console.Write("Moi ban nhap vao so thich: ");
            soThich = Console.ReadLine();

            Console.WriteLine("--->Toi ten la " + ten + ", nam nay " + tuoi + " tuoi, que o " + queQuan + " va so thich la " + soThich);
            Console.ReadKey();
        }
    }
}
