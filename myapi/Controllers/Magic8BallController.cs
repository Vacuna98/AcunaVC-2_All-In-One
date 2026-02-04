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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _service;

        public Magic8BallController (Magic8BallService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _service.GetResponse();
            return Ok(new { response });
        }
    }
}