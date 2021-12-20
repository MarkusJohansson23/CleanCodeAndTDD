using System;
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
            else if (HasDelimiter(numbers))
            {
                string[] stringArray;
                if (HasDelimiterDeclaration(numbers))
                {
                    char delimiter = numbers.Skip(2).Take(1).First();
                    stringArray = FindStringArray(numbers, delimiter);
                    return SumOfNumbers(stringArray);
                }

                var separators = new string[] { ",", "\n" };
                stringArray = numbers.Split(separators, StringSplitOptions.None);
                return SumOfNumbers(stringArray);
            }
            else
            {
                return int.Parse(numbers);
            }
        }

        private static int SumOfNumbers(string[] stringArray)
        {
            var numberArray = stringArray.Select(str => int.Parse(str));
            if (HasNegatives(numberArray))
            {
                throw new ArgumentException($"Negatives not allowed {ListNegatives(numberArray)}");
            }
            if (HasNumbersGreaterThan1000(numberArray))
            {
                numberArray = numberArray.Where(n => n <= 1000);
            }
            return numberArray.Sum();
        }

        private static bool HasNumbersGreaterThan1000(IEnumerable<int> numberArray)
        {
            return numberArray.Any(num => num > 1000);
        }

        private static string ListNegatives(IEnumerable<int> numberArray)
        {
            return string.Join(", ", numberArray.Where(n => n < 0));
        }

        private static bool HasNegatives(IEnumerable<int> numberArray)
        {
            return numberArray.Any(num => num < 0);
        }

        private static string[] FindStringArray(string numbers, char delimiter)
        {
            string[] stringArray;
            string? cleanedString = numbers.Substring(3);
            stringArray = cleanedString.Split(delimiter);
            return stringArray;
        }

        private static bool HasDelimiterDeclaration(string numbers)
        {
            return numbers.Contains("//") && numbers.Contains("\n");
        }

        private static bool HasDelimiter(string numbers)
        {
            return numbers.Contains(',') || numbers.Contains('\n');
        }
    }
}
