using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TVS
{
    public class ButtonSpoor : ButtonAdvanced
    {

        public ButtonSpoor()
        {
        }
        public int Spoornummer { get; set; }

        public Spoor Spoor
        {
            get
            {
                return Spoor.GetBySpoornummer(Spoornummer);
            }
        }

        public override void Reload()
        {
            Text = Spoor.Nummer.ToString();
            if (Selected)
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.LightSkyBlue;
            }
        }
    }
}