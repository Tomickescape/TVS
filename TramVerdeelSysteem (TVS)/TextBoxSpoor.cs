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
        private Spoor spoor;
        private int spoornummer;

     //   public TextBoxSpoor(int segmentnummer, int spoornummer)
        public TextBoxSpoor(int spoornummer)
        {
            this.TextChanged += TextBoxSpoor_TextChanged;

 //           this.segmentnummer = segmentnummer;
            this.spoornummer = spoornummer;

            LoadSpoor();
        }

        void TextBoxSpoor_TextChanged(object sender, EventArgs e)
        {
            SaveSpoor();
        }

        public void LoadSpoor()
        {
            spoor = DatabaseConnectie.GetSpoorBySpoornummer(spoornummer);
            if (spoor != null)
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