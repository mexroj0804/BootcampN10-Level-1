using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Models
{
    internal class DebitCard
    {
        public double CardNumber { get; set; }
        public double Balance { get; set; }
        public DebitCard(double cardNumber, double balance)
        {
            CardNumber = cardNumber;
            Balance = balance;
        }
    }
}
