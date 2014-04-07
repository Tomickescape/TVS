using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramVerdeelSysteem__TVS_
{
    class Segment
    {
        private string blokkeerStatus;
        private int segmentnummer;
        private int spoornummer;


        public Segment(string blokkeerStatus, int segmentnummer, int spoornummer)
        {
            this.blokkeerStatus = blokkeerStatus;
            this.segmentnummer = segmentnummer;
            this.spoornummer = spoornummer;
        }

        public int Segmentnummer
        {
            get { return segmentnummer; }
            set{segmentnummer = value;}
        }
        public string BlokkeerStatus
        {
            get { return blokkeerStatus; }
            set { blokkeerStatus = value; }
        }
        public Tram Tram { get; private set; }
    }
}
