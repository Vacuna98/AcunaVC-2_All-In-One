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
    public class ResturantPickerController : ControllerBase
    {
        private readonly ResturantPickerService _service;

        public ResturantPickerController (ResturantPickerService service)
        {
            _service = service;
        }

        [HttpGet("{category}")]
        public IActionResult Get(string category)
        {
            
            if (string.IsNullOrEmpty(category))
            return BadRequest ("Category is required");

            return Ok(_service.PickRestaurant(category));
        }

    }
}