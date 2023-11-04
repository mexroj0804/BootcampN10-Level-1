using Microsoft.AspNetCore.Mvc;
using N48_HT1.Interfaces;
using N48_HT1.Models;

namespace N48_HT1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetAllOrders([FromQuery] int pageToken, int pageSize)
    {
        var result = _orderService.Get(order => true).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();

        return result.Any() ? Ok(result) : NotFound();
    }

    [HttpGet("{id:Guid}")]
    public async ValueTask<IActionResult> GetOrderById([FromRoute] Guid id)
    {
        var result = await _orderService.GetByIdAsync(id);

        return result is not null ? Ok(result) : NotFound();
    }

    [HttpPost("order")]
    public async ValueTask<IActionResult> CreateOrder ([FromBody]Order order)
    {
        var result = await _orderService.CreateAsync(order);

        return CreatedAtAction(nameof(result), new { userId = result.Id }, result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateOrder([FromBody] Order order)
    {
        await _orderService.UpdateAsync(order);

        return NoContent();
    }

    [HttpDelete("order")]
    public async ValueTask<IActionResult> DeleteOrder([FromBody] Order order)
    {
        await _orderService.DeleteAsync(order);
        
        return NoContent();
    }

    [HttpDelete("{id:Guid}")]
    public async ValueTask<IActionResult> DeleteOrderById([FromRoute] Guid id)
    {
        var result = await _orderService.DeleteAsync(id);

        return result is not null ? Ok(result) : NotFound();
    }
}
