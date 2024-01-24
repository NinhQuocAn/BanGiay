using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapThangDoanNgay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Xin moi nhap vao thang: ");
            int thang = int.Parse(Console.ReadLine());
            int soNgay;
            switch(thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    soNgay = 31;
                    Console.WriteLine("Tháng " + thang + " có " + soNgay + " ngày");
                    break;
                case 4: case 6: case 9: case 11:
                    soNgay = 30;
                    Console.WriteLine("Tháng " + thang + " có " + soNgay + " ngày");
                    break;
                case 2:
                    soNgay = 28;
                    Console.WriteLine("Tháng " + thang + " có " + soNgay + " ngày");
                    break;
                default:
                    Console.WriteLine("Lam gi co ma nhap");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
