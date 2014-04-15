using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public partial class FormLogin : Form
    {
        FormMain formMain;
        
        public FormLogin()
        {

            InitializeComponent();
            //zorgt ervoor dat de laatste gebruikersnaam en wachtwoord in al worden ingevuld
            tbGebruikersnaam.Text = Properties.Settings.Default.login_last_username;
            tbWachtwoord.Text = Properties.Settings.Default.login_last_password;
            //tabindex is de positie wat geselecteerd word als 'tab' wordt ingeduwd
            if (tbGebruikersnaam.Text.Length > 0)
            {
                tbGebruikersnaam.TabIndex = 100;
            }

            if (tbWachtwoord.Text.Length > 0)
            {
                checkBoxRememberPassword.Checked = true;
                tbWachtwoord.TabIndex = 101;
            }
            
        }

        //controleert of de inloggegevens kloppen en logt vervolgens wel of niet in
        private void Inloggen()
        {
            Database db = new Database();
            try
            {
                string gebruikersnaam = tbGebruikersnaam.Text.Trim().ToLower(); //maakt van alles kleine letters en zorgt ervoor dat speciale tekens worden weggehaald
                string wachtwoord = tbWachtwoord.Text.Trim();

                //kijkt of de velden niet leeg zijn
                if (gebruikersnaam.Length <= 0 || wachtwoord.Length <= 0)
                {
                    throw new Exception("Gebruikersnaam en wachtwoord zijn onbekend.");
                }
                //haalt de gegevens uit de database op
                db.CreateCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = :gebruikersnaam AND wachtwoord = :wachtwoord");
                db.AddParameter("gebruikersnaam", gebruikersnaam);
                db.AddParameter("wachtwoord", wachtwoord);


                if (db.Read())
                {
                    Properties.Settings.Default.login_last_username = gebruikersnaam;

                    if (!checkBoxRememberPassword.Checked)
                    {
                        tbWachtwoord.Text = "";
                    }

                    Properties.Settings.Default.login_last_password = tbWachtwoord.Text.Trim();
                    Properties.Settings.Default.Save();

                    //opent het hoofdscherm nadat de inlog succesvol is en sluit dit form.
                    formMain = new FormMain();
                    formMain.Show();
                    formMain.FormClosing += FormMainFormClosing; 
                    formMain.buttonLogout.Click += btUitloggen_Click;  
                    this.Hide();
                }
                else
                {
                    throw new Exception("Gebruikersnaam en wachtwoord zijn onbekend.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }


        private void btInloggen_Click(object sender, EventArgs e)
        {
            Inloggen();
        }

        void FormMainFormClosing(object sender, FormClosingEventArgs e)
        {
            //vraagt om een sluitbevestiging
            DialogResult result = MessageBox.Show("Weet u zeker dat u dit programma af wilt sluiten?", "Afsluiten", MessageBoxButtons.YesNo);

            if (result != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {

                Dispose(); //'vernietigd' het form
            }
        }


        void btUitloggen_Click(object sender, EventArgs e)
        {
            formMain.Hide();
            this.Show();
        }


        //alternatief voor het klikken op de knop
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Inloggen();
            }
        }

      
    }
}
