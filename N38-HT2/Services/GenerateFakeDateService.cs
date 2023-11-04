using N38_HT2.Interfaces;
using N38_HT2.Models;
using Bogus;

namespace N38_HT2.Services
{
    internal class GenerateFakeDateService : IGenerateFakeDateService
    {
        public List<BlogPost> GenerateFakeBlogpost(int count = 1)
        {
            return new Faker<BlogPost>()
                .RuleFor(post => post.Id, Guid.NewGuid)
                .RuleFor(post => post.Title, source => source.Lorem.Text())
                .RuleFor(post => post.Content, source => source.Lorem.Text())
                .RuleFor(post => post.CreatedAt, source => source.Date.PastDateOnly())
                .RuleFor(post => post.UpdatedAt, source => source.Date.FutureDateOnly())
                .RuleFor(post => post.ReadTime, source => source.Random.Int(0, 200))
                .Generate(count);       
        }

        public List<Employee> GenerateFakeEmployee(int count = 1)
        {
            return new Faker<Employee>()
                .RuleFor(emp => emp.Id, s => s.Random.Int(0, 200))
                .RuleFor(emp => emp.FirstName, s => s.Name.FirstName())
                .RuleFor(emp => emp.LastName, s => s.Name.LastName())
                .RuleFor(emp => emp.Age, s => s.Random.Int(18, 50))
                .RuleFor(emp => emp.EmailAddress, s => s.Random.String())
                .RuleFor(emp => emp.Department, s => s.Company.CompanyName())
                .RuleFor(emp => emp.Salary, s => s.Random.Decimal(0, 1000))
                .Generate(count);
        }

        public List<Order> GenerateFakeOrder(int count = 1)
        {
            throw new NotImplementedException();
        }

        public List<UserAddress> GenerateFakeUserAddress(int count = 1)
        {
            throw new NotImplementedException();
        }

        public List<WeatherReport> GenerateFakeWeatherReport(int count = 1)
        {
            throw new NotImplementedException();
        }
    }
}
