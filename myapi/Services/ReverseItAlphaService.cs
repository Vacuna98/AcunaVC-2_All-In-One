using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class ReverseItAlphaService
    {
        public string Reverse(string word)
        {
            return new string(word.Reverse().ToArray());
        }
    
    }
}