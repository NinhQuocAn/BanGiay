using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so tuoi cua ban: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhan vien co o quay khong y/n ? ");
            string traLoi = Console.ReadLine();
            if(traLoi == "n" && tuoi >=18)
            {
                Console.WriteLine("Ban co the mua ruou!!");
            }
            else if( traLoi !="y" && traLoi !="n")
            {
                Console.WriteLine("ban da nhap sai");
            }
            else{
                Console.WriteLine("Ban khong the mua ruou!!");
            }
            Console.ReadKey();
        }
    }
}
