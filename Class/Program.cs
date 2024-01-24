using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CauThu messi = new CauThu("Messi", 10, 99, 70, 50);

            //Tạo thuộc tính
            //messi.Ten = "Messi";
            //messi.SoAo = 10;
            //messi.CS_Sut = 99;
            //messi.CS_TocDo = 70;
            //messi.CS_PhongThu = 50;

            //Gọi phương thức
            messi.TangToc();

            Console.ReadKey();
        }
    }
}
