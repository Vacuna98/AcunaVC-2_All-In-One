using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItNumController : ControllerBase
    {
        private readonly ReverseItNumService _service;

    public ReverseItNumController(ReverseItNumService service)
    {
        _service = service;
    }

    [HttpGet("Reverse")]
    public IActionResult Reverse(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
            return BadRequest("You need to enter a number.");

        var result = _service.Reverse(numbers);

        if (result.StartsWith("Error"))
            return BadRequest(result);

        return Ok(result);
    }

    }
}