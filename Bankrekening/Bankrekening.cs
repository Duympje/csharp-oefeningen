using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    public class Bankrekening
    {
        public string Rekeningnummer { get; set; }
        public string Achternaam { get; set; }
        public string Voornaam { get; set; }
        public decimal Saldo { get; set; }
        public decimal Rente { get; set; } // bijv. 0.02 voor 2%
        public int Jaren { get; set; } // Voor rente-berekening over jaren

        public Bankrekening(string rekeningnummer, string achternaam, string voornaam, decimal saldo, decimal rente)
        {
            Rekeningnummer = rekeningnummer;
            Achternaam = achternaam;
            Voornaam = voornaam;
            Saldo = saldo;
            Rente = rente;
        }

        public void Opname(decimal bedrag)
        {
            if (bedrag > Saldo)
            {
                Console.WriteLine($"Saldo ontoereikend. Er staat helaas niet voldoende geld op jouw rekening om dit bedrag af te halen. Het huidige saldo is: {Saldo:F2}.");
            }
            else
            {
                Saldo -= bedrag;
                Saldo = Math.Round(Saldo, 2);
                Console.WriteLine($"Er is {bedrag:F2} euro opgenomen. Nieuw saldo: {Saldo:F2} euro.");
            }
        }

        public void Storting(decimal bedrag)
        {
            Saldo += bedrag;
            Saldo = Math.Round(Saldo, 2);
            Console.WriteLine($"Er is {bedrag:F2} euro gestort. Nieuw saldo: {Saldo:F2} euro.");
        }

        public void ToonSaldo()
        {
            Console.WriteLine($"Het huidige saldo is: {Saldo:F2} euro.");
        }

        public decimal RenteBerekenen(int jaren)
        {
            Jaren = jaren;
            decimal renteBedrag = Saldo * Rente * jaren;
            renteBedrag = Math.Round(renteBedrag, 2);
            Console.WriteLine($"Je rente bedraagt momenteel {renteBedrag:F2} euro.");
            return renteBedrag;
        }
    }
}
