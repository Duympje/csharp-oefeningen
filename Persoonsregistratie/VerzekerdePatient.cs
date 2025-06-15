using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoonsregistratie
{
    public class VerzekerdePatient : Patient
    {
        public string Verzekeringsfirma { get; set; }

        // Tweede constructor
        public VerzekerdePatient(string voornaam, string achternaam, string geboortejaar, int opnameUren, string verzekeringsfirma)
            : base(voornaam, achternaam, geboortejaar, opnameUren)
        {
            Verzekeringsfirma = verzekeringsfirma;
        }

        public override double BerekenKost()
        {
            double kost = base.BerekenKost();
            kost *= 0.9; // 10% korting
            return Math.Round(kost, 2);
        }

        public override void Schrijven()
        {
            Console.WriteLine("Patient:");
            Console.WriteLine("Achternaam: " + Achternaam);
            Console.WriteLine("Voornaam: " + Voornaam);
            Console.WriteLine("Geboortejaar: " + Geboortejaar);
            Console.WriteLine("Leeftijd: " + Leeftijd());
            Console.WriteLine("Verzekeringsfirma: " + Verzekeringsfirma);
            Console.WriteLine("Opnametijd: " + OpnameUren + " uur");
            Console.WriteLine("Te betalen bedrag: €" + BerekenKost().ToString("0.00"));
        }
    }
}
