using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoonsregistratie
{
    public class Patient
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Geboortejaar { get; set; }
        public int OpnameUren { get; set; }

        // Tweede constructor
        public Patient(string voornaam, string achternaam, string geboortejaar, int opnameUren)
        {
            Voornaam = Hoofdletter(voornaam);
            Achternaam = Hoofdletter(achternaam);
            Geboortejaar = geboortejaar;
            OpnameUren = opnameUren;
        }

        public virtual double BerekenKost()
        {
            return 50 + 20 * OpnameUren;
        }

        public static string Hoofdletter(string naam)
        {
            if (string.IsNullOrWhiteSpace(naam)) return naam;
            // Eerste letter hoofdletter, rest klein
            return char.ToUpper(naam[0]) + naam.Substring(1).ToLower();
        }

        public int Leeftijd()
        {
            DateTime geboortedatum = DateTime.ParseExact(Geboortejaar, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime nu = DateTime.Today;
            int leeftijd = nu.Year - geboortedatum.Year;
            if (nu.Month < geboortedatum.Month || (nu.Month == geboortedatum.Month && nu.Day < geboortedatum.Day))
            {
                leeftijd--;
            }
            return leeftijd;
        }

        public virtual void Schrijven()
        {
            Console.WriteLine("Patient:");
            Console.WriteLine("Achternaam: " + Achternaam);
            Console.WriteLine("Voornaam: " + Voornaam);
            Console.WriteLine("Geboortejaar: " + Geboortejaar);
            Console.WriteLine("Leeftijd: " + Leeftijd());
            Console.WriteLine("Verzekeringsfirma: ");
            Console.WriteLine("Opnametijd: " + OpnameUren + " uur");
            Console.WriteLine("Te betalen bedrag: €" + BerekenKost().ToString("0.00"));
        }
    }
}
