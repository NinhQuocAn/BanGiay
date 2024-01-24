using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 8, 14, 5, 23, 10, 11, 17 };
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 2)
                {
                    tong += arr[i];
                }
            }
            Console.WriteLine("Tong cac so chia 3 du 2 la: " + tong);
            Console.ReadKey();
        }
    }
}
