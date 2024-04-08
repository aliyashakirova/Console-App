using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class CreditCard
    {

        public CreditCard(long accNumber, double remBalance)
        {
            AccNumber = accNumber;
            RemainingBalance = remBalance;
        }

        public CreditCard()
        {
        }

        public long AccNumber { get; set; }
        public double RemainingBalance { get; set; }

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
