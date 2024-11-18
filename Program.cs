using ConsoleApp.Tag7.Todo.Application.Services;

namespace ConsoleApp.Tag7.Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei ToDo App");
            Console.WriteLine("Bitte geben Sie Ihre Benutzer (Id/Name) ein:");
            string benutzer = Console.ReadLine();

            var service = new TotoService();
            service.SetAktuellerBenutzer(benutzer);

            Console.WriteLine("Um eine Todo hinzuzufügen 1, zu suchen 2, zu löschen 3, und ...");

            Console.ReadLine();


        }
    }

}

