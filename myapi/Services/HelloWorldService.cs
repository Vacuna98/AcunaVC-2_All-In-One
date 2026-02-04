using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class HelloWorldService
    {
         public string Greet(string name)
        {
            return $"Hello, {name}";
        } 
    }
}