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
        private int _spoornummer;

        public ButtonSpoor(int spoornummer)
        {
            _spoornummer = spoornummer;
        }

        public Spoor Spoor
        {
            get
            {
                return Spoor.GetBySpoornummer(_spoornummer);
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