using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mảng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] diemSo = new float[5] {5, 6, 7, 8, 9 };
            float tong = 0, trungBinhCong;
            // Duyet toan bo mang
            for (int i = 0; i <= diemSo.Length; i++)
            {
                tong + = diemSo[i];
            }
            trungBinhCong = tong / diemSo.Length;
            Console.WriteLine("TBC la: " + trungBinhCong);
            Console.ReadKey();

        }
    }
}
