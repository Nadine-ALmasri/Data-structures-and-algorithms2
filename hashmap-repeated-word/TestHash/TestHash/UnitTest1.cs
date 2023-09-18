using hashmap_repeated_word;
namespace TestHash
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        { }
            [Fact]
            public void NullInput()
            {
                string input = null;
                string result = RepeatedWord.FindFirstRepeatedWord(input);
                Assert.Null(result);
            }

            [Fact]
            public void NoRepeatedWord()
            {
                string input = "This is a good student.";
                string result = RepeatedWord.FindFirstRepeatedWord(input);
                Assert.Null(result);
            }

            [Fact]
            public void RepeatedWordExists()
            {
                string input = "This is  a good student with a smart brain";
                string result = RepeatedWord.FindFirstRepeatedWord(input);
                Assert.Equal("a", result);
            }
        }
    }
