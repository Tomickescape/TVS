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

        public ButtonSegment()
        {
        }

        public int Spoornummer { get; set; }
        public int Segmentnummer { get; set; }

        public Segment Segment
        {
            get
            {
                return Segment.GetBySpoornummerAndSegmentnummer(Spoornummer, Segmentnummer);
            }
        }

        public override void Reload()
        {
            if (Segment != null)
            {
                //veranderd de kleur van knoppen met verschillende statussen
                if (Selected)
                {
                    BackColor = Color.Blue;
                }
                else if (Segment.Geblokkeerd)
                {
                    BackColor = Color.Gray;
                }
                else if (Segment.Special == "permanent")
                {
                    BackColor = Color.Black;
                }
                else if (Segment.Special == "uitrijding")
                {
                    BackColor = Color.DarkGray;
                }
                else
                {
                    BackColor = Color.White;
                }

                //voegt het tramnummer in als text als dit segment een gevulde property heeft
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
