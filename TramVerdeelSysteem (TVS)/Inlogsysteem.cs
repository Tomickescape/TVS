using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramVerdeelSysteem__TVS_
{
    public partial class formInlog : Form
    {
        DatabaseConnectie db; //voor testknop/plaatje
        Beheersysteem beheersysteem ;
        Admin b;
        Gebruiker gebruiker;
        
        public formInlog()
        {
            InitializeComponent();
            db = new DatabaseConnectie(); //voor testknop/plaatje
            b = new Admin();
        }

        private void Inloggen()
        {
            //controle op inloggegevens
            gebruiker = new Gebruiker();
            try
            {
                if (tbGebruikersnaam.Text != "" && tbWachtwoord.Text != "")
                {
                    if (gebruiker.Inlog(tbGebruikersnaam.Text, tbWachtwoord.Text) == true)
                    {
                        beheersysteem = new Beheersysteem(this);
                        beheersysteem.Show();
                        beheersysteem.FormClosing += beheersysteem_FormClosing;
                        beheersysteem.btUitloggen.Click += btUitloggen_Click;
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Voer de juiste gebruikersnaam en wachtwoord in.", "Foutieve inloggegevens.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show((ex.Message), "Foutieve inloggegevens");
            }
        }


        private void btInloggen_Click(object sender, EventArgs e)
        {
            Inloggen();
        }

        void beheersysteem_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet u zeker dat u dit programma af wilt sluiten?", "Afsluiten", MessageBoxButtons.YesNo);

            if (result != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }

        void btUitloggen_Click(object sender, EventArgs e)
        {
            beheersysteem.Hide();
            this.Show();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Inloggen();
            }
        }

        private void pictureBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                db.OpenConnection();
                MessageBox.Show("Connectie gelukt!");
            }
            catch
            {
                MessageBox.Show("Er ging iets mis met het maken van de connectie met de database!");
            }
            finally
            {
                db.closeConnection();
                MessageBox.Show("De database connectie is weer gesloten!");
            }
        }
    }
}
