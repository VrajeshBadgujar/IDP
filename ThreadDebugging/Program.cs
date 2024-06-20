namespace ThreadDebugging
{
    internal class Program
    {  
        static int i = 0;
        static void Main(string[] args)
        {
            Thread one  = new Thread(MyMethod);
            one.Name = "One";
            one.Start();

            Thread two = new Thread(MyMethod);
            two.Name = "Two";
            two.Start();

        }

        static void MyMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(5000);
            }
        }
    }
}
