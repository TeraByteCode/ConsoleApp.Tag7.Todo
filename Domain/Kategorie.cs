﻿namespace ConsoleApp.Tag7.Todo.Domain;

public class Kategorie
{
    public string Bezeichnung { get; set; }
    public string Beschreibung { get; set; }
    public bool IstAktiv { get; set; }
    public DateTime Erstellungsdatum { get; set; }
    public DateTime Aenderungsdatum { get; set; }
    public Person Ersteller { get; set; }
    public Person Bearbeiter { get; set; }
    public List<Todo> Todos { get; set; }
}
