using CleanCodeAndTDD;
using Xunit;

namespace TestStringCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Return_Zero_If_Input_Is_Empty()
        {
            var result = StringCalculator.Add("");
            Assert.Equal(0, result);
        }
        [Fact]
        public void Should_Return_One_If_Input_Is_One()
        {
            var result = StringCalculator.Add("1");
            Assert.Equal(1, result);
        }
    }
}