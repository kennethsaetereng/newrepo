using System.Collections.Generic;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> GetFizzBuzz(int input)
        {
            List<string> output = new List<string>();

            for (int i = 1; i <= input; i++)
            {
                output.Add(GetValue(i));
            }

            return output;
        }

        string GetValue(int input)
        {
            string output = string.Empty;

            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();

            return output;
        }
    }
}
