using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public class TextBoxSegment : TextBox
    {

        private int _segmentnummer;
        private int _spoornummer;
        private Segment _segment;

        public TextBoxSegment(int segmentnummer, int spoornummer)
        {
            Enabled = false;
            Text = "";

            _segmentnummer = segmentnummer;
            _spoornummer = spoornummer;

            Reload();
        }

        public Segment Segment
        {
            get
            {
                if (_segment == null)
                {
                    _segment = Segment.GetBySegmentnummerAndSpoornummer(_segmentnummer, _spoornummer);
                }
                return _segment;
            }
            set
            {
                // Doet niks omdat designer dom doet.
            }
        }

        public void Reload()
        {
            if (Segment.Special == "permanent")
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
