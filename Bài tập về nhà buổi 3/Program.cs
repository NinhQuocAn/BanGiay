using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_về_nhà_buổi_3
{
    internal class Program
    {
        // So sánh tổng lớn, nhỏ hơn 100
        static float SoSanh(float so1, float so2)
        {
            float tong = so1 + so2;
            return tong;
        }

        // Tìm số lớn nhất trong 5 số
        static int SoLonNhat(int so1, int so2, int so3, int so4, int so5)
        {
            int soMax = so1;
            if (so2 > soMax)
            {
                soMax = so2;
            }
            if (so3 > soMax)
            {
                soMax = so3;
            }
            if (so4 > soMax)
            {
                soMax = so4;
            }
            if (so5 > soMax)
            {
                soMax = so5;
            }
                return soMax;
        }

        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                Console.WriteLine("************************MENU**************************");
                Console.WriteLine("*  1. So sanh tong lon, nho hon 100                  *");
                Console.WriteLine("*  2. Tim so lon nhat trong 5 so                     *");
                Console.WriteLine("*  3. In ket qua tran da bong                        *");
                Console.WriteLine("*  0. Thoat chuong trinh                             *");
                Console.WriteLine("******************************************************");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 0:
                        {
                            Console.WriteLine("---->Bam phim bat ky trên ban phim de thoat chuong trinh!");
                        }
                        break;

                    case 1:
                        {
                            Console.Write("Nhap vao so thu nhat: ");
                            float so1 = float.Parse(Console.ReadLine());
                            Console.Write("Nhap vao so thu hai: ");
                            float so2 = float.Parse(Console.ReadLine());
                            float tong = SoSanh(so1, so2);
                            if (tong > 100)
                            {
                                Console.WriteLine("--->Tong hai so lon hon 100");
                            }
                            else
                            {
                                Console.WriteLine("--->Tong hai so nho hon 100");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Nhap vao so thu nhat: ");
                            int so1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so thu hai: ");
                            int so2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so thu ba: ");
                            int so3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so thu tu: ");
                            int so4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap vao so thu nam: ");
                            int so5 = int.Parse(Console.ReadLine());
                            int soMax = SoLonNhat(so1, so2, so3, so4, so5);
                            Console.WriteLine("So lon nhat trong 5 so la: "+ soMax);
                        }
                            break;

                    case 3:
                        {
                            int soBan1, soBan2;
                            Console.Write("Xin moi nhap vao so ban thang cua doi 1: ");
                            soBan1 = int.Parse(Console.ReadLine());
                            Console.Write("Xin moi nhap vao so ban thang cua doi 2: ");
                            soBan2 = int.Parse(Console.ReadLine());
                            if (soBan1 > soBan2)
                            {
                                Console.WriteLine("---->Doi 1 thang!");
                            }
                            else if (soBan1 < soBan2)
                            {
                                Console.WriteLine("---->Doi 2 thang!");
                            }
                            else
                            {
                                Console.WriteLine("---->Hai doi hoa nhau!");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("---->Lam gi co dau ma chon -_- \nChon lai de!!!");
                        Console.WriteLine();
                        break;
                }
            } while (luaChon != 0);
            Console.ReadKey();
        }
    }
}
 
