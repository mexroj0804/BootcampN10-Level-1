using N48_HT1.Models;

namespace N48_HT1.Interfaces
{
    public interface IUserOrderService
    {
        public IQueryable<Order> Get(Guid userId);
    }
}
