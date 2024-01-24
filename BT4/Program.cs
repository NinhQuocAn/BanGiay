using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 4:
            int namSinh;
            Console.Write("Nhap vao nam sinh cua ban: ");
            namSinh = int.Parse(Console.ReadLine());
            int namHienTai;
            Console.Write("Nhap vao nam hien tai: ");
            namHienTai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhung nam nhuan tu nam:" + namSinh + " den " + namHienTai +" la: ");
            for (int i = namSinh; i <= namHienTai; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
