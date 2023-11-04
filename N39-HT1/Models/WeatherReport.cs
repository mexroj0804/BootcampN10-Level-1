using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N39_HT1.Models
{
    internal class WeatherReport
    {
        public string State { get; set; }
        public double Degree { get; set; }
        public WeatherReport(string state, double degree)
        {
            State = state;
            Degree = degree;
        }

        public override string ToString()
        {
            return $"Country: {State}   Degree: {Degree}";
        }
    }
}
