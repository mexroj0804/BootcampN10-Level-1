using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT1
{
    internal class PrimeNumbers
    {
        public void Main(List<int> sonlar)
        {
            sonlar.Where(item => IsPrime(item)).ToList().OrderDescending().ToList().ForEach(Console.WriteLine);

        }



        static bool IsPrime(int number)
        {
            for (var i = 2; i < Math.Sqrt(number) + 1; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
