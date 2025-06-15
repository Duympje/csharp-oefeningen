namespace Gebruikerslijst
{
    partial class frmGebruikerslijst
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInlezen = new Button();
            txtVoornaam = new TextBox();
            txtAchternaam = new TextBox();
            btnWegschrijven = new Button();
            btnBestand = new Button();
            btnOverzicht = new Button();
            SuspendLayout();
            // 
            // btnInlezen
            // 
            btnInlezen.Location = new Point(37, 41);
            btnInlezen.Name = "btnInlezen";
            btnInlezen.Size = new Size(186, 79);
            btnInlezen.TabIndex = 0;
            btnInlezen.Text = "Lees de gebruiker in";
            btnInlezen.UseVisualStyleBackColor = true;
            btnInlezen.Click += btnInlezen_Click;
            // 
            // txtVoornaam
            // 
            txtVoornaam.Location = new Point(37, 146);
            txtVoornaam.Name = "txtVoornaam";
            txtVoornaam.PlaceholderText = "Voornaam";
            txtVoornaam.ReadOnly = true;
            txtVoornaam.Size = new Size(150, 31);
            txtVoornaam.TabIndex = 1;
            // 
            // txtAchternaam
            // 
            txtAchternaam.Location = new Point(37, 201);
            txtAchternaam.Name = "txtAchternaam";
            txtAchternaam.PlaceholderText = "Achternaam";
            txtAchternaam.ReadOnly = true;
            txtAchternaam.Size = new Size(150, 31);
            txtAchternaam.TabIndex = 2;
            txtAchternaam.TextChanged += txtAchternaam_TextChanged;
            // 
            // btnWegschrijven
            // 
            btnWegschrijven.Location = new Point(256, 41);
            btnWegschrijven.Name = "btnWegschrijven";
            btnWegschrijven.Size = new Size(186, 79);
            btnWegschrijven.TabIndex = 3;
            btnWegschrijven.Text = "Schrijf de gebruikersnaam weg";
            btnWegschrijven.UseVisualStyleBackColor = true;
            btnWegschrijven.Click += btnWegschrijven_Click;
            // 
            // btnBestand
            // 
            btnBestand.Location = new Point(256, 146);
            btnBestand.Name = "btnBestand";
            btnBestand.Size = new Size(186, 79);
            btnBestand.TabIndex = 4;
            btnBestand.Text = "Selecteer bestandslocatie";
            btnBestand.UseVisualStyleBackColor = true;
            btnBestand.Click += btnBestand_Click;
            // 
            // btnOverzicht
            // 
            btnOverzicht.Location = new Point(37, 264);
            btnOverzicht.Name = "btnOverzicht";
            btnOverzicht.Size = new Size(186, 79);
            btnOverzicht.TabIndex = 5;
            btnOverzicht.Text = "Overzichtslijst wegschrijven";
            btnOverzicht.UseVisualStyleBackColor = true;
            btnOverzicht.Click += btnOverzicht_Click;
            // 
            // frmGebruikerslijst
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOverzicht);
            Controls.Add(btnBestand);
            Controls.Add(btnWegschrijven);
            Controls.Add(txtAchternaam);
            Controls.Add(txtVoornaam);
            Controls.Add(btnInlezen);
            Name = "frmGebruikerslijst";
            Text = "Gebruikerslijst";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInlezen;
        private TextBox txtVoornaam;
        private TextBox txtAchternaam;
        private Button btnWegschrijven;
        private Button btnBestand;
        private Button btnOverzicht;
    }
}
