using Controllers;
using Repository;
using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main()
        {
            var repo = new DataRepository();
            var bookController = new BookController(repo);
            var userController = new UserController(repo);
            var loanController = new LoanController(repo);

            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Library Menu ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. List Available Books");
                Console.WriteLine("3. Add User");
                Console.WriteLine("4. List Users");
                Console.WriteLine("5. Lend Book");
                Console.WriteLine("6. Return Book");
                Console.WriteLine("7. List Loans");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: ");
                int.TryParse(Console.ReadLine(), out option);

                switch (option)
                {
                    case 1: bookController.AddBook(); break;
                    case 2: bookController.ListAvailableBooks(); break;
                    case 3: userController.AddUser(); break;
                    case 4: userController.ListUsers(); break;
                    case 5:
                        Console.Write("ISBN: ");
                        var lendIsbn = Console.ReadLine();
                        Console.Write("User Email: ");
                        var lendEmail = Console.ReadLine();
                        loanController.LendBook(lendIsbn, lendEmail);
                        break;
                    case 6:
                        Console.Write("ISBN: ");
                        var returnIsbn = Console.ReadLine();
                        loanController.ReturnBook(returnIsbn);
                        break;
                    case 7: loanController.ListLoans(); break;
                }

                if (option != 0)
                {
                    Console.WriteLine("Press ENTER to continue...");
                    Console.ReadLine();
                }

            } while (option != 0);

            repo.Save();
            Console.WriteLine("Data saved. ");
        }
    }
}
