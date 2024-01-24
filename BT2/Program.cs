using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 2:
            double nhietDo;
            Console.Write("Xin moi nhap vao nhiet do hien tai: ");
            nhietDo = double.Parse(Console.ReadLine());
            if (nhietDo <= 10 )
            {
                Console.WriteLine("---> Rat lanh!");
            }else if (nhietDo <= 20 )
            {
                Console.WriteLine("---> Lanh!");
            }else if(nhietDo <= 30 )
            {
                Console.WriteLine("---> Am ap!");
            }else {
                Console.WriteLine("---> Nong!");
            }
            Console.ReadKey();
        }
    }
}
