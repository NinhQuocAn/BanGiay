using System;
using System.Collections;

namespace BàiTập1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList { 10, -23, 30, 9, 100, 120, 86 };
            int[] arr = (int[])arrayList.ToArray(typeof(int));
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Mang sau khi sap xep giam dan:");
            foreach (var kq in arr)
            {
                Console.WriteLine(kq);
            }
            Console.ReadKey();
        }
    }
}
