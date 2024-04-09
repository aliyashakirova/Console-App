using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class CreditCard
    {


        private long _accNumber;
        private double _remBalance;

        public long AccNumber
        { 
            get { return _accNumber; } 
            set { _accNumber = value; }
        }

        public double RemainingBalance
        {
            get { return _remBalance; }
            set { _remBalance = value; }
        }

        public CreditCard()
        {
        }
        public CreditCard(long _accNumber, double _remBalance)
        {
            AccNumber = _accNumber;
            RemainingBalance = _remBalance;
        }

        public void LoadMoney(CreditCard creditCard, double money)
        {
            creditCard.RemainingBalance += money;
        }


        public void WithdrawMoney(CreditCard creditCard, double money)
        {
            creditCard.RemainingBalance -= money;
        }
        public double GetCurrentBalance(CreditCard creditCard)
        {
            return creditCard.RemainingBalance;
        }

    }
}
