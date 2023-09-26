using Microsoft.VisualStudio.TestPlatform.TestHost;
using hashmap_left_join;
namespace TestLefJoin
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void LeftJoinNormalData()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            {"Ahmad", "23"},
            {"saad", "33"},
            {"reta", "15"}
        };

            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            {"Ahmad", "doctor"},
            {"saad", "teacher"}
        };

            // Act
            List<List<string>> result = LeftJoinHash.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(new List<string> { "Ahmad", "23", "doctor" }, result[0]);
            Assert.Equal(new List<string> { "saad", "33", "teacher" }, result[1]);
            Assert.Equal(new List<string> { "reta", "15", null }, result[2]);
        }

        [Fact]
        public void LeftJoinAntonymsDictionaryIsEmpty()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>
        { {"Ahmad", "23"},
            {"saad", "33"},
            {"reta", "15"}
        };

            Dictionary<string, string> antonyms = new Dictionary<string, string>();

            // Act
            List<List<string>> result = LeftJoinHash.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(new List<string> { "Ahmad", "23", null }, result[0]);
            Assert.Equal(new List<string> { "saad", "33", null }, result[1]);
            Assert.Equal(new List<string> { "reta", "15", null }, result[2]);
        }

        [Fact]
        public void LeftJoinSynonymsDictionaryIsEmpty()
        {
            // Arrange
            Dictionary<string, string> synonyms = new Dictionary<string, string>();

            Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            {"happy", "unhappy"},
            {"sad", "joyful"},
            {"funny", "serious"}
        };

            // Act
            List<List<string>> result = LeftJoinHash.LeftJoin(synonyms, antonyms);

            // Assert
            Assert.Empty(result);
        }
    }
}