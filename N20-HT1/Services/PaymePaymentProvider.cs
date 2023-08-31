using N20_HT1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1.Services
{
    internal class PaymePaymentProvider : IPaymentProvider
    {
        public int TransferInterest { get; init; } = 2;

        public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {
            var AmountWithTransferInterest = amount + (amount / 100 * TransferInterest);
            if (AmountWithTransferInterest > sourceCard.Balance) return false;
            sourceCard.Balance -= AmountWithTransferInterest;
            destinationCard.Balance += amount;

            return true;
        }
    }
}


