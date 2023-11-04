﻿using Microsoft.AspNetCore.Mvc;
using N53_HT1.Interfaces;
using N53_HT1.Models;

namespace N53_HT1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = _orderService.Get(x => true);
        return result.Any() ? Ok(result) : NotFound();
    }

    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        var result = _orderService.CreateAsync(order);
        return Ok(result);
    }
}
