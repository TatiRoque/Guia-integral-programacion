using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual string MakeSound()
        {
            return "The animal makes a sound.";
        }

        public virtual string Introduce()
        {
            return $"I am an animal named {Name} and I go {MakeSound()}";
        }
    }
}
