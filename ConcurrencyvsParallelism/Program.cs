
namespace ConcurrencyvsParallelism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();

            //Task.Factory.StartNew(Method1);
            //Task.Factory.StartNew(Method2);


            Console.WriteLine("Start data input, Enter your name");
            String str = Console.ReadLine();
            Console.WriteLine("Your name is : " + str);

           // Console.Read();
        }
        private static async void Method1()
        {
            await Task.Delay(2000);
            Console.WriteLine("Downloaded file 1");
        }
        private static async void Method2()
        {
           await Task.Delay(2000);
           Console.WriteLine("Downloaded file 2");
        }

        
    }
}
