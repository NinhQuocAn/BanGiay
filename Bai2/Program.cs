using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float soGio;
            Console.Write("Xin moi nhap vao so gio: ");
            soGio = float.Parse(Console.ReadLine());
            float soGiay = soGio * 3600;
            Console.WriteLine("{0} gio = {1} giay", soGio, soGiay);
            Console.ReadKey();
        }
    }
}
