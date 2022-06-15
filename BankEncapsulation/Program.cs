using System;

namespace BankEncapsulation
{
    class Program
    { 

        static void Main(string[] arg)
        {
            BankAccount account = new BankAccount();

            account.Deposit(800.00);
            Console.WriteLine(account.GetBalance());

        }
        
    }
}


