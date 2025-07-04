﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow!";
        }

        public override string Introduce()
        {
            return $"I am a cat named {Name} and I go {MakeSound()}";
        }
    }
}
