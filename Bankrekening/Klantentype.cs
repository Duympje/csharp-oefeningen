using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    public class Klantentype : Bankrekening
    {
        public string Categorie { get; set; } // gold of silver

        public Klantentype(string rekeningnummer, string achternaam, string voornaam, decimal saldo, decimal rente, string categorie)
            : base(rekeningnummer, achternaam, voornaam, saldo, rente)
        {
            Categorie = categorie;
        }

        public decimal RenteBerekenen(int jaren)
        {
            decimal extraRente = 0;
            if (Categorie.ToLower() == "gold")
            {
                extraRente = Saldo * 0.01m * jaren;
            }
            else if (Categorie.ToLower() == "silver")
            {
                extraRente = Saldo * 0.005m * jaren;
            }
            extraRente = Math.Round(extraRente, 2);
            Console.WriteLine($"Als {Categorie} klant krijg je {extraRente:F2} extra euro op jouw rekening.");
            return extraRente;
        }
    }
}
