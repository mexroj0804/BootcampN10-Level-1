using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1.Interfaces
{
    internal interface IPaymentProvider
    {
        public int TransferInterest { get; init; }
        public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount);

    }
}
