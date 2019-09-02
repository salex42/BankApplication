using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public interface IAccount
    {

        // put money
        void Put (decimal sum);
        
        //get money
        decimal Withdraw(decimal sum);
    }
}
