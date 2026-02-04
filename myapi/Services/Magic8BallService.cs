using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class Magic8BallService
    {
        private static readonly List<string> Responses = new()
        {
            "Yes",
            "No",
            "Try Again",
            "I Guess",
            "Ask Me Later",
            "Definitely No",
            "Maybe",
            "Sure"
        };

        private readonly Random _random = new();

        public string GetResponse()
        {
            int index = _random.Next(Responses.Count);
            return Responses[index];
        }
    }
}