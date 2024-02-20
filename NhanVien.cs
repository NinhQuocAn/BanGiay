using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class NhanVien
    {
        private int ID { get; set; }
        private string Ten { get; set; }
        private double Luong { get; set; }

        public NhanVien()
        {
            
        }


        public NhanVien(int iD, string ten, double luong)
        {
            ID = iD;
            Ten = ten;
            Luong = luong;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {this.ID} - Ten: {this.Ten} - Luong: {this.Luong}");
        }



        public double GetLuong()
        {
            return this.Luong;
        }


        public int GetID()
        {
            return this.ID;
        }
    }
}
