using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt1_B6
{
    internal class SanPham
    {
        //Bài 1: Tạo thuộc tính
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        //Bài 2 Tạo 2 constructor
        // constructor 1:
        public SanPham()
        {

        }

        // constructor 2:
        public SanPham(int maSanPham, string tenSanPham, int donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        //Bài 3: Tạo method
        public int TinhTien()
        {
            int thanhTien = DonGia * SoLuong;
            return thanhTien;
        }

        //Bài 4: Method in ra màn hình
            public void InRaManHinh()
            {
                Console.WriteLine("Ma san pham: "+MaSanPham);
                Console.WriteLine("Ten san pham: "+TenSanPham);
                Console.WriteLine("Don gia: "+DonGia);
                Console.WriteLine("So luong: "+SoLuong);
                Console.WriteLine("Thanh Tien: " + TinhTien());
            }
    }
}
