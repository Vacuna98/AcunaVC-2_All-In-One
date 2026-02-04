using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapi.Controllers;

namespace myapi.Services
{
    public class AddingTwoNumbersService
    {
         public string GetSum (int num1, int num2)
        {
            int sum = num1 + num1;
            return $"The sum is {sum}";
        }
    }
}