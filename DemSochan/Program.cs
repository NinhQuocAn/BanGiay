using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemSochan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList so = new ArrayList();
            ArrayList TrungGian = new ArrayList();
            so.Add(1);
            so.Add(2);
            so.Add(3);
            so.Add(4);
            so.Add(5);
            so.Add(6);
            int dem = 0;

            for (int i = 0; i < so.Count; i++)
            {
                if ((int)so[i] % 2 == 0)
                {
                    dem++;
                }
                else
                {

                }
            }

           


            Console.ReadKey();
        }
    }
}
