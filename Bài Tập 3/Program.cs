using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList thongTinSinhVien = new ArrayList();
            thongTinSinhVien.Add(new ArrayList() { "An", 18 });
            thongTinSinhVien.Add(new ArrayList() { "khong Biet", 18 });
            thongTinSinhVien.Add(new ArrayList() { "Ten Gi", 16 });
            thongTinSinhVien.Add(new ArrayList() { "Ten gi day", 20 });
            thongTinSinhVien.Add(new ArrayList() { "Bla bla", 19 });

            Console.WriteLine("Thong tin cua 5 sinh vien la: ");
            Console.WriteLine("Thông tin của 5 sinh viên:");
            foreach (ArrayList student in thongTinSinhVien)
            {
                string ten = (string)student[0];
                int tuoi = (int)student[1];
                Console.WriteLine("Ten: "+ten + "  " + " Tuoi: " +tuoi);
            }
            Console.ReadKey();
        }

    }
}
