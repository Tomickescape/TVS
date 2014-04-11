using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramVerdeelSysteem__TVS_
{
    class TextBoxSegment : TextBox
    {

        private int segmentnummer;
        private int spoornummer;

        public TextBoxSegment(int segmentnummer, int spoornummer)
        {
            Enabled = false;
            Text = "";

            this.segmentnummer = segmentnummer;
            this.spoornummer = spoornummer;
        }

        public Segment Segment { get; set; }

        public void LoadSegment()
        {
            Segment = TramVerdeelSysteem__TVS_.Segment.GetBySegmentnummerAndSpoornummer(segmentnummer, spoornummer);
            if (Segment != null)
            {
                BackColor = Color.White;

                if (Segment.Special == "permanent")
                {
                    BackColor = Color.Black;
                }
                else if (Segment.Geblokkeerd)
                {
                    BackColor = Color.Gray;
                }

                Text = "";
                if (Segment.Tram != null)
                {
                    Text = Segment.Tram.TramNummer.ToString();
                }
                
            }
            else
            {
                Text = "";
            }
        }

    }
}
