namespace ConsoleApp.Tag7.Todo.Data;

using ConsoleApp.Tag7.Todo.Domain;

public class TotoRepository
{
    public List<Todo> ListeTodos = [];

    public void Add(Todo todo)
    {
        if (todo.Id == 0)
        {
            var maxId = ListeTodos.Max(p => p.Id);
            todo.Id = maxId + 1;
        }
        if (ListeTodos.Any(p => p.Id == todo.Id))
        {
            throw new Exception("Todo mit gleicher Id bereits vorhanden");
        }
        ListeTodos.Add(todo);
    }
    public void Update(int id, Todo todo)
    {
        var index = ListeTodos.FindIndex(p => p.Id == id);
        if (index == -1)
        {
            throw new Exception("Todo nicht gefunden");
        }
        ListeTodos[index] = todo;
    }

    public void Delete(Todo todo)
    {
        ListeTodos.Remove(todo);
    }

    public void Delete(int id)
    {
        var todo = ListeTodos.FirstOrDefault(p => p.Id == id);
        if (todo == null)
        {
            throw new Exception("Todo nicht gefunden");
        }
        ListeTodos.Remove(todo);
    }
    public List<Todo> GetAll()
    {
        return ListeTodos;
    }
}
