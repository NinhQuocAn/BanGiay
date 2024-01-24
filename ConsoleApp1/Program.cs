using System;
using System.Collections;

namespace BàiTập1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, -23, 30, 9, 120, 100, 120, 86 };
            ArrayList al1 = new ArrayList();

            // Thêm từng phần tử của mảng vào ArrayList
            foreach (int num in arr)
            {
                al1.Add(num);
            }

            // Sắp xếp và đảo ngược mảng
            arr = (int[])al1.ToArray(typeof(int));
            Array.Sort(arr);
            Array.Reverse(arr);

            // In ra mảng sau khi sắp xếp giảm dần
            Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
            foreach (var value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
