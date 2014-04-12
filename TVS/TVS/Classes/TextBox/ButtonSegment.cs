using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public class ButtonSegment : ButtonAdvanced
    {

        private int _segmentnummer;
        private int _spoornummer;

        public ButtonSegment(int segmentnummer, int spoornummer)
        {
            _segmentnummer = segmentnummer;
            _spoornummer = spoornummer;
        }

        public Segment Segment
        {
            get
            {
                return Segment.GetBySegmentnummerAndSpoornummer(_segmentnummer, _spoornummer);
            }
            set
            {
                // Doet niks omdat designer dom doet.
            }
        }

        public override void Reload()
        {
            if (Segment != null)
            {
                if (Selected)
                {
                    BackColor = Color.Blue;
                }
                else if (Segment.Special == "permanent")
                {
                    BackColor = Color.Black;
                }
                else if (Segment.Geblokkeerd)
                {
                    BackColor = Color.Gray;
                }
                else
                {
                    BackColor = Color.White;
                }

                if (Segment.Tram != null)
                {
                    Text = Segment.Tram.Nummer.ToString();
                }
                else
                {
                    Text = "";
                }
            }
        }

    }
}
