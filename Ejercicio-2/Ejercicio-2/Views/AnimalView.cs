using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class AnimalView
    {
        public void ShowAnimals(List<Animal> animals)
        {
            Console.WriteLine("Animal Introductions:\n");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Introduce());
            }
        }
    }
}
