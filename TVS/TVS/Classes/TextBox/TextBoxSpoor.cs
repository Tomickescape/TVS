using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TVS
{
    public class TextBoxSpoor : TextBox
    {
        private Spoor _spoor;
        private int _spoornummer;

        public TextBoxSpoor(int spoornummer)
        {
            _spoornummer = spoornummer;
            
            Enabled = false;
            Text = Spoor.Nummer.ToString();
        }

        public Spoor Spoor
        {
            get
            {
                if (_spoor == null)
                {
                    _spoor = Spoor.GetBySpoornummer(_spoornummer);
                }
                return _spoor;
            }
        }

    }
}