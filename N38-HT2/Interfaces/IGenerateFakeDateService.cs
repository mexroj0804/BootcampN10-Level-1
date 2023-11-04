using Bogus;
using N38_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Interfaces
{
    internal interface IGenerateFakeDateService
    {
        List<BlogPost> GenerateFakeBlogpost(int count = 1);
        List<Employee> GenerateFakeEmployee(int count = 1);
        List<Order> GenerateFakeOrder(int count = 1);
        List<UserAddress> GenerateFakeUserAddress(int count = 1);
        List<WeatherReport> GenerateFakeWeatherReport(int count = 1);
    }
}
