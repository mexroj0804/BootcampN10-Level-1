using Microsoft.AspNetCore.Mvc;
using N50_HT1.Interfaces;
using N50_HT1.Models;

namespace N50_HT1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IUserOrderService _usesrOrderService;

    public UserController(IUserService userService, IUserOrderService usesrOrderService)
    {
        _userService = userService;
        _usesrOrderService = usesrOrderService;
    }

    [HttpGet]
    public IActionResult GetAllUser([FromQuery] int pageToken, int pageSize)
    {
        var result = _userService.Get(user => true).Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();

        return result.Any() ? Ok(result) : NotFound();
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateUser([FromBody] User user)
    {
        var result = await _userService.CreateAsync(user);

        return Ok(result);
        //return CreatedAtAction(nameof(result), new { userId = result.Id }, result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateUser([FromBody] User user)
    {
        var result = await _userService.UpdateAsync(user);

        return NoContent();
    }

    [HttpGet("{id}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await _userService.GetByIdAsync(id);

        return result is not null ? Ok(result) : NotFound();
    }

    [HttpGet("{userId:Guid}/orders")]
    public IActionResult GetOrdersById([FromRoute] Guid userId)
    {
        var result = _usesrOrderService.GetUserOrdersByUserId(userId);

        return result.Any() ? Ok(result) : NotFound();
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteUser([FromBody] User user)
    {
        var result = await _userService.DeleteAsync(user);

        return NoContent();
    }

    [HttpDelete("{id:Guid}")]
    public async ValueTask<IActionResult> DeleteUserById([FromRoute] Guid id)
    {
        var result = await _userService.DeleteAsync(id);

        return NoContent();
    }
}