using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_bank_account
{
    public class CuurentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("print details of Cuurent Account");
        }
    }
}
