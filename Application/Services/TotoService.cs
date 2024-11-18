﻿using ConsoleApp.Tag7.Todo.Data;
using ConsoleApp.Tag7.Todo.Domain;

namespace ConsoleApp.Tag7.Todo.Application.Services;

public class TotoService
{
    public KategorienRepository KategorienRepository { get; set; }
    public ToDoRepository TodoRepository { get; set; }
    public PersonenRepository PersonRepository { get; set; }
    private Person AktuelleBenutzer { get; set; }

    public TotoService()
    {
        KategorienRepository = new KategorienRepository();
        TodoRepository = new ToDoRepository();
        PersonRepository = new PersonenRepository();
    }

    public void SetAktuellerBenutzer(Person person)
    {
        AktuelleBenutzer = person;
    }

    public void AddKategorie(Kategorie kategorie)
    {
        kategorie.Ersteller = AktuelleBenutzer;
        kategorie.Bearbeiter = AktuelleBenutzer;
        kategorie.Erstellungsdatum = DateTime.Now;
        kategorie.Aenderungsdatum = DateTime.Now;
        if (string.IsNullOrEmpty(kategorie.Bezeichnung))
        {
            throw new ArgumentNullException(nameof(kategorie.Bezeichnung));
        }

        KategorienRepository.Add(kategorie);
    }

    public void AddToDo(ToDo todo)
    {
        todo.Ersteller = AktuelleBenutzer;
        todo.Bearbeiter = AktuelleBenutzer;
        todo.Erstellungsdatum = DateTime.Now;
        todo.Bearbeitungsdatum = DateTime.Now;
        if (string.IsNullOrEmpty(todo.Beschreibung))
        {
            throw new ArgumentNullException(nameof(todo.Beschreibung));
        }

        if (todo.Kategorie == null)
        {
            throw new ArgumentNullException(nameof(todo.Kategorie));
        }



        TodoRepository.Add(todo);
    }

    public void UpdateKategorie(int id, Kategorie kategorie)
    {
        var k = KategorienRepository.GetById(id);

        if (k == null)
        {
            throw new Exception("Kategorie nicht gefunden");
        }

        kategorie.Bearbeiter = AktuelleBenutzer;
        kategorie.Aenderungsdatum = DateTime.Now;

        if (string.IsNullOrEmpty(kategorie.Bezeichnung))
        {
            throw new ArgumentNullException(nameof(kategorie.Bezeichnung));
        }

        KategorienRepository.Update(id, kategorie);
    }

    public void UpdateToDo(int id, ToDo todo)
    {
        var t = TodoRepository.GetById(id);

        if (t == null)
        {
            throw new Exception("Todo nicht gefunden");
        }

        if (t.Erledigt)
        {
            throw new Exception("Erledigte Todos können nicht bearbeitet werden");
        }

        todo.Bearbeiter = AktuelleBenutzer;
        todo.Bearbeitungsdatum = DateTime.Now;

        if (string.IsNullOrEmpty(todo.Beschreibung))
        {
            throw new ArgumentNullException(nameof(todo.Beschreibung));
        }

        if (todo.Kategorie == null)
        {
            throw new ArgumentNullException(nameof(todo.Kategorie));
        }

        TodoRepository.Update(id, todo);
    }

}