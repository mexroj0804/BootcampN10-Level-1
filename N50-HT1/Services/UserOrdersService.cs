using N50_HT1.Interfaces;
using N50_HT1.Models;

namespace N50_HT1.Services
{
    public class UserOrdersService : IUserOrderService
    {
        private readonly IOrderService _order;

        public UserOrdersService(IOrderService order)
        {
            _order = order;
        }
        public IQueryable<Order> GetUserOrdersByUserId(Guid userId)
        {
            return _order.Get(order => order.UserId == userId);
        }
    }
}
