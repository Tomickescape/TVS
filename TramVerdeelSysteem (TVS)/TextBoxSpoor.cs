using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TramVerdeelSysteem__TVS_
{
    class TextBoxSpoor : TextBox
    {

        private bool spoorLoaded = false;
        private Spoor spoor;

        public TextBoxSpoor(int spoornummer)
        {
            Spoornummer = spoornummer;
            Enabled = false;
            LoadSpoor();
        }

        public int Spoornummer { get; set; }

        public Spoor Spoor
        {
            get
            {
                if (!spoorLoaded)
                {
                    spoor = Spoor.GetBySpoornummer(Spoornummer);
                    spoorLoaded = true;
                }
                return spoor;
            }
            set { spoor = value; }
        }

        public void LoadSpoor()
        {
            Text = Spoor.Spoornummer.ToString();
        }

        public void SaveSpoor()
        {
        }

    }
}