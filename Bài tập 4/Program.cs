using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam hien tai: ");
            int namHienTai = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac nam nhuan tu " + namSinh + " den " + namHienTai);
            for (int i = namSinh; i <= namHienTai; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }  
    }
}
