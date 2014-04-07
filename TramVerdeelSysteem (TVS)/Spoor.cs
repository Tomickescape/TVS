using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramVerdeelSysteem__TVS_
{
    class Spoor
    {
        private string blokkeerStatus;
        private int spoornummer;
        private  List<Segment> segmenten;
    
        public Spoor(string Blokkeerstatus ,int spoornummer)
        {
            this.blokkeerStatus = BlokkeerStatus;
            this.spoornummer = spoornummer;
            List<Segment> segmenten = DatabaseConnectie.GetBySegmentBySpoornummer(spoornummer);
        }

        public List<Segment> Segmenten
        {
            get { return segmenten; }
            set { segmenten = value; }
        }
        public string BlokkeerStatus
        {
            get { return blokkeerStatus; }
            set { blokkeerStatus = value; }
        }
        public int Spoornummer
    {
        get { return spoornummer;}
        set { spoornummer = value; }
    }
    }
}
