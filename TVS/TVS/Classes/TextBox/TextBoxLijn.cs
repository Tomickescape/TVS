using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public class TextBoxLijn : TextBox
    {

        private int _nummer;
        private Lijn _lijn;

        public TextBoxLijn()
        {
            Enabled = false;
            Text = Lijn.Nummer.ToString();
        }

        public Lijn Lijn
        {
            get
            {
                if (_lijn == null)
                {
                    _lijn = Lijn.GetByNummer(_nummer);
                }
                return _lijn;
            }
        }

    }
}
