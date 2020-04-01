using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _090AccessorMethods
    {
        class BankAccount
        {
            private decimal _accountBalance = 0;

            public void PayInFunds(decimal amountToPayIn)
            {
                _accountBalance = _accountBalance + amountToPayIn;
            }

            public bool WithdrawFunds(decimal amountToWithdraw)
            {
                if (amountToWithdraw > _accountBalance)
                    return false;
                _accountBalance = _accountBalance - amountToWithdraw;
                return true;
            }

            public decimal GetBalance()
            {
                return _accountBalance;
                
            }
        }

        public static void executeTest()
        {
            BankAccount a = new BankAccount();
            a.PayInFunds(50);
            Console.WriteLine($"Pay Funds {a.GetBalance()}");
            a.PayInFunds(50);
            if (a.WithdrawFunds(10))
                Console.WriteLine("Withdraw 10");
            Console.WriteLine($"Balance {a.GetBalance()}");
            Console.ReadKey();

               
        }
    }

}
