using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AnimalController
    {
        public List<Animal> GetAnimals()
        {
            var dog = new Dog { Name = "Juan" };
            var cat = new Cat { Name = "Lola" };

            return new List<Animal> { dog, cat };
        }
    }

}
