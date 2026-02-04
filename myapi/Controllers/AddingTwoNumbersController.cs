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
    public class AddingTwoNumbersController : ControllerBase
    {
        private readonly AddingTwoNumbersService _service;

        public AddingTwoNumbersController(AddingTwoNumbersService service)
        {
            _service = service;
        }

        [HttpGet("{num1}/{num2}")]
        public string AddNumbers(int num1, int num2)
        {
            return _service.GetSum(num1, num2);
        }
    }
}