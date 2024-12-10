using ConsoleApp.Tag7.Todo.Domain;

namespace ConsoleApp.Tag7.Todo.Data;

public class KategorienRepository
{
    public List<Kategorie> ListeKategorien = [];

    public KategorienRepository()
    {
        var kat1 = new Kategorie { Bezeichnung = "Einkaufen", Id = 1, Erstellungsdatum = DateTime.Now };
        ListeKategorien.Add(kat1);

        var katX = ListeKategorien.FirstOrDefault(kategorie => kategorie.Id == 1);
        var katY = ListeKategorien[0];

        foreach (var kategorie in ListeKategorien)
        {
            if (kategorie.Id == 1)
            {
                katX = kategorie;
                break;
            }
        }
    }
    public void Add(Kategorie kategorie)
    {
        if (kategorie.Id == 0)
        {
            var maxId = ListeKategorien.Max(p => p.Id);
            kategorie.Id = maxId + 1;
        }

        ListeKategorien.Add(kategorie);
    }
    public void Update(int id, Kategorie kategorie)
    {
        var index = ListeKategorien.FindIndex(p => p.Id == id);
        if (index == -1)
        {
            throw new Exception("Kategorie nicht gefunden");
        }
        ListeKategorien[index] = kategorie;
    }
    public void Delete(Kategorie kategorie)
    {
        var k = ListeKategorien.FirstOrDefault(p => p.Id == kategorie.Id);
        if (k == null)
        {
            throw new Exception("Kategorie nicht gefunden");
        }
        ListeKategorien.Remove(kategorie);
    }

    public void Delete(int id)
    {
        var kategorie = ListeKategorien.FirstOrDefault(p => p.Id == id);
        if (kategorie == null)
        {
            throw new Exception("Kategorie nicht gefunden");
        }
        ListeKategorien.Remove(kategorie);
    }

    public Kategorie? GetById(int id)
    {
        return ListeKategorien.FirstOrDefault(p => p.Id == id);
    }

    public List<Kategorie> GetAll()
    {
        return ListeKategorien;
    }
}
