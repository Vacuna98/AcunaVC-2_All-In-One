using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class AskingQuestionService
    {
         public string GetWakeUpInfo(string name, string time)
        {
            return $"My name is {name} and I woke up at {time}.";
        }
    }
}