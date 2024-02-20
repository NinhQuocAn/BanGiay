using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class QLNhanVien
    {
        public List<NhanVien> DanhSachNhanVien { get; set; }

        public QLNhanVien()
        {
            DanhSachNhanVien = new List<NhanVien>();
        }

        //Chức năng 1:
        public void ThemNhanVien()
        {
            do
            {
                Console.WriteLine("Nhap thong tin cho nhan vien");
                Console.Write("Nhap ID nhan vien: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten nhan vien: ");
                string ten = Console.ReadLine();
                Console.Write("Nhap luong nhan vien: ");
                int luong = int.Parse(Console.ReadLine());
                NhanVien nhanVien = new NhanVien(ID, ten, luong);
                this.DanhSachNhanVien.Add(nhanVien);
                Console.WriteLine("Them nhan vien thanh cong!! Ban co muon tiep tuc nhap khong?? ( 0_Khong, 1_Co)");
            } while (int.Parse(Console.ReadLine()) != 0);
        }


        //Chức năng 2:
        public void XuatDanhSach()
        {
            foreach (NhanVien nhanVien in DanhSachNhanVien)
            {
                nhanVien.InThongTin();
            }
        }


        //Chức năng 3:
        public void XuatDanhSach2()
        {
            Console.Write("Nhap vao muc luong: ");
            double luongNhanVien = int.Parse(Console.ReadLine());
            foreach (NhanVien nhanVien in DanhSachNhanVien)
            {
                if (nhanVien.GetLuong() > luongNhanVien)
                {
                    nhanVien.InThongTin();
                }
            }
        }


        //Chức năng 4:
        public void TimNhanVien()
        {
            Console.Write("Nhap vao ID nhan vien muon tim: ");
            int iD = int.Parse(Console.ReadLine());
            foreach (NhanVien nhanVien in DanhSachNhanVien)
            {
                if (nhanVien.GetID().Equals(iD))
                {
                    nhanVien.InThongTin();
                }
            }
        }
    }
}
