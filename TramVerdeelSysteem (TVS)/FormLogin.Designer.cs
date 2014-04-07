namespace TramVerdeelSysteem__TVS_
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbGebruikersnaam = new System.Windows.Forms.Label();
            this.lbWachtwoord = new System.Windows.Forms.Label();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.btInloggen = new System.Windows.Forms.Button();
            this.lbBeschrijving = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGebruikersnaam
            // 
            this.lbGebruikersnaam.AutoSize = true;
            this.lbGebruikersnaam.Location = new System.Drawing.Point(12, 126);
            this.lbGebruikersnaam.Name = "lbGebruikersnaam";
            this.lbGebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lbGebruikersnaam.TabIndex = 0;
            this.lbGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // lbWachtwoord
            // 
            this.lbWachtwoord.AutoSize = true;
            this.lbWachtwoord.Location = new System.Drawing.Point(12, 150);
            this.lbWachtwoord.Name = "lbWachtwoord";
            this.lbWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lbWachtwoord.TabIndex = 0;
            this.lbWachtwoord.Text = "Wachtwoord:";
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(105, 123);
            this.tbGebruikersnaam.MaxLength = 30;
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(179, 20);
            this.tbGebruikersnaam.TabIndex = 0;
            this.tbGebruikersnaam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(105, 147);
            this.tbWachtwoord.MaxLength = 30;
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.PasswordChar = '*';
            this.tbWachtwoord.Size = new System.Drawing.Size(179, 20);
            this.tbWachtwoord.TabIndex = 1;
            this.tbWachtwoord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // btInloggen
            // 
            this.btInloggen.Location = new System.Drawing.Point(208, 174);
            this.btInloggen.Name = "btInloggen";
            this.btInloggen.Size = new System.Drawing.Size(75, 23);
            this.btInloggen.TabIndex = 2;
            this.btInloggen.Text = "Inloggen";
            this.btInloggen.UseVisualStyleBackColor = true;
            this.btInloggen.Click += new System.EventHandler(this.btInloggen_Click);
            // 
            // lbBeschrijving
            // 
            this.lbBeschrijving.AutoSize = true;
            this.lbBeschrijving.Location = new System.Drawing.Point(12, 102);
            this.lbBeschrijving.Name = "lbBeschrijving";
            this.lbBeschrijving.Size = new System.Drawing.Size(223, 13);
            this.lbBeschrijving.TabIndex = 0;
            this.lbBeschrijving.Text = "Geef een gebruikersnaam en wachtwoord op.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btInloggen);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.lbWachtwoord);
            this.Controls.Add(this.lbBeschrijving);
            this.Controls.Add(this.lbGebruikersnaam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 240);
            this.Name = "FormLogin";
            this.Text = "GVB - Inloggen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGebruikersnaam;
        private System.Windows.Forms.Label lbWachtwoord;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Button btInloggen;
        private System.Windows.Forms.Label lbBeschrijving;
        private System.Windows.Forms.PictureBox pictureBox1;
        }

}