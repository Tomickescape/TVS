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

        //zet de knop op wel of niet geselecteerd
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
        //methode is nodig en word ergens anders geoverride
        public virtual void Reload()
        {
            
        }
    }
}
