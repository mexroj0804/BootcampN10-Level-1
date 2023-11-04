using N48_HT1.DataAccess;
using N48_HT1.Interfaces;
using N48_HT1.Models;
using System.Linq.Expressions;

namespace N48_HT1.Services
{
    public class OrderService : IOrderService
    {
        private readonly IDataContext _dataContext;
        public OrderService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async ValueTask<Order> CreateAsync(Order order, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            await _dataContext.Orders.AddAsync(order, cancellationToken);

            if (saveChanges)
                await _dataContext.Orders.SaveChangesAsync(cancellationToken);

            return order;
        }

        public async ValueTask<Order> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedOrder = await GetByIdAsync(id, cancellationToken);

            await _dataContext.Orders.RemoveAsync(deletedOrder, cancellationToken);

            if (saveChanges)
                await _dataContext.Orders.SaveChangesAsync(cancellationToken);

            return deletedOrder;
        }

        public async ValueTask<Order> DeleteAsync(Order order, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var deletedOrder = await GetByIdAsync(order.Id, cancellationToken);

            await _dataContext.Orders.RemoveAsync(deletedOrder, cancellationToken);

            if (saveChanges)
                await _dataContext.Orders.SaveChangesAsync(cancellationToken);

            return deletedOrder;
        }

        public IQueryable<Order> Get(Expression<Func<Order, bool>> predicate)
        {
            return _dataContext.Orders.Where(predicate.Compile()).AsQueryable();
        }

        public ValueTask<ICollection<Order>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
        {
            var result = _dataContext.Orders.Where(order => ids.Contains(order.Id));

            return new ValueTask<ICollection<Order>>(result.ToList());
        }

        public ValueTask<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var result = _dataContext.Orders.FirstOrDefault(order => order.Id == id);

            if (result == null)
                throw new Exception("Order not found!");

            return new ValueTask<Order>(result);
        }

        public async ValueTask<Order> UpdateAsync(Order order, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var updatedOrder = await GetByIdAsync(order.Id, cancellationToken);

            updatedOrder.UserId = order.UserId;
            updatedOrder.Amount = order.Amount;

            if (saveChanges)
                await _dataContext.Orders.SaveChangesAsync(cancellationToken);

            return updatedOrder;
        }
    }
}
