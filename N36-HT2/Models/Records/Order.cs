using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models.Records
{
    internal record Order(Guid Id, string Customer, string Item);
}
