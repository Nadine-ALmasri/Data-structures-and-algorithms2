using stack_queue_brackets;

namespace TestBrackets
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Theory]
     
        [InlineData("()[[Extra Characters]]", true)]
        [InlineData("(){}[[]]", true)]
        [InlineData("{}{Code}[Fellows](())", true)]
        [InlineData("[({}]", false)]
        [InlineData("(]", false)]
        [InlineData("{(})", false)]  
        [InlineData("{}", true)]
        [InlineData("{}(){}", true)]
        [InlineData("", true)]
        public void ValidateBrackets_ShouldReturnCorrectResult(string input, bool expected)
        {
            // Arrange

            // Act
            bool actual = StackQueueBrackets.ValidateBrackets(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}