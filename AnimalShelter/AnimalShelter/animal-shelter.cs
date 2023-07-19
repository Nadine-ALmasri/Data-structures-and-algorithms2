using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class animalShelter
    {
        public Queue<Animal> dogs;
        public Queue<Animal> cats;

        public animalShelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
        }

        public void Enqueue(Animal animal)
        {
            if (animal.Species== "dog")
            {
                dogs.Enqueue(animal);
            }
            else if (animal.Species == "cat")
            {
                cats.Enqueue(animal);
            }
            else
            {
                throw new ArgumentException("Only 'dog' or 'cat' are allowed.");
            }
        }

        public Animal Dequeue(string delete)
        {
            if (delete == "dog")
            {
                if (dogs.Count > 0)
                {
                    return dogs.Dequeue();
                }
            }
            else if (delete == "cat")
            {
                if (cats.Count > 0)
                {
                    return cats.Dequeue();
                }
            }
            else if (delete == "any")
            {
                if (dogs.Count > 0 && cats.Count > 0)
                {
                    // Compare the timestamps of the oldest dog and cat
                    DateTime oldestDogTime = dogs.Peek().Timestamp;
                    DateTime oldestCatTime = cats.Peek().Timestamp;
                    if (oldestDogTime <= oldestCatTime)
                    {
                        return dogs.Dequeue();
                    }
                    else
                    {
                        return cats.Dequeue();
                    }
                }
                else if (dogs.Count > 0)
                {
                    return dogs.Dequeue();
                }
                else if (cats.Count > 0)
                {
                    return cats.Dequeue();
                }
            }

            return null;
        }
    }
}
