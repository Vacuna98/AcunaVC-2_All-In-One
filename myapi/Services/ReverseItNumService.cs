using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class ReverseItNumService
    {
            public string Reverse(string numbers)
            {
                if (!numbers.All(char.IsDigit))
                    return "Error: Numbers only.";

                var reversed = new string(numbers.Reverse().ToArray());
                return $"You entered {numbers}, reversed is {reversed}";
            }
        
    }








}