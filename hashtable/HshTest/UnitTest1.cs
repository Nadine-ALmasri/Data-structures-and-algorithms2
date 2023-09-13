using hashtable;
namespace HshTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestSetAndGet()
        {
            var hashMap = new HashMap(3);
            hashMap.Set("name", "Ahmad");
            Assert.Equal("Ahmad", hashMap.Get("name"));
        }

        [Fact]
        public void GetNullForNotExistentKey()
        {
            var hashMap = new HashMap(10);
            Assert.Null(hashMap.Get("age"));
        }

        [Fact]
        public void TestHas()
        {
            var hashMap = new HashMap(10);
            hashMap.Set("age", "18");
            Assert.True(hashMap.Has("age"));
            Assert.False(hashMap.Has("Major"));
        }

        [Fact]
        public void TestForCollisions()
        {
            var hashMap = new HashMap(10);
            // These keys will hash to the same bucket
            hashMap.Set("key1", "value1");
            hashMap.Set("k1y", "value2");
            Assert.Equal("value1", hashMap.Get("key1"));
            Assert.Equal("value2", hashMap.Get("k1y"));
        }

        [Fact]
        public void SuccessfullyHashesKeyToInRangeValue()
        {
            var hashMap = new HashMap(50); // Increase capacity for better testing
            string key = "testKey";
            int hash = hashMap.Hash(key);
            Assert.InRange(hash, 0, 49); // Assuming Capacity is 100.
        }
        [Fact]
        public void SuccessfullyRetrievesValueFromBucketWithCollision()
        {
            var hashMap = new HashMap(10);
            // These keys will hash to the same bucket
            hashMap.Set("book1", "value1");
            hashMap.Set("bo1ok", "value2");
            Assert.Equal("value2", hashMap.Get("bo1ok"));
        }
       
    }
    }
