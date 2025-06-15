using System.Globalization;

namespace Bankrekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Invoer van de gebruiker
            Console.Write("Geef je rekeningnummer: ");
            string rekeningnummer = Console.ReadLine();
            Console.Write("Geef je achternaam: ");
            string achternaam = Console.ReadLine();
            Console.Write("Geef je voornaam: ");
            string voornaam = Console.ReadLine();
            decimal saldo = 0;
            while (true)
            {
                Console.Write("Geef je saldo: ");
                if (decimal.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out saldo))
                {
                    break;
                }
                Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
            }

            decimal rente = 0.02m; // 2%
            // Basis klant aanmaken
            Bankrekening mijnKlant = new Bankrekening(rekeningnummer, achternaam, voornaam, saldo, rente);

            while (true)
            {
                Console.WriteLine("\nOpties: (B)edrag opnemen of storten, (S)aldo tonen, (R)ente berekenen, END om te stoppen");
                Console.Write("Maak een keuze: ");
                string keuze = Console.ReadLine().Trim().ToUpper();

                if (keuze == "END")
                {
                    Console.WriteLine("Programma beëindigd.");
                    break;
                }
                else if (keuze == "B")
                {
                    Console.Write("Voer een bedrag in (positief = storting, negatief = opname): ");
                    decimal bedrag;
                    if (decimal.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out bedrag))
                    {
                        bedrag = Math.Round(bedrag, 2);
                        if (bedrag < 0)
                        {
                            mijnKlant.Opname(-bedrag);
                        }
                        else
                        {
                            mijnKlant.Storting(bedrag);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
                    }
                }
                else if (keuze == "S")
                {
                    mijnKlant.ToonSaldo();
                }
                else if (keuze == "R")
                {
                    int jaren;
                    while (true)
                    {
                        Console.Write("Hoeveel jaar staat het bedrag op de rekening? ");
                        if (int.TryParse(Console.ReadLine(), out jaren) && jaren > 0)
                        {
                            break;
                        }
                        Console.WriteLine("Ongeldige invoer. Probeer opnieuw.");
                    }

                    mijnKlant.RenteBerekenen(jaren);

                    // Vraag om klanttype
                    Console.Write("Welk type klant ben je? (gold/silver): ");
                    string categorie = Console.ReadLine().Trim().ToLower();
                    while (categorie != "gold" && categorie != "silver")
                    {
                        Console.Write("Ongeldige keuze. Typ 'gold' of 'silver': ");
                        categorie = Console.ReadLine().Trim().ToLower();
                    }
                    Klantentype typeKlant = new Klantentype(mijnKlant.Rekeningnummer, mijnKlant.Achternaam, mijnKlant.Voornaam, mijnKlant.Saldo, mijnKlant.Rente, categorie);
                    typeKlant.RenteBerekenen(jaren);
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
                }
            }
        }
    }
}
