namespace MultiThreading
{
    internal class Program
    {   
        public static void func1()
        {
            for (int i = 1; i <=50; i++)
            {
                Console.WriteLine("func1= " + i);
            }
        }
        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("func2= " + i);

                if (i == 25)
                {
                    Console.WriteLine("Thread is going to sleep");
                    Thread.Sleep(1000);
                }
            }
        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("func3= " + i);
            }
        }

        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "My Thread";
            //Console.WriteLine("Current execution thread is " + t.Name);

            //func1();
            //func2();
            //func3();


            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
