using ConsoleApp.Tag7.Todo.Domain.Enums;

namespace ConsoleApp.Tag7.Todo.Domain;

public class Todo
{
    public int Id { get; set; }
    public bool Erledigt { get; set; }
    public bool InArbeit { get; set; }
    public string Beschreibung { get; set; }
    public DateTime Erledigungsdatum { get; set; }
    public DateTime Erstellungsdatum { get; set; }
    public DateTime Bearbeitungsdatum { get; set; }
    public Person Ersteller { get; set; }
    public Person Bearbeiter { get; set; }
    public Level Wichtigkeit { get; set; }
    public Level Dringlichkeit { get; set; }
    public Kategorie Kategorie { get; set; }
    public DateTime Fälligkeitsdatum { get; set; }
    public Person Ansprechperson { get; set; }
    public string Bemerkungen { get; set; }
}
