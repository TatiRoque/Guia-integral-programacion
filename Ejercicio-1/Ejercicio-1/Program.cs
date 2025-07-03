using System;
using System.Collections.Generic;
using System.Drawing;
using Controller;
using Model;

class Program
{
    static void Main()
    {
        var controller = new CitizenController();
        Citizen citizen = null; //since this is a practice only one citizen can be added at a time.In the future a List can be added.
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Load a new citizen");
            Console.WriteLine("2. Greet the citizen");
            Console.WriteLine("3. Is the citizen of legal age?");
            Console.WriteLine("0. Exit");

            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        citizen = controller.AddNewCitizen(); 
                        Console.WriteLine("Citizen added successfully.");
                        Console.ReadKey();
                        break;

                    case 2:
                        if (citizen != null)
                        {
                            controller.Greetting(citizen);
                        }
                        else
                        {
                            Console.WriteLine("No citizen loaded yet.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        if (citizen != null)
                        {
                            controller.ShowLegalAge(citizen);
                        }
                        else
                        {
                            Console.WriteLine("No citizen loaded yet.");
                        }
                        Console.ReadKey();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}. Press any key to return.");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }
}
