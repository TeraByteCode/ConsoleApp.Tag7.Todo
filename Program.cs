using ConsoleApp.Tag7.Todo.Application.Services;
using ConsoleApp.Tag7.Todo.Domain;

namespace ConsoleApp.Tag7.Todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen bei ToDo App");
            Console.WriteLine("Bitte geben Sie Ihre Benutzer (Id/Name) ein:");
            string benutzer = Console.ReadLine();

            //Der Variable service enthält ein Objekt von Typ TotoService
            var service = new TotoService(); //Hier wird ein Objekt von Typ TotoService instanziiert

            //Hier wird die Methode SetAktuellerBenutzer aufgerufen und der Benutzer übergeben
            service.SetAktuellerBenutzer(benutzer);


            while (true)
            {
                Console.WriteLine("Gib 1 ein um eine Todo hinzuzufügen, 2 zu suchen, 3 zu löschen oder 4 für..");
                var eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Console.WriteLine("Bitte geben Sie die Id der Kategorie ein:");
                    var id = Console.ReadLine();
                    var kategorie = service.GetKategorie(int.Parse(id));
                    if (kategorie == null)
                    {
                        Console.WriteLine($"Die eingegebene Kategorie mit der Id {id}  wurde nicht gefunden");
                        Console.WriteLine("Bitte wählen Sie eine andere Kategorie aus");
                        Console.WriteLine(service.PrintKategorie());
                    }
                    Console.WriteLine("Bitte geben Sie die Beschreibung der ToDo ein:");
                    var bezeichnung = Console.ReadLine();
                    var todo = new ToDo { Beschreibung = bezeichnung, Kategorie = kategorie };
                    Console.WriteLine(todo.ToString());

                    service.AddToDo(todo);

                    //service.AddKategorie(kategorie);
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Bitte geben Sie die Beschreibung der ToDo ein:");
                    var bezeichnung = Console.ReadLine();
                    var todo = new ToDo { Beschreibung = bezeichnung };
                    service.AddToDo(todo);
                }
                else if (eingabe == "3")
                {
                    Console.WriteLine("Bitte geben Sie die Beschreibung der ToDo ein:");
                    var bezeichnung = Console.ReadLine();
                    var todo = new ToDo { Beschreibung = bezeichnung };
                    //service.DeleteToDo(todo);
                }
                else if (eingabe == "4")
                {
                    Console.WriteLine("Bitte geben Sie die Beschreibung der ToDo ein:");
                    var bezeichnung = Console.ReadLine();
                    var todo = new ToDo { Beschreibung = bezeichnung };
                    //service.UpdateToDo(todo);
                }
                else
                {
                    break;
                }

            }

            Console.ReadLine();


        }
    }

}

