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
        }

        private void Inloggen()
        {
            Database db = new Database();
            try
            {
                string gebruikersnaam = tbGebruikersnaam.Text.Trim().ToLower();
                string wachtwoord = tbWachtwoord.Text.Trim();

                if (gebruikersnaam.Length <= 0 || wachtwoord.Length <= 0)
                {
                    throw new Exception("Gebruikersnaam en wachtwoord zijn onbekend.");
                }

                db.CreateCommand("SELECT * FROM gebruiker WHERE gebruikersnaam = :gebruikersnaam AND wachtwoord = :wachtwoord");
                db.AddParameter("gebruikersnaam", gebruikersnaam);
                db.AddParameter("wachtwoord", wachtwoord);

                if (db.Read())
                {
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
                System.Diagnostics.Debug.WriteLine(ex.Source + "\r\n" + ex.Message);
                //MessageBox.Show(ex.Message);
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
            formMain.Hide();
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
            /*
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
             */
        }
    }
}
