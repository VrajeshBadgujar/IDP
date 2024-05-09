using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Example<T>
    {
        T box;

        //public Example(int b)
        //{
        //    this.box = b;
        //}

        //public T GetBox() { return box; }

        //public void SetBox(T b) {
        //    this.box = b;
        //}

        public T Box {
            set
            {
                this.box = value;
            }
            get { 
                return this.box; 
            }        
                }

        public void add<U>(T a, U b) 

        {


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Example<int> e1 = new Example<int>();
            //e1.SetBox(10);
            e1.Box = 10;

            //Console.WriteLine(e1.GetBox());
            Console.WriteLine(e1.Box);

            //Example<string> e2 = new Example<string>();
            //e2.SetBox("Vrajesh"); 

            //Console.WriteLine(e2.GetBox());


        }
    }
}
