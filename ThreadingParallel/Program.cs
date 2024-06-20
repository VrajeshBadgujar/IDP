namespace ThreadingParallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread t1 = new Thread(RunMillionIteration);
            //t1.Start();

            Parallel.For(0, 1000000, x => RunMillionIteration());

            Console.ReadLine();
        }

        static void RunMillionIteration()
        {
            string x = "";

            for (int i = 0; i < 1000000; i++)
            {
                x += "s";
            }
        }
    }
}
