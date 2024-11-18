using ConsoleApp.Tag7.Todo.Domain.Enums;

namespace ConsoleApp.Tag7.Todo.Domain;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Vorname { get; set; }
    public DateTime Geburtsdatum { get; set; }
    public Anrede Anrede { get; set; }
    public string EMail { get; set; }
    public string Telefonnummer { get; set; }
    public string Adresse { get; set; }
    public string PLZ { get; set; }
    public string Ort { get; set; }
    public string Land { get; set; }
    public string Nationalität { get; set; }
    public string Sprache { get; set; }
    public string Bemerkungen { get; set; }
}
