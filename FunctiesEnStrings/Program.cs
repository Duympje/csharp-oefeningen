using System.Globalization;

namespace FunctiesEnStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaratie  
            string strZin;
            string strWoorden;
            string strKarakters;

            while (true)
            {
                Console.WriteLine("Geef een zin van minstens 10 tekens.");
                Console.Write("Invoer: ");
                strZin = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(strZin))
                {
                    Console.WriteLine("De ingevoerde zin mag niet leeg zijn.");
                    continue;
                }
                if (strZin.Length < 10)
                {
                    Console.WriteLine("De ingevoerde zin moet minstens 10 tekens bevatten.");
                    continue;
                }
                break;
            }
            Console.Clear();
            Console.WriteLine($"Orginele zin {strZin}");
            //Zin berwerking
            strZin = VerwijderSpaties(strZin);
            strZin = Hoofdletter(strZin);
            Console.WriteLine($"Bewerkte zin: {strZin}");
            AantalKarakters(strZin);
            Omzetting(strZin);

        }

        private static string VerwijderSpaties(string zin)
        {
            zin = zin.TrimStart();
            zin = zin.TrimEnd();
            return zin;
        }

        private static string Hoofdletter(string zin)
        {
            // Gebruik TextInfo.ToTitleCase om automatisch elk woord met hoofdletter te beginnen
            TextInfo textInfo = new CultureInfo("nl-NL").TextInfo;
            return textInfo.ToTitleCase(zin.ToLower());
        }

        private static void AantalKarakters(string zin)
        {
            // Tel het aantal karakters in de zin
            int aantalKarakters = zin.Length;

            // Tel het aantal woorden in de zin
            int aantalWoorden = zin.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Print het resultaat naar de console
            Console.WriteLine($"Aantal karakters: {aantalKarakters}, Aantal woorden: {aantalWoorden}");
        }

        private static void Omzetting(string zin)
        {
            int som = 0;

            // Zet de zin om naar hoofdletters zodat we niet apart hoofdletters en kleine letters hoeven te behandelen
            zin = zin.ToUpper();

            foreach (char c in zin)
            {
                // Controleer of het karakter een letter is
                if (char.IsLetter(c))
                {
                    // A = 65 in ASCII, dus we trekken 64 af om A=1, B=2, etc. te krijgen
                    int waarde = c - 64;
                    som += waarde;
                }
                // Niet-letters (spaties, leestekens, etc.) worden overgeslagen
            }

            Console.WriteLine($"De som van de letters in de zin is: {som}");
        }
    }
}
