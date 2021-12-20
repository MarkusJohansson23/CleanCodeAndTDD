﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeAndTDD
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        { 
            if (numbers == "")
            {
                return 0;
            }
            else if (numbers.Contains(','))
            {
                var stringArray = numbers.Split(",");
                return stringArray.Select(str => int.Parse(str)).Sum();
            }
            else
            {
                return int.Parse(numbers);
            }
        }
    }
}
