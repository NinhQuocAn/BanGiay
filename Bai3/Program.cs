
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soBan1,soBan2;
            Console.Write("Xin moi nhap vao so ban thang cua doi 1: ");
            soBan1 = int.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao so ban thang cua doi 2: ");
            soBan2 = int.Parse(Console.ReadLine());
            if(soBan1 > soBan2)
            {
                Console.WriteLine("Doi 1 thang!");
            }else if(soBan1 < soBan2)
            {
                Console.WriteLine("Doi 2 thang!");
            }
            else
            {
                Console.WriteLine("Hai doi hoa nhau!");
            }
            Console.ReadKey();
        }
    }
}
