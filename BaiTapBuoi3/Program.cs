using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nhập vào tiền lương và tiền thưởng ---> Tính thuế phải trả
namespace BaiTapBuoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao luong: ");
            float luong = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao tien thuong: ");
            float tienThuong = float.Parse(Console.ReadLine());
            float tongTien = luong + tienThuong;
            Console.WriteLine("Tien cua ban la: " + tongTien + " trieu");
            if (tongTien < 9)
            {
                Console.WriteLine("Lam gi co tien ma tru");
            }
            else if (tongTien < 15)
            {
                Console.WriteLine("Thue 10% = " + tongTien / 10 + " trieu");
            }
            else if (tongTien < 30)
            {
                Console.WriteLine("Thue 15% = " + tongTien * 15 / 100 + " trieu");
            }
            else
            {
                Console.WriteLine("Thue 20% = " + tongTien * 20 / 100 + " trieu");
            }
            Console.ReadKey();
        }
    }
}
