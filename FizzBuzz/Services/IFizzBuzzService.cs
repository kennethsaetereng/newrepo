using System.Collections.Generic;

namespace FizzBuzz.Services
{
    public interface IFizzBuzzService
    {
        List<string> GetFizzBuzz(int input);
    }
}
