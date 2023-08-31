using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1.Interfaces
{
    internal interface IDebitCard
    {
        public double CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }
    }
}
