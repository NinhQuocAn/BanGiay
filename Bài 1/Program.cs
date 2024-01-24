using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] soTien = new int[] { 3, 4, 23, 18, 50, 99 };
            for (int i = 0; i < soTien.Length; i++)
            {
                int tienTrieu = soTien[i] * 1000000;
                Console.WriteLine(tienTrieu + " VNĐ");
            }
            Console.ReadKey();
        }
    }
}
