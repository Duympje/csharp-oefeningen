namespace NaamInvoer
{
    partial class frmInvoer
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
            components = new System.ComponentModel.Container();
            btnNieuweIngave = new Button();
            btnCorrigeer = new Button();
            btnExit = new Button();
            txtInvoer1 = new TextBox();
            txtUitvoer = new TextBox();
            txtInvoer2 = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnNieuweIngave
            // 
            btnNieuweIngave.Location = new Point(25, 34);
            btnNieuweIngave.Name = "btnNieuweIngave";
            btnNieuweIngave.Size = new Size(190, 55);
            btnNieuweIngave.TabIndex = 0;
            btnNieuweIngave.Text = "Nieuwe Ingave";
            btnNieuweIngave.UseVisualStyleBackColor = true;
            btnNieuweIngave.Click += btnNieuweIngave_Click;
            // 
            // btnCorrigeer
            // 
            btnCorrigeer.Location = new Point(234, 34);
            btnCorrigeer.Name = "btnCorrigeer";
            btnCorrigeer.Size = new Size(190, 55);
            btnCorrigeer.TabIndex = 1;
            btnCorrigeer.Text = "Corrigeer Gegevens";
            btnCorrigeer.UseVisualStyleBackColor = true;
            btnCorrigeer.Click += btnCorrigeer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(444, 34);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 55);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // txtInvoer1
            // 
            txtInvoer1.Location = new Point(25, 106);
            txtInvoer1.Name = "txtInvoer1";
            txtInvoer1.Size = new Size(190, 31);
            txtInvoer1.TabIndex = 3;
            toolTip1.SetToolTip(txtInvoer1, "Vul hier iets in");
            // 
            // txtUitvoer
            // 
            txtUitvoer.Location = new Point(444, 106);
            txtUitvoer.Name = "txtUitvoer";
            txtUitvoer.Size = new Size(190, 31);
            txtUitvoer.TabIndex = 4;
            toolTip1.SetToolTip(txtUitvoer, "Uitvoer");
            txtUitvoer.MouseLeave += txtUitvoer_MouseLeave;
            txtUitvoer.MouseHover += txtUitvoer_MouseHover;
            // 
            // txtInvoer2
            // 
            txtInvoer2.Location = new Point(234, 106);
            txtInvoer2.Name = "txtInvoer2";
            txtInvoer2.Size = new Size(190, 31);
            txtInvoer2.TabIndex = 5;
            toolTip1.SetToolTip(txtInvoer2, "Vul hier iets in");
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 100;
            toolTip1.Tag = "";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Tip";
            // 
            // frmInvoer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInvoer2);
            Controls.Add(txtUitvoer);
            Controls.Add(txtInvoer1);
            Controls.Add(btnExit);
            Controls.Add(btnCorrigeer);
            Controls.Add(btnNieuweIngave);
            Name = "frmInvoer";
            Text = "Invoer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNieuweIngave;
        private Button btnCorrigeer;
        private Button btnExit;
        private TextBox txtInvoer1;
        private TextBox txtUitvoer;
        private TextBox txtInvoer2;
        private ToolTip toolTip1;
    }
}
