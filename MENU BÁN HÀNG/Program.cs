using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_BÁN_HÀNG
{
    internal class Program
    {
        static ArrayList DanhSachGiay = new ArrayList();

        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                Console.WriteLine("________________CUA HANG BAN GIAY NET101______________");
                Console.WriteLine(" 1.Them moi mot doi giay                              ");
                Console.WriteLine(" 2.Danh sach giay                                     ");
                Console.WriteLine(" 3.Mua giay                                           ");
                Console.WriteLine(" 4.Thoat chuong trinh                                 ");
                Console.WriteLine("______________________________________________________");
                Console.Write("Nhap lua chon cua ban: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 4:
                        {
                            Console.WriteLine("---->Bam phim bat ky trên ban phim de thoat chuong trinh!");
                        }
                        break;

                    case 1:
                        {
                            ThemMoiGiay();
                        }
                        break;

                    case 2:
                        {
                            HienThiDanhSachGiay();
                        }
                        break;

                    case 3:
                        {

                        }
                        break;

                    default:
                        Console.WriteLine("---->Lua chon khong hop le. Vui long chon lai.\n");
                        break;
                }
            } while (luaChon != 0);
            Console.ReadKey();
        }


        //Chức năng số 1:
        static void ThemMoiGiay()
        {
            Console.WriteLine("Them thong tin cho doi giay moi:");
            Console.Write("Xin moi nhap vao giayid: ");
            int giayId = int.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao ten giay: ");
            string tenGiay = Console.ReadLine();
            Console.Write("Xin moi nhap vao thuong hieu: ");
            string thuongHieu = Console.ReadLine();
            Console.Write("Xin moi nhap vao size: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao mau sac: ");
            string mauSac = Console.ReadLine();
            Console.Write("Xin moi nhap vao ton kho: ");
            int tonKho = int.Parse(Console.ReadLine());
            Console.Write("Xin moi nhap vao gia: ");
            double gia = double.Parse(Console.ReadLine());
            //Tạo object GiayMoi
            Giay GiayMoi = new Giay(giayId, tenGiay, thuongHieu, size, mauSac, gia, tonKho);
            DanhSachGiay.Add(GiayMoi);
            Console.WriteLine("Them giay moi thanh cong!!\n");
        }

        //Chức năng số 2:
        static void HienThiDanhSachGiay()
        {
            Console.WriteLine("Nhung doi giya hien co: ");
            Console.WriteLine("GiayId\t\tTenGiay\t\tThuongHieu\t\tSize\t\tMauSac\t\tGia\t\tTonKho");
            foreach (Giay giay in DanhSachGiay)
            {
                Console.WriteLine(giay.GiayId + "\t\t" + giay.TenGiay + "\t\t" + giay.ThuongHieu + "\t\t" + giay.Size + "\t\t" + giay.MauSac + "\t\t" + giay.Gia + "\t\t" + giay.TonKho);
            }
        }

        //Chức năng số 3:
        
        }
    }

}



