using System;
using System.Collections.Generic;
using System.Linq;
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
                        if (spoornummer == s.Spoornummer && s.BlokkeerStatus == "Vrij")
                        {
                            foreach (Segment seg in s.Segments)
                            {
                                if (seg.BlokkeerStatus == "Vrij")
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
                spoor.ChangeStatus(spoor.BlokkeerStatus == "geblokkeerd" ? "vrij" : "geblokkeerd");
            }
        }
        public void GeefTrams(List<Tram> trams) //extra controle aub!
        { }
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
        public void SimulatieOpvragen()
        { }
        public void SpoorToekennen(Spoor spoor)
        { }
        //Mick
        public Status TramStatusOpvragen(int tramnummer)
        {
            Status status = new Status();
            return status;

        }
        //public void StatusReparatieWijzigen()
        //{ }
        //public void StatusSchoonmaakWijzigen()
        //{ }
        // Niet te lezen in het document
        //
        public void TramOvernemen(Tram tram, Spoor spoor)
        { }
        public void TramPlaatsen(Tram tram, Spoor spoor)
        { }
        public void TramRegistreren(Tram tram)
        { }
        public void TramVerplaatsen(Tram tram, Spoor spoor) // moet GEEN void zijn!
        { }
        public void TramVerwijderen(Tram tram)
        { }
        //public List<Tram> UitrijlijstOpvragen()
        //{ }
    }
}
