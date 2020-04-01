using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _092ProctectedClass
    {
        public class BankAccount
        {
            protected decimal _accountBalance = 0;

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

            Address GuarantorAddress;
        }

    }
}
