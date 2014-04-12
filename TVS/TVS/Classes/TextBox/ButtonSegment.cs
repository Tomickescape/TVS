﻿using System;
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

        public int Segmentnummer { get; set; }
        public int Spoornummer { get; set; }

        public Segment Segment
        {
            get
            {
                return Segment.GetBySegmentnummerAndSpoornummer(Segmentnummer, Spoornummer);
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
