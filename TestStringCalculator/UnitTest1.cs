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
        [Fact]
        public void Should_Return_Sum_Of_Two_Numbers()
        {
            var result = StringCalculator.Add("1,2");
            Assert.Equal(3, result);
        }
        [Fact]
        public void Should_Return_Sum_Of_Multiple_Numbers()
        {
            var result = StringCalculator.Add("1,2,6,22");
            Assert.Equal(31, result);
        }
        [Fact]
        public void Add_method_should_be_able_to_handle_new_line()
        {
            var result = StringCalculator.Add("1\n2,3");
            Assert.Equal(6, result);
        }
        [Fact]
        public void Add_method_should_support_delimiter_declaration()
        {
            var result = StringCalculator.Add("//;\n2;3");
            Assert.Equal(5, result);
        }
        [Fact]
        public void Add_method_should_support_another_delimiter_declaration()
        {
            var result = StringCalculator.Add("//T\n2T3");
            Assert.Equal(5, result);
        }

    }
}