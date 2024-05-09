using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_bank_account
{
    public class Account : IAccount
    {
        /* private IAccount _account;

         public Account(IAccount account)
         {
             _account = account;
         }
        */


        public IAccount account { get; set; }

        public void PrintDetails()
        {
            account.PrintDetails();
        }
    }
}
