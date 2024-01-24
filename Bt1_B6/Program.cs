using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_B6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một ArrayList để lưu danh sách sản phẩm
            ArrayList danhSachSanPham = new ArrayList();

            // Nhập thông tin cho 3 sản phẩm từ bàn phím
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhap thong tin cho san pham thu " + (i + 1));

                Console.Write("Nhap ma san pham: ");
                int maSanPham = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten san pham: ");
                string tenSanPham = Console.ReadLine();

                Console.Write("Nhap don gia: ");
                int donGia = int.Parse(Console.ReadLine());

                Console.Write("Nhap so luong: ");
                int soLuong = int.Parse(Console.ReadLine());

                // Tạo đối tượng SanPham từ thông tin nhập vào
                SanPham sanPham = new SanPham(maSanPham, tenSanPham, donGia, soLuong);

                // Thêm sản phẩm vào danh sách
                danhSachSanPham.Add(sanPham);
            }

            // In thông tin của 3 sản phẩm ra màn hình
            Console.WriteLine("\nThong tin 3 san pham:");
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.InRaManHinh();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
  
