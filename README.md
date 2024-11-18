# ConsoleApp.Tag7.Todo auch als Todo

Dieses Todo Console App ist ein einfaches Todo-Listen-Programm, das in der Konsole ausgeführt wird. 


Was kan mit diese App alles machen?

- [x] Todo hinzufügen
- [ ] Todo löschen
- [ ] Todo bearbeiten
- [ ] Todo anzeigen
- [ ] Todo speichern
- [ ] Todo laden
- [ ] Todo sortieren
- [ ] Todo filtern
- [ ] Todo exportieren
- [ ] Todo importieren
- [ ] Todo als erledigt markieren
- [ ] Todo als nicht erledigt markieren
- [ ] Todo als wichtig markieren
- [ ] Todo als nicht wichtig markieren
- [ ] Todo als dringend markieren
- [ ] Todo als nicht dringend markieren
- [ ] Todo als überfällig markieren
- [ ] Todo als nicht überfällig markieren


Entität: Todo

- [ ] Id                : int
- [	] Erledigt          : Boolean
- [ ] InArbeit          : Boolean
- [	] Beschreibung      : String
- [ ] Erledigungsdatum  : DateTime
- [ ] Erstellungsdatum  : DateTime
- [ ] Bearbeitungsdatum : DateTime
- [ ] Ersteller         : Person
- [ ] Bearbeiter        : Person
- [	] Wichtigkeit       : Enum (Niedrig, Normal, Hoch)
- [ ] Dringlichkeit     : Enum (Niedrig, Normal, Hoch)
- [	] Kategorie         : Kategorie
- [ ] Fälligkeitsdatum  : DateTime
- [ ] Ansprechperson    : Person
- [ ] Bemerkungen       : string





Entität: Person =>
	- [ ] Id             : int
	- [ ] Name           : string
	- [ ] Vorname        : string
	- [ ] Geburtsdatum   : DateTime
	- [ ] Geschlecht     : Enum (Männlich, Weiblich, Divers)
	- [ ] E-Mail		 : string
	- [ ] Telefonnummer  : string
	- [ ] Adresse        : string
	- [ ] PLZ            : string
	- [ ] Ort            : string
	- [ ] Land           : string
	- [ ] Nationalität   : string
	- [ ] Sprache        : string	
	- [ ] Bemerkungen    : string

