﻿
namespace BankEncapsulation
{
	public class BankAccount
	{
        private double balance = 0;

        
		public double GetBalance()
        {
			return balance;
        }
		public void Deposit(double amount)
		{
			balance += amount;
		}

		public void Withdraw(double amount)
		{
			balance -= amount;

		}

	}
}

