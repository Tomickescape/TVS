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
            this.TextChanged += TextBoxSpoor_TextChanged;
            Spoornummer = spoornummer;

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

        void TextBoxSpoor_TextChanged(object sender, EventArgs e)
        {
            SaveSpoor();
        }

        public void LoadSpoor()
        {
            return;
            if (Spoor != null)
            {
                if (spoor.BlokkeerStatus.ToLower() == "geblokkeerd")
                {
                    Enabled = false;
                }
                else
                {
                    Enabled = true;
                }
            }
            else
            {
                Text = "";
            }
        }

        public void SaveSpoor()
        {
        }

    }
}