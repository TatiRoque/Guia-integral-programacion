using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Model
{
    public class Citizen
    {
        public string name;
        public string ID;
        public int age;


        public Citizen() { }
        public Citizen(string name, string ID,int age)
        {
            this.name = name;
            this.age = age;
            this.ID = ID;

        }
        public bool IsOfLegalAge()
        {
            return age >= 18;
        }
    }
}
