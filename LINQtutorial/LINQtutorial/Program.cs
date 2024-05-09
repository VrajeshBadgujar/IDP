using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = {22, 43, 21, 10, 19, 20 };


            var a = from i in age where i > 20 orderby i select i ; 

            //foreach(var i in a)
            //{
            //    Console.WriteLine(i);
            //}
            
             var b = from name in new string[] { "Vrajesh", "dipesh", "yatin", "Adil" } where name.Contains("sh") select name;

            foreach(var name in b)
            {
                Console.WriteLine(name);
            }
        }
    }
}
