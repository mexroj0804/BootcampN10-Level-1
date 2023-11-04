using Microsoft.AspNetCore.Mvc;
using N62_A_T1.DTOs;
using N62_A_T1.Services;

namespace N62_A_T1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }


    [HttpGet("userId:guid")]
    public IActionResult Get([FromRoute]Guid userId)
    {
        var result = _userService.Get(userId);

        return Ok(result);
    }

    [HttpPost]
    public IActionResult Create([FromBody]UserForCreation userForCreation)
    {
        var result = _userService.Create(userForCreation);
        return Ok(result);
    }
}
