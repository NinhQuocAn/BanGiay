using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            int luaChon;
            do
            {
                Console.WriteLine("__________________________QUAN LY NHAN VIEN______________________________");
                Console.WriteLine(" 1.Nhap 1 or nhieu nhan vien                                             ");
                Console.WriteLine(" 2.Xuat danh sach nhan vien                                              ");
                Console.WriteLine(" 3.Xuat danh sach nhan vien co tien luong lon hon so tien nguoi dung nhap");
                Console.WriteLine(" 4.Tim nhan vien theo ma ID                                              ");
                Console.WriteLine(" 5.Ke thua                                                               ");
                Console.WriteLine(" 0. Thoat                                                                ");
                Console.WriteLine("_________________________________________________________________________");
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
                            qLNhanVien.ThemNhanVien();
                        }
                        break;

                    case 2:
                        {
                            qLNhanVien.XuatDanhSach();
                        }
                        break;

                    case 3:
                        {
                            qLNhanVien.XuatDanhSach2();
                        }
                        break;
                    case 4:
                        {
                            qLNhanVien.TimNhanVien();
                        }
                        break;
                    case 5:
                        {
                            Console.Write("ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Ten: ");
                            string ten = Console.ReadLine();
                            Console.Write("Luong: ");
                            double luong = double.Parse(Console.ReadLine());
                            Console.Write("So gio lam viec: ");
                            int timeWork = int.Parse(Console.ReadLine());
                            NhanVienPartTime nvpt = new NhanVienPartTime(id, ten, luong, timeWork);
                            nvpt.InThongTin();
                        }
                        break;

                    default:
                        Console.WriteLine("---->Lua chon khong hop le. Vui long chon lai.\n");
                        break;
                }
            } while (luaChon != 0);
            Console.ReadKey();
        }
    }
}
