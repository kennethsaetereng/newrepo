using System.Linq;
using FizzBuzz.Services;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        readonly IFizzBuzzService _fizzBuzzService = new FizzBuzzService();

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(19)]
        public void FizzBuzzService_Given_Number_Return_Last_As_String(int input)
        {
            string output = _fizzBuzzService.GetFizzBuzz(input).Last();
            Assert.Equal(input.ToString(), output);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(18)]
        public void FizzBuzzService_Give_NumberDivThree_Last_ReturnsAsFizz(int input)
        {
            string output = _fizzBuzzService.GetFizzBuzz(input).Last();
            Assert.Equal("Fizz", output);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void FizzBuzzService_Given_NumberDivFive_Last_ReturnsAsBuzz(int input)
        {
            string output = _fizzBuzzService.GetFizzBuzz(input).Last();
            Assert.Equal("Buzz", output);
        }

        [Theory]
        [InlineData(15)]
        public void FizzBuzzService_Given_NumberDivThreeAndFive_Last_ReturnsAsFizzBuzz(int input)
        {
            string output = _fizzBuzzService.GetFizzBuzz(input).Last();
            Assert.Equal("FizzBuzz", output);
        }
    }
}
