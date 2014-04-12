using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public class ButtonAdvanced : Button
    {

        public ButtonAdvanced()
        {
            this.FlatStyle = FlatStyle.Flat;
        }

        public bool Selected { get; private set; }

        public void ToggleSelect()
        {
            if (Selected)
            {
                Select();
            }
            else
            {
                Deselect();
            }
        }

        public void Select()
        {
            Selected = true;
            Reload();
        }

        public void Deselect()
        {
            Selected = false;
            Reload();
        }

        public virtual void Reload()
        {
            
        }
    }
}
