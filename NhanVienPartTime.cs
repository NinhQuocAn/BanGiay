using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class NhanVienPartTime : NhanVien
    {
        private double SoGioLamViec{ get; set; }

        public NhanVienPartTime()
        {
            
        }

        public NhanVienPartTime(int ID, string ten, double luong, double soGioLamViec)
            : base (ID, ten, luong)
        {
            SoGioLamViec = soGioLamViec;
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("Luong tong: " + (SoGioLamViec * GetLuong()));
        }
    }
}
