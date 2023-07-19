using AnimalShelter;

namespace animalShulterTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void Enqueue_Animals()
        {
            // Arrange
            animalShelter shelter = new animalShelter();
            Animal dog = new Animal { Species = "dog", Name = "MAX" };
            Animal cat = new Animal { Species = "cat", Name = "Ketty" };

            // Act
            shelter.Enqueue(dog);
            shelter.Enqueue(cat);

            // Assert
            Assert.Equal(dog, shelter.Dequeue("dog"));
            Assert.Equal(cat, shelter.Dequeue("cat"));
        }
        [Fact]
        public void EnqueueInvalidSpecies()
        {
            // Arrange
            animalShelter shelter = new animalShelter();
            Animal cow = new Animal { Species = "cow", Name = "ffff" };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => shelter.Enqueue(cow));
        }
        [Fact]
        public void DequeueOldestAnimalWithAny()
        {
            // Arrange
            animalShelter shelter = new animalShelter();
            Animal dog1 = new Animal { Species = "dog", Name = "" };
            Animal cat1 = new Animal { Species = "cat", Name = "" };
            Animal dog2 = new Animal { Species = "dog", Name = "" };
            Animal cat2 = new Animal { Species = "cat", Name = "" };

            shelter.Enqueue(dog1);
            shelter.Enqueue(cat1);
            shelter.Enqueue(dog2);
            shelter.Enqueue(cat2);

            // Act
            Animal oldestAnimal = shelter.Dequeue("any");

            // Assert
            Assert.Equal(dog1, oldestAnimal);
        }
        [Fact]
        public void DequeueWhenShelterIsEmpty()
        {
            // Arrange
            animalShelter shelter = new animalShelter();

            // Act & Assert
            Assert.Null(shelter.Dequeue("dog"));
            Assert.Null(shelter.Dequeue("cat"));
            Assert.Null(shelter.Dequeue("any"));
        }

    }
}