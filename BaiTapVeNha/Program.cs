﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeNha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                Console.WriteLine("_________________________MENU_________________________");
                Console.WriteLine(" 1.Tinh dien tich tam giac                            ");
                Console.WriteLine(" 2.Chuyen gio sang giay                               ");
                Console.WriteLine(" 3.In ket qua tran da bong                            ");
                Console.WriteLine(" 0.Thoat chuong trinh                                 ");
                Console.WriteLine("______________________________________________________");
                Console.Write("Nhap lua chon cua ban: ");
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
                            float a, b, c;
                            Console.Write("Xin moi nhap vao canh thu nhat: ");
                            a = float.Parse(Console.ReadLine());
                            Console.Write("Xin moi nhap vao canh thu hai: ");
                            b = float.Parse(Console.ReadLine());
                            Console.Write("Xin moi nhap vao canh thu ba: ");
                            c = float.Parse(Console.ReadLine());
                            float p = (a + b + c) / 2;
                            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                            Console.WriteLine("---->Dien tich tam giac la:  " + s);
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        {
                            float soGio;
                            Console.Write("Xin moi nhap vao so gio: ");
                            soGio = float.Parse(Console.ReadLine());
                            float soGiay = soGio * 3600;
                            Console.WriteLine("---->{0} gio = {1} giay", soGio, soGiay);
                            Console.WriteLine();
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
                        Console.WriteLine("---->Lua chon khong hop le. Vui long chon lai.");
                        Console.WriteLine();
                        break;
                }
            } while (luaChon != 0);
            Console.ReadKey();
        }
    }
}

