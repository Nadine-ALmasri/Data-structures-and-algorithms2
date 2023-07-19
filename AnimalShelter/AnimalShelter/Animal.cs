using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }

        public Animal()
        {
            Timestamp = DateTime.Now;
        }
    }
}
