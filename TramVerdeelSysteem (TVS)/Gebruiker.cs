using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramVerdeelSysteem__TVS_
{
    class Gebruiker
    {
        DatabaseConnectie db;
        
        public bool Inlog(string gebruikersnaam, string wachtwoord)
        {
            db = new DatabaseConnectie();
            if (db.Inlog(gebruikersnaam, wachtwoord) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
    }
}
