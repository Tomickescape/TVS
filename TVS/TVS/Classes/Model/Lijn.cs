using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TVS
{
    public class Lijn
    {

        private Lijn(int id, int nummer)
        {
            Id = id;
            Nummer = nummer;
        }

        public int Id { get; private set; }
        public int Nummer { get; private set; }

        //Haal de gegevens op aan de hand van het IDnummer en geeft een instantie van die lijn terug.
        public Lijn GetById(int id)
        {
            Lijn lijn = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM lijn WHERE id = :id");
                db.AddParameter("id", id);

                while (db.Read())
                {
                    lijn = new Lijn(db.GetValueByColumn<int>("id"), db.GetValueByColumn<int>("nummer"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }

            return lijn;
        }

        //Haal de gegevens op aan de hand van het lijnnummer en geeft een instantie van die lijn terug.

        public Lijn GetByNummer(int nummer)
        {
            Lijn lijn = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM lijn WHERE nummer = :nummer");
                db.AddParameter("nummer", nummer);

                while (db.Read())
                {
                    lijn = new Lijn(db.GetValueByColumn<int>("id"), db.GetValueByColumn<int>("nummer"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }

            return lijn;
        }
    }
}
