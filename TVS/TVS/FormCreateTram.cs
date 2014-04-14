using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    public partial class FormCreateTram : Form
    {
        public FormCreateTram()
        {
            InitializeComponent();

            comboBoxType.SelectedIndex = 0;
            comboBoxStatus.Items.AddRange(Enum.GetNames(typeof(Status)));
            comboBoxStatus.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string type;
            int nummer;
            Status status;
            string rfid;

            type = comboBoxType.Text;
            int.TryParse(textBoxNummer.Text.Trim(), out nummer);
            Enum.TryParse(comboBoxStatus.Text, out status);
            rfid = textBoxRfid.Text.Trim();

            try
            {
                MessageBox.Show(type);
                if (type.Length == 0)
                {
                    throw new Exception("Geen type geselecteerd.");
                }

                if (nummer <= 0)
                {
                    throw new Exception("Nummer moet boven 0 zijn.");
                }

                Tram.Insert(type, nummer, status, rfid);

                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
