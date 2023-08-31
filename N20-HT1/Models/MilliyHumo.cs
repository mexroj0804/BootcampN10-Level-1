using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N20_HT1.Interfaces;

namespace N20_HT1.Models
{
    internal class MilliyHumo : IDebitCard
    {
        public double CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }

        public MilliyHumo(double cardNumber, string bankName, double balance)
        {
            CardNumber = cardNumber;
            BankName = bankName;
            Balance = balance;
        }
    }
}
