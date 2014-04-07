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
        private Segment segment;

        private int segmentnummer;
        private int spoornummer;

        public TextBoxSegment(int segmentnummer, int spoornummer)
        {
            this.TextChanged += TextBoxSegment_TextChanged;

            this.segmentnummer = segmentnummer;
            this.spoornummer = spoornummer;

            LoadSegment();
        }

        void TextBoxSegment_TextChanged(object sender, EventArgs e)
        {
            SaveSegment();
        }

        public void LoadSegment()
        {
            segment = Segment.GetBySegmentnummerAndSpoornummer(segmentnummer, spoornummer);
            if (segment != null)
            {
                if (segment.BlokkeerStatus.ToLower() == "geblokkeerd")
                {
                    Enabled = false;
                }
                else
                {
                    Enabled = true;
                }
                Text = "";
            }
            else
            {
                Text = "";
            }
        }

        public void SaveSegment()
        {
        }

    }
}
