
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Xin moi nhap vao canh thu nhat: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao canh thu hai: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao canh thu ba: ");
            c = float.Parse(Console.ReadLine());
            float p = (a + b + c)/2;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.Write("Dien tich tam giac la:  " + s);
            Console.ReadKey();
        }
    }
}
