using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class OddorEvenService
    {
       public string Check(int number)
        {
            return number % 2 == 0 ? $"{number} is Even" : $"{number} is Odd";
        } 
    }
}