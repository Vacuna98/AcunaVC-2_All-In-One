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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _service;
        public MadLibController(MadLibService service)
    {
        _service = service;
    }

    [HttpGet("Create")]
    public IActionResult Create(string name, string place, string verb, string noun)
    {
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(place) ||
            string.IsNullOrWhiteSpace(verb) ||
            string.IsNullOrWhiteSpace(noun))
            return BadRequest("All must be field");

        return Ok(_service.Create(name, place, verb, noun));
    }
    }
}