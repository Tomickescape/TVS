using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public class ButtonLijn : ButtonAdvanced
    {
        public ButtonLijn()
        {
        }

        public int Nummer { get; set; }

        public Lijn Lijn
        {
            get
            {
                return Lijn.GetByNummer(Nummer);
            }
        }

        public override void Reload()
        {
            if (Selected)
            {
                BackColor = Color.Blue;
            }
            Text = Lijn.Nummer.ToString();
        }

    }
}
