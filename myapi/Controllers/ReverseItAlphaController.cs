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
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaService _service;

        public ReverseItAlphaController(ReverseItAlphaService service)
        {
            _service = service;
        }

        [HttpGet("{word}")]
        public string ReverseItService (string word)
        {
            return _service.Reverse(word); 
        }
        
    }
}