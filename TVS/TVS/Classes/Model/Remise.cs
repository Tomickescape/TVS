using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TVS
{
    public class Remise
    {

        private Remise(int id, int nummer)
        {
            Id = id;
            Nummer = nummer;
        }

        public int Id { get; private set; }
        public int Nummer { get; private set; }


        //haal een remise op aan de hand van een ID
        public Remise GetById(int id)
        {
            Remise remise = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM remise WHERE id = :id");
                db.AddParameter("id", id);

                while (db.Read())
                {
                    remise = new Remise(db.GetValueByColumn<int>("id"), db.GetValueByColumn<int>("nummer"));
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

            return remise;
        }

    }
}
