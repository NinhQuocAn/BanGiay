using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Xin moi nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Mang ban vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Mang dao nguoc la: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " "); ;
            }



            Console.ReadKey();
        }
    }
}
