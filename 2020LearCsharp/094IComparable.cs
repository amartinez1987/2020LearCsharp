using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _094IComparable
    {
        public class BankAccount : IComparable, IAccount
        {
             decimal _accountBalance = 0;

            public BankAccount(int balance )
            {
                this._accountBalance = balance;
            }

            public int CompareTo(object obj)
            {
                if (obj == null)
                    return 1;

                IAccount a = obj as IAccount;

                if (a == null)
                {
                    throw new ArgumentException("Object not is IAccount");
                }

                return this._accountBalance.CompareTo(a.GetBalance());
            }


            public void PayInFunds(decimal amountToPayIn)
            {
                _accountBalance = _accountBalance + amountToPayIn;
            }

            public virtual bool WithdrawFunds(decimal amountToWithdraw)
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


            protected class Address
            {
                public string FirstLine;
                public string PostCode;
            }
        }

        internal interface IAccount
        {
             void PayInFunds(decimal amountToPayIn);

              bool WithdrawFunds(decimal amountToWithdraw);

             decimal GetBalance();
        }


        public static void executeTest()
        {
            List<IAccount> accounts = new List<IAccount>();
            Random rand = new Random(1);
            for (int i = 0; i < 20; i++)
            {
                IAccount account = new BankAccount(rand.Next(0,1000));
                accounts.Add(account);
            }

            accounts.Sort();

            accounts.ForEach(ac => Console.WriteLine($"Balance order : {ac.GetBalance()}")) ;
            Console.ReadKey();
            Console.WriteLine("");

            foreach (IAccount item in accounts)
            {
                Console.WriteLine($"Balance order : {item.GetBalance()}");
            }
            Console.ReadKey();
        }
    }
}