using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    public readonly IUserService _service;

    public UserController(IUserService service)
    {
        this._service = service;
    }

    // 6 - Sua aplicação deve ter o endpoint GET /user/:email
    [HttpGet("{email}", Name = "GetUser")]
    public IActionResult Get(string email)
    {
        if (_service.GetUser(email) == null)
        {
            return NotFound();
        }
        return Ok(_service.GetUser(email));
    }

    // 7 - Sua aplicação deve ter o endpoint POST /user
    [HttpPost]
    public IActionResult Create([FromBody] User user)
    {
        _service.AddUser(user);

        return StatusCode(201, user);
    }

    // "8 - Sua aplicação deve ter o endpoint PUT /user
    [HttpPut("{email}")]
    public IActionResult Update(string email, [FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest();
        }
        var findUser = _service.UserExists(email);
        if (!findUser)
        {
            return NotFound();
        }
        if (user.Email != email)
        {
            return BadRequest();
        }
        _service.UpdateUser(user);

        return StatusCode(200, user);

    }

    // 9 - Sua aplicação deve ter o endpoint DEL /user
    [HttpDelete("{email}")]
    public IActionResult Delete(string email)
    {
        if (!_service.UserExists(email))
        {
            return NotFound();
        }
        _service.DeleteUser(email);
        return NoContent();
    }
}