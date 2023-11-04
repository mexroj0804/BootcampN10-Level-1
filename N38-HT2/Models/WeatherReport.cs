using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Models
{
    internal class WeatherReport
    {
        public string Location { get; set; }
        public DateOnly Date { get; set; }
        public float Temprature { get; set; }
        public float WindSpeed { get; set; }
        public float Humidity { get; set; }
        public WeatherReport(string location, DateOnly date, float temprature, float windSpeed, float humidity)
        {
            Location = location;
            Date = date;
            Temprature = temprature;
            WindSpeed = windSpeed;
            Humidity = humidity;
        }

    }
}
