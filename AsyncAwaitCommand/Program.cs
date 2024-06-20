namespace AsyncAwaitCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsyncMethod();
            Console.WriteLine("Main Thread");
            Console.ReadLine();

        }

        static void Method()
        {
            LongMethod();
          //  Task.Run(() => LongMethod());
            Console.WriteLine("New Thread");
        }

        static async void AsyncMethod()
        {
            //await Task.Run(new Action(LongMethod));
             Task.Run(()=> LongMethod());
            Console.WriteLine("New Thread");
        }

        static void LongMethod()
        {
            Thread.Sleep(5000);
        }
    }
}
