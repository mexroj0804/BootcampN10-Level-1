using N50_HT1.Models;

namespace N50_HT1.Interfaces
{
    public interface IUserOrderService
    {
        public IQueryable<Order> GetUserOrdersByUserId(Guid userId);
    }
}
