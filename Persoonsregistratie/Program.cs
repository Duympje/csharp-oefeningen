using System.Globalization;

namespace Persoonsregistratie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verzekerd = VraagVerzekerd();

            string voornaam = VraagVoornaam();
            string achternaam = VraagAchternaam(voornaam);

            string geboortejaar = VraagGeboortejaar();
            int opnameUren = VraagOpnameUren();

            if (!verzekerd)
            {
                Patient p = new Patient(voornaam, achternaam, geboortejaar, opnameUren);
                p.Schrijven();
            }
            else
            {
                string verzekeringsfirma = VraagVerzekeringsfirma();
                VerzekerdePatient vp = new VerzekerdePatient(voornaam, achternaam, geboortejaar, opnameUren, verzekeringsfirma);
                vp.Schrijven();
            }
        }

        static bool VraagVerzekerd()
        {
            while (true)
            {
                Console.Write("Is de persoon verzekerd? (ja/neen): ");
                string antwoord = Console.ReadLine().Trim().ToLower();
                if (antwoord == "ja")
                    return true;
                if (antwoord == "neen")
                    return false;
                Console.WriteLine("Foutief antwoord, gelieve 'ja' of 'neen' in te geven.");
            }
        }

        static string VraagVoornaam()
        {
            while (true)
            {
                Console.Write("Voornaam: ");
                string voornaam = Console.ReadLine().Trim();
                if (HeeftCijfer(voornaam))
                {
                    Console.WriteLine("Voornaam mag geen cijfers bevatten.");
                    continue;
                }
                return voornaam;
            }
        }

        static string VraagAchternaam(string voornaam)
        {
            while (true)
            {
                Console.Write("Achternaam: ");
                string achternaam = Console.ReadLine().Trim();
                if (HeeftCijfer(achternaam))
                {
                    Console.WriteLine("Achternaam mag geen cijfers bevatten.");
                    continue;
                }
                if (voornaam.Equals(achternaam, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Voornaam en achternaam mogen niet gelijk zijn.");
                    continue;
                }
                return achternaam;
            }
        }

        static string VraagGeboortejaar()
        {
            while (true)
            {
                Console.Write("Geboortejaar (dd/mm/jjjj): ");
                string geboortejaar = Console.ReadLine().Trim();
                if (DateTime.TryParseExact(geboortejaar, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    return geboortejaar;
                Console.WriteLine("Foutief formaat. Gelieve in te geven als dd/mm/jjjj.");
            }
        }

        static int VraagOpnameUren()
        {
            while (true)
            {
                Console.Write("Aantal uren van opname: ");
                string invoer = Console.ReadLine().Trim();
                if (int.TryParse(invoer, out int uren) && uren >= 0)
                    return uren;
                Console.WriteLine("Gelieve een geldig aantal uren in te geven.");
            }
        }

        static string VraagVerzekeringsfirma()
        {
            Console.Write("Verzekeringsfirma: ");
            return Console.ReadLine().Trim();
        }

        static bool HeeftCijfer(string tekst)
        {
            foreach (char c in tekst)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }
    }
    
}
