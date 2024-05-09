using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionDemo
{
    // public delegate void MyDelegtae(int num);
    public delegate int MyDelegate(int num);   
    internal class Program
    {
        static void Main(string[] args)
        {
            //    MyDelegtae d1 = (a) =>
            //    {
            //        a += 10;
            //        Console.WriteLine(a);
            //    };

            // d1.Invoke(5);


            MyDelegate d2 = (b) => b * b * 2;

            Console.WriteLine(d2(3));



        }
    }
}
