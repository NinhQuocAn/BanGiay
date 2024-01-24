using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DựÁnBánĐiệnThoại
{
    internal class DienThoaiChiTiet : DienThoai
    {
        public int DungLuong { get; set; }
        public string MauSac { get; set; }
        public int SoLuong { get; set; }
        public double GiaTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
