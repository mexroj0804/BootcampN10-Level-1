using N48_HT1.Interfaces;
using N48_HT1.Models;

namespace N48_HT1.Services
{
    public class UserOrdersService : IUserOrderService
    {
        private readonly IOrderService _order;

        public UserOrdersService(IOrderService order)
        {
            _order = order;
        } 
        public IQueryable<Order> Get(Guid userId)
        {
            return _order.Get(order => order.UserId == userId);
        }
    }
}
