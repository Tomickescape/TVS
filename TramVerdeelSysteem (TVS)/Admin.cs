using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramVerdeelSysteem__TVS_
{
    class Admin
    {
        List<Spoor> sporen;
        List<Segment> segmenten;

        List<Tram> trams;
        //Mick
        public Admin()
        {
            sporen = new List<Spoor>();
            trams = new List<Tram>();
            segmenten = new List<Segment>();
        }


        public Boolean ZetTramOpSpoor(int tramnummer, int spoornummer)
        {
            foreach (Tram t in trams)
            {
                if (tramnummer == t.Tramnummer)
                {
                    foreach (Spoor s in sporen)
                    {
                        if (spoornummer == s.Spoornummer && !s.Geblokkeerd)
                        {
                            foreach (Segment seg in s.Segments)
                            {
                                if (!seg.Geblokkeerd)
                                {
                                    t.Spoornummer = spoornummer;
                                    t.Segmentnummer = seg.Segmentnummer;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        // (de-)blokkeerd het meegegeven spoor en daaronder liggende segmenten
        public void BlokkeringStatusWijzigen(int spoornummer)
        {
            Spoor spoor = Spoor.GetBySpoornummer(spoornummer);
            if (spoor != null)
            {
                spoor.ChangeStatus(!spoor.Geblokkeerd);
            }
        }

        public void GeefTrams(List<Tram> trams) //extra controle aub!
        {
        //    //laat alle trams zien die er bestaan in een nieuwe form
        //    foreach (Tram t in trams)
        //    {
        //        return t.
        //    }

        }

        public void SimulatieOpvragen()
        {
            
        }

        public void SpoorToekennen(Spoor spoor)
        {
            
        }
        
        public Status TramStatusOpvragen(int tramnummer)
        {
            Status status = new Status();
            return status;
        }

        public void TramOvernemen(Tram tram, Spoor spoor)
        {
            
        }

        public void TramPlaatsen(Tram tram, Spoor spoor)
        {
            
        }

        public void TramRegistreren(Tram tram)
        {
            
        }

        public void TramVerplaatsen(Tram tram, Spoor spoor) // moet GEEN void zijn!
        {
            
        }

        public void TramVerwijderen(Tram tram)
        { }
        //public List<Tram> UitrijlijstOpvragen()
        //{ }


        ////De RFID wordt gescant en geeft de RFID code door aan de onderstaande methode
        //public void RFIDTramPlaatsen(string RFIDValue)
        //{
            
        //    foreach (Tram t in trams)
        //    {
        //        if (t.RFIDCode == RFIDValue)
        //        {
        //            if ()
        //            {
                        
        //            }
        //        }
        //    }
        //}


        //In deze methode moet de tram willekeurig geplaatst kunnen worden op een spoor die
        //- Niet geblokkeerd is
        //public void KijkOfSpoorBeschikbaarIs()
        //{
        //    //Zorgen dat een willekeurige textbox wordt gepakt
        //    Random random = new Random();
        //    random.Next(TextBoxSegment)
        //    //Hier moet een if komen om te kijken of een 
        //    if (TextBoxSegment.)
        //    {
                
        //    }
        //}

        //public ServiceBeurt ServiceBijhouden()
        //{ }
        //public SchoonmaakBeurt SchoonmaakBijhouden()
        //{ }
        //public List<Reparatie> ReparatielijstOpvragen()
        //{ }
        //public List<Schoonmaak> SchoonmaaklijstOpvragen()
        //{ }
        //public int SegmentOpvragen(int segment)
        //{ }
        //public void StatusReparatieWijzigen()
        //{ }
        //public void StatusSchoonmaakWijzigen()
        //{ }
        // Niet te lezen in het document
        //
    }
}
