# Programmeernotities

## Controle lus

Een controle lus om invoer te valideren:

```csharp
while (true)
{
    if (string.IsNullOrEmpty(strInput))
    {
        MessageBox.Show("Invoer is ongeldig.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
        continue; // De loop herhaalt zich als de invoer ongeldig is.
    }
    
    if (strInput.Any(char.IsDigit))
    {
        MessageBox.Show("Invoer mag geen cijfers bevatten.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
        continue; // De loop herhaalt zich als de invoer cijfers bevat.
    }
    
    break; // De loop wordt verlaten als de invoer geldig is.
}
```

### Uitleg

- **Oneindige loop**: `while (true)` zorgt voor een controle lus die blijft draaien
- **Validatie 1**: Controleert of de invoer leeg of null is
- **Validatie 2**: Controleert of de invoer cijfers bevat met `Any(char.IsDigit)`
- **Continue**: Herstart de loop bij ongeldige invoer
- **Break**: Verlaat de loop bij geldige invoer


## String manipulatie

### Hoofdletter conversie

Verschillende manieren om strings naar hoofdletters om te zetten:

```csharp
// Hele string naar hoofdletters
string result = input.ToUpperInvariant();

// Eerste letter hoofdletter, rest kleine letters (Title Case)
string titleCase = char.ToUpperInvariant(input[0]) + input.Substring(1).ToLowerInvariant();
```

### Uitleg String methoden

- **`ToUpperInvariant()`**: Zet de hele string om naar hoofdletters (culture-independent)
- **`char.ToUpperInvariant()`**: Zet één karakter om naar hoofdletter
- **`Substring(1)`**: Haalt alle karakters vanaf positie 1 (tweede karakter)
- **`ToLowerInvariant()`**: Zet string om naar kleine letters

---

## List Tuples

### Wat zijn Tuples?

Een tuple is een handig hulpmiddel om snel en flexibel meerdere (verschillende) gegevens bij elkaar te houden, vooral als je die samen wilt doorgeven of teruggeven.

```csharp
// Declaratie van een List met Named Tuples
private List<(string Voornaam, string Achternaam)> personen = new List<(string, string)>();

// Tuple toevoegen aan lijst
personen.Add((varaibelen, variabelen));

// Bevestiging tonen met tuple waarden
MessageBox.Show($"Persoon toegevoegd: {strVoornaam} {strAchternaam}",
    "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
```

### Tuple toegang en gebruik

```csharp
// Via named fields (aanbevolen in jouw code)
Console.WriteLine($"Voornaam: {persoon.voornaam}");
Console.WriteLine($"Achternaam: {persoon.achternaam}");

// Destructuring - waarden uiteenhalen
(string voornaam, string achternaam) = persoon;

// Door lijst itereren met tuples
foreach (var (voornaam, achternaam) in personen)
{
    Console.WriteLine($"Persoon: {voornaam} {achternaam}");
}
```





### Uitleg Tuple concepten

- **Named Tuples**: Geef betekenisvolle namen zoals `(string Voornaam, string Achternaam)`
- **List<Tuple>**: Perfecte combinatie voor het opslaan van gerelateerde data (jouw personen lijst)
- **Destructuring**: `foreach (var (voornaam, achternaam) in personen)` - makkelijke toegang
- **Return Multiple Values**: Ideaal voor validatie methoden
- **Temporary Grouping**: Geen aparte klasse nodig voor simpele data groepering

---

## Projectoverzicht

### 📁 Huidige projecten in workspace:
- **Gebruikerslijst** - Windows Forms applicatie met InputBox
- **NaamInvoer** - Windows Forms voor naam invoer
- **KleurcodeWeerstand** - Kleurcode calculator
- **DrankAutomaat** - Drankautomaat simulatie
- **FunctiesEnStrings** - String functies oefeningen
- **Bankrekening** - Banking applicatie
- **Persoonsregistratie** - Persoon data management
- **TemperatuurOmzetting** - Temperatuur converter
- **SomEnVerschil** - Mathematische bewerkingen