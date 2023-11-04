using N53_HT1.Models;

namespace N53_HT1.Events;

public class OrderEventStore
{
    public event Func<Order, ValueTask>? OrderCreatedEvent;

    public async ValueTask CreateOrderAddedEventAsync(Order order)
    {
        if (OrderCreatedEvent != null)
            OrderCreatedEvent?.Invoke(order);
    }
}
