namespace NaamInvoer
{
    public partial class frmInvoer : Form
    {
        //Declaratie
        string strInvoer1;
        string strInvoer2;
        string strUitvoer;
        public frmInvoer()
        {
            InitializeComponent();
            btnCorrigeer.Visible = false;
            txtInvoer1.Visible = false;
            txtInvoer2.Visible = false;
            txtUitvoer.Visible = false;
        }

        private void btnNieuweIngave_Click(object sender, EventArgs e)
        {
            txtInvoer1.Visible = true;
            txtInvoer2.Visible = true;
            btnCorrigeer.Visible = true;
        }

        private void btnCorrigeer_Click(object sender, EventArgs e)
        {
            strInvoer1 = txtInvoer1.Text;
            strInvoer2 = txtInvoer2.Text;

            strInvoer1 = CorrigeerGegevens(strInvoer1);
            strInvoer2 = CorrigeerGegevens(strInvoer2);

            txtUitvoer.Visible = true;

            strUitvoer = $"{strInvoer1} / {strInvoer2}"; // Combineer de twee invoeren
            txtUitvoer.Text = strUitvoer; // Toon de gecombineerde tekst in de uitvoer textbox

        }

        public string CorrigeerGegevens(string invoer)
        {
            invoer = invoer.Trim(); // Verwijder spaties aan het begin en einde
            invoer = invoer.ToLower(); // Zet de tekst om naar kleine letters
            return invoer;
        }

        private void txtUitvoer_MouseHover(object sender, EventArgs e)
        {
            //Kluer van de text box aanpassen
            txtUitvoer.BackColor = Color.Yellow;
        }

        private void txtUitvoer_MouseLeave(object sender, EventArgs e)
        {
            txtUitvoer.BackColor = Color.White;
        }
    }
}
