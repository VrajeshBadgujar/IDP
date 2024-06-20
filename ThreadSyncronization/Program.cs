namespace ThreadSyncronization
{
    internal class Program
    {   

        static Maths objMaths = new Maths();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(objMaths.Divide);  //child thread
            t1.Start();                  
            objMaths.Divide();                        //main thread
        }

        class Maths {

            public int Num1;
            public int Num2;

            Random o = new Random();

            public void Divide()
            {
                for (int i = 0; i < 100000; i++)
                    lock (this)
    
                {
                    Num1 = o.Next(1, 2);
                    Num2 = o.Next(1,2);

                    int result = Num1 / Num2;

                    Num1 = 0;
                    Num2 = 0;

                        if (i == 10000) Console.WriteLine("Mission successful");
                }
            }
                
        }

    }
}
