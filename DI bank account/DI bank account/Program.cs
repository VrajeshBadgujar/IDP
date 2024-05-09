using DI_bank_account;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
       /* IAccount sa = new SavingAccount();
        Account a = new Account(sa);
        a.printAccount();

        IAccount ca = new CuurentAccount();
        Account b = new Account(ca);
        b.printAccount();

        Console.ReadLine();
        */


        Account sa = new Account();
        sa.account = new SavingAccount();


        sa.PrintDetails();

        IAccount ca = new CuurentAccount();
        ca.PrintDetails();





        Console.ReadLine();
    }
}
