using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class MadLibService
    {
        public string Create(string name, string place, string verb, string noun)
        {
            return $"{name} went to {place} and {verb} a {noun}. It was a crazy day!";
        }
    }
}