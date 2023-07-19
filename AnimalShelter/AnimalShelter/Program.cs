namespace AnimalShelter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter();

            // Enqueue some animals
            shelter.Enqueue(new Animal { Species = "dog", Name = "max" });
            shelter.Enqueue(new Animal { Species = "cat", Name = "joway" });
            shelter.Enqueue(new Animal { Species = "dog", Name = "dooge" });
            shelter.Enqueue(new Animal { Species = "cat", Name = "caty" });

            
            Animal dog = shelter.Dequeue("dog");
            if (dog != null)
            {
                Console.WriteLine($"Adopted a dog named {dog.Name}");
            }

            Animal cat = shelter.Dequeue("cat");
            if (cat != null)
            {
                Console.WriteLine($"Adopted a cat named {cat.Name}");
            }

            // Dequeue when  "any"
            Animal anyAnimal = shelter.Dequeue("any");
            if (anyAnimal != null)
            {
                Console.WriteLine($"Adopted an animal named {anyAnimal.Name}");
            }

            // Dequeue with a differnt animal
            Animal Animal = shelter.Dequeue("cow");
            if (Animal == null)
            {
                Console.WriteLine("Invalid Animal. No animal was adopted, only cats and dogs are here");
            }
        }
    }
}