using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bảng_cửu_chương_fake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Xin moi nhap vao n: ");
            int n = int.Parse(Console.ReadLine());
            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
            }
            Console.ReadKey();
        }
    }
}