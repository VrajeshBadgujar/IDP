using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {  
        public static void printArr<T>(T[] arr)
        {

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] +" ");

            }
        }

        public static bool Check<T, U>(T a, U b)
        {
           bool res = a.Equals(b);
            return res;
        }

        public static void showType<T, U>(T a, U b)        {
            Console.WriteLine(typeof(U));
        }
        


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            double[] arr2 = { 1.0, 2.0 };
            string[] arr3 = { "Vrajesh",  "dipesh"};
            char[] arr4 = { 'a','b', 'c' };

            //printArr(arr);
            //printArr(arr2);
            //printArr(arr3);
            //printArr(arr4);

            //Console.WriteLine(Check(12, 13));

            showType("Vraj", 4);
        }
    }
}
