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

        private int _nummer;
        private Lijn _lijn;

        public ButtonLijn(int nummer)
        {
            _nummer = nummer;
        }

        public Lijn Lijn
        {
            get
            {
                return Lijn.GetByNummer(_nummer);
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
