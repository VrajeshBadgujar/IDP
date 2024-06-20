namespace ThreadingEvent
{
    internal class Program
    {
       static AutoResetEvent objAuto = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            new Thread(someMethod).Start();
            Console.ReadLine();

            //singled to start again for wait 1
            objAuto.Set();

            new Thread(someMethod).Start();
            Console.ReadLine();

            //singled to start again for wait 2
            objAuto.Set();

        }
        static void someMethod()
        {
            Console.WriteLine("Starting ...");

            objAuto.WaitOne();   //wait 1

            Console.WriteLine("Finishing ...");


            Console.WriteLine("Starting ...");

            objAuto.WaitOne();   //wait 2

            Console.WriteLine("Finishing ...");

        }
    }
}


// ManuelResetEvent = only one objAuto.Set(); is required 
