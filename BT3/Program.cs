using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 3:
            ArrayList arl1 = new ArrayList { 7, 12, 5, 7, 18, 5, 12, 9, 7, 18 };
            ArrayList arl2 = new ArrayList();
            foreach (int so in arl1)
            {
                if (!arl2.Contains(so))
                {
                    arl2.Add(so);
                }
            }
            Console.WriteLine("Danh sach sau khi loai bo cac so trung lap:");
            foreach (int so in arl2)
            {
                Console.WriteLine(so);
            }
            Console.ReadKey();
        }
    }
}
