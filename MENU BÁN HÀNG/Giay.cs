using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU_BÁN_HÀNG
{
    internal class Giay
    {
        //Bài 2: Tạo class bao gồm các thuộc tính:
        public int GiayId { get; set; }
        public string TenGiay { get; set; }
        public string ThuongHieu { get; set; }
        public int Size { get; set; }
        public string MauSac { get; set; }
        public double Gia { get; set; }
        public int TonKho { get; set; }

        //Tạo constructor
        public Giay(int giayId, string tenGiay, string thuongHieu, int size, string mauSac, double gia, int tonKho)
        {
            GiayId = giayId;
            TenGiay = tenGiay;
            ThuongHieu = thuongHieu;
            Size = size;
            MauSac = mauSac;
            Gia = gia;
            TonKho = tonKho;
        }

        

    }
}
