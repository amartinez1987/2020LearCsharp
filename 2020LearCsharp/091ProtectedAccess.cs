using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _091ProtectedAccess
    {
        public class BankAccount
        {
            protected decimal _accountBalance = 0;

            public void PayInFunds(decimal amountToPayIn)
            {
                _accountBalance = _accountBalance + amountToPayIn;
            }

            public  virtual bool WithdrawFunds(decimal amountToWithdraw)
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

        public class OverdraftAccount : BankAccount
        {
            decimal overdraftLimit = 100;

            public override bool WithdrawFunds(decimal amountToWithdraw)
            {
                if (amountToWithdraw > _accountBalance + overdraftLimit)
                    return false;
                _accountBalance = _accountBalance - amountToWithdraw;
                return true;
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
