using Controllers;
using Views;

class Program
{
    static void Main(string[] args)
    {
        var controller = new AnimalController();
        var view = new AnimalView();

        var animals = controller.GetAnimals();
        view.ShowAnimals(animals);

        Console.ReadKey();
    }
}