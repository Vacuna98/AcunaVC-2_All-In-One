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
    public class OddorEvenController : ControllerBase
    {
        private readonly OddorEvenService _service;

    public OddorEvenController(OddorEvenService service)
    {
        _service = service;
    }

    [HttpGet("Check")]
    public IActionResult Check(int number)
    {
        return Ok(_service.Check(number));
    }
    }
}