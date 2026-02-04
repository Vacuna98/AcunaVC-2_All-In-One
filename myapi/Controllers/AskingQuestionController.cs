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
    public class AskingQuestionController : ControllerBase
    {
        private readonly AskingQuestionService _service;

        public AskingQuestionController(AskingQuestionService service)
        {
            _service = service;
        } 

        [HttpGet("WakeUp/{name}/{time}")]
        public string WakeUpInfo(string name, string time)
        {
            return _service.GetWakeUpInfo(name, time);
        }
    
    }
}