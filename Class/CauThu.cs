using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class CauThu
    {
        //Tạo thuộc tính nhanh : prop + tab
        public string Ten { get; set; }
        public int SoAo { get; set; }
        public int CS_TocDo { get; set; }
        public int CS_Sut { get; set; }
        public int CS_PhongThu { get; set; }

        //Tạo constructor

        public CauThu()
        {
            
        }

        public CauThu(string ten, int soAo, int cS_TocDo, int cS_Sut, int cS_PhongThu)
        {
            Ten = ten;
            SoAo = soAo;
            CS_TocDo = cS_TocDo;
            CS_Sut = cS_Sut;
            CS_PhongThu = cS_PhongThu;
        }




        //Tạo phương thức
        //this được sử dụng để đại diện cho đối tượng hiện tại
        public void TangToc(int CS_TocDo)
        {
            this.CS_TocDo *= 2;
        }

        /* Hàm tạo (constructor)
         * Đặc điểm: tên = tên class. Cung cấp cách tạo ra đối tượng
         * Tạo constructor nhanh: Ctor + tab
          */
    }
}


/*OOP
 * Đóng gói
 * Đa hình
 * Kế thừa
 * Trừu tượng
 */