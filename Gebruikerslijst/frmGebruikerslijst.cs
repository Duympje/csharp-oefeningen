using Microsoft.VisualBasic;
using System.Linq;
namespace Gebruikerslijst
{
    public partial class frmGebruikerslijst : Form
    {
        //Declaratie  
        private string strVoornaam = string.Empty;
        private string strAchternaam = string.Empty;
        private string strpath = string.Empty;
        private string strBestandsNaam = string.Empty;
        string strVolledigePad = string.Empty;
        private List<(string Voornaam, string Achternaam)> personen = new List<(string, string)>();

        public frmGebruikerslijst()
        {
            InitializeComponent();
            btnWegschrijven.Visible = false; //De knop 'Wegschrijven' wordt uitgeschakeld bij het laden van het formulier.  
            btnBestand.Visible = false; //De knop 'Bestand' wordt uitgeschakeld bij het laden van het formulier.
            btnOverzicht.Visible = false; //De knop 'Overzicht' wordt uitgeschakeld bij het laden van het formulier.
        }

        private void btnInlezen_Click(object sender, EventArgs e)
        {
            //Voornaam inlezen  
            while (true)
            {
                //De gebruiker wordt gevraagd om een voornaam in te voeren.  
                strVoornaam = Interaction.InputBox("Voer uw voornaam in:", "Voornaam", "Voornaam", -1, -1);
                if (string.IsNullOrEmpty(strVoornaam))
                {
                    MessageBox.Show("Invoer is ongeldig.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; //De loop herhaalt zich als de invoer ongeldig is.  
                }
                if (strVoornaam.Any(char.IsDigit))
                {
                    MessageBox.Show("Invoer mag geen cijfers bevatten.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; //De loop herhaalt zich als de invoer cijfers bevat.  
                }
                break; //De loop wordt verlaten als de invoer geldig is.  
            }
            strVoornaam = Hoofdletter(strVoornaam);
            txtVoornaam.Text = strVoornaam;

            //Achternaam inlezen  
            while (true)
            {
                //De gebruiker wordt gevraagd om een achternaam in te voeren.  
                strAchternaam = Interaction.InputBox("Voer uw achternaam in:", "Achternaam", "Achternaam", -1, -1);
                if (string.IsNullOrEmpty(strAchternaam))
                {
                    MessageBox.Show("Invoer is ongeldig.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; //De loop herhaalt zich als de invoer ongeldig is.  
                }
                if (strAchternaam.Any(char.IsDigit))
                {
                    MessageBox.Show("Invoer mag geen cijfers bevatten.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; //De loop herhaalt zich als de invoer cijfers bevat.  
                }
                break; //De loop wordt verlaten als de invoer geldig is.  
            }
            strAchternaam = Hoofdletter(strAchternaam);
            txtAchternaam.Text = strAchternaam;
        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {
            btnWegschrijven.Visible = true; //De knop 'Wegschrijven' wordt ingeschakeld als er al een voornaam en achternaam zijn ingevoerd.  
        }

        private void btnWegschrijven_Click(object sender, EventArgs e)
        {
            //Tuple lijst  
            // Voeg samen toe als tuple  
            personen.Add((strVoornaam, strAchternaam));

            // Toon bevestiging  
            MessageBox.Show($"Persoon toegevoegd: {strVoornaam} {strAchternaam}",
                "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Maak tekstvelden leeg voor volgende invoer  
            txtVoornaam.Text = string.Empty;
            txtAchternaam.Text = string.Empty;

            btnBestand.Visible = true;
            btnWegschrijven.Visible = false; // De knop 'Wegschrijven' wordt uitgeschakeld na het wegschrijven van de gegevens.
        }

        private void btnBestand_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Selecteer een map om het bestand op te slaan.";

            // Toon de dialoog en controleer of de gebruiker op OK heeft geklikt
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Haal het geselecteerde pad op NADAT de gebruiker een keuze heeft gemaakt
                strpath = folderBrowserDialog.SelectedPath;

                // Vraag om bestandsnaam
                strBestandsNaam = Interaction.InputBox("Voer de bestandsnaam in:", "Bestandsnaam", "Gebruikerslijst.txt", -1, -1);

                // Combineer pad en bestandsnaam
                strVolledigePad = Path.Combine(strpath, strBestandsNaam);

                // Maak de Overzicht knop zichtbaar
                btnOverzicht.Visible = true;
            }
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            if (!File.Exists(strVolledigePad))
            {
                // Maak het bestand aan als het nog niet bestaat  
                using (StreamWriter myfile = File.CreateText(strVolledigePad))
                {
                    SchrijfResultaten(myfile);
                }
            }
            else
            {
                // Als het bestand al bestaat, voeg dan de nieuwe gegevens toe  
                using (StreamWriter myFile = File.AppendText(strVolledigePad))
                {
                    SchrijfResultaten(myFile);
                }
            }

            // Toon bevestiging
            MessageBox.Show($"De gegevens zijn succesvol weggeschreven naar {strVolledigePad}",
                "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBestand.Visible = true; // De knop 'Wegschrijven' wordt uitgeschakeld na het wegschrijven van de gegevens.
            btnBestand.Visible = false; // De knop 'Bestand' wordt uitgeschakeld na het wegschrijven van de gegevens.
            btnOverzicht.Visible = false; // De knop 'Overzicht' wordt uitgeschakeld na het wegschrijven van de gegevens.
        }

        private string Hoofdletter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            if (input.Length == 1)
                return input.ToUpperInvariant();

            return char.ToUpperInvariant(input[0]) + input.Substring(1).ToLowerInvariant();
        }

        private void SchrijfResultaten(StreamWriter myFile)
        {
            var gesorteerdePersonen = personen
                .OrderBy(p => p.Voornaam)
                .ThenBy(p => p.Achternaam)
                .ToList(); //slaag de gesorteerde lijst op in een nieuwe variabele

            foreach (var persoon in gesorteerdePersonen)
            {
                myFile.WriteLine($"{persoon.Voornaam} {persoon.Achternaam}");
            }
        }
    }
}
