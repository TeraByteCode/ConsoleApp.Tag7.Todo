using ConsoleApp.Tag7.Todo.Domain;

namespace ConsoleApp.Tag7.Todo.Data;

public class PersonenRepository
{
    public List<Person> ListePersonen = [];

    public void Add(Person person)
    {
        if (person.Id == 0)
        {
            var maxId = ListePersonen.Max(p => p.Id);
            person.Id = maxId + 1;
        }

        ListePersonen.Add(person);
    }
    public void Update(int id, Person person)
    {
        var index = ListePersonen.FindIndex(p => p.Id == id);
        if (index == -1)
        {
            throw new Exception("Person nicht gefunden");
        }
        ListePersonen[index] = person;
    }
    public void Delete(Person person)
    {
        var p = ListePersonen.FirstOrDefault(p => p.Id == person.Id);
        if (p == null)
        {
            throw new Exception("Person nicht gefunden");
        }
        ListePersonen.Remove(person);
    }

    public void Delete(int id)
    {
        var person = ListePersonen.FirstOrDefault(p => p.Id == id);
        if (person == null)
        {
            throw new Exception("Person nicht gefunden");
        }
        ListePersonen.Remove(person);
    }

    public List<Person> GetAll()
    {
        return ListePersonen;
    }
}
