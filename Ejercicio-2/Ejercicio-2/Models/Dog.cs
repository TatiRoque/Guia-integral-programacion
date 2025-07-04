using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Woof!";
        }

        public override string Introduce()
        {
            return $"I am a dog named {Name} and I go {MakeSound()}";
        }
    }
}
