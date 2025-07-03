using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    public static class CitizenView
    {
        public static void Greet(Citizen citizen)
        {
            Console.WriteLine($"Hi! My name is {citizen.name} and I am {citizen.age} years old.");
        }

        public static void ShowLegalAgeStatus(Citizen citizen)
        {
            if (citizen.IsOfLegalAge())
            {
                Console.WriteLine($"{citizen.name} is of legal age.");
            }
            else
            {
                Console.WriteLine($"{citizen.name} is NOT of legal age.");
            }
        }
        public static Citizen AddCitizen()
        {
            int age;

            Console.WriteLine("Welcome. What's your name?");
            string name = Console.ReadLine();
            do
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
            } while (age < 0);

            Console.WriteLine("What's your ID");
            string id = Console.ReadLine();

            return new Citizen(name, id, age);
        }

    }
}
