using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{

    public partial class FormMain : Form
    {
        private Timer _simulationTimer = new Timer();
        private ButtonAdvanced _buttonAdvancedSelected = null;

        public FormMain()
        {
            InitializeComponent();

            foreach (ButtonAdvanced tb in GetAllButtonAdvanced())
            {
                tb.Click += buttonAdvanced_Click;
            }

            _simulationTimer.Tick += _simulationTimer_Tick;
            _simulationTimer.Interval = 100;

            RefreshInterface();
        }

        private Segment EerstePlekOpSpoorVoorTram(Spoor spoor, Tram tram)
        {
            Segment eersteSegment = null;

            foreach (Segment segment in spoor.Segments)
            {
                if (!segment.Geblokkeerd && segment.Special != "permanent" && segment.CheckUitrij())
                {
                    if (segment.Tram == null || (segment.Tram.Id == tram.Id))
                    {
                        if (eersteSegment == null || segment.Nummer < eersteSegment.Nummer)
                        {
                            eersteSegment = segment;
                        }
                    }
                }
            }
            return eersteSegment;
        }

        void _simulationTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            try
            {
                Segment selectedSegment = null;
                List<Tram> trams = Tram.GetAll().FindAll(x => x.Segment == null);
                if (trams.Count > 0)
                {

                    Tram tram = null;

                    foreach (ListViewItem item in listViewReservations.Items)
                    {
                        foreach (Tram subTram in trams)
                        {
                            if (item.SubItems[0].Text == subTram.Nummer.ToString())
                            {
                                tram = subTram;
                                selectedSegment = EerstePlekOpSpoorVoorTram(Spoor.GetBySpoornummer(int.Parse(item.SubItems[1].Text)), tram);
                                item.Remove();
                            }
                        }
                    }

                    if (tram == null)
                    {
                        tram = trams[rand.Next(trams.Count - 1)];
                    }
                    List<ButtonSpoor> buttons = GetAllButtonAdvanced().FindAll(x => x is ButtonSpoor).Cast<ButtonSpoor>().ToList();


                    while (selectedSegment == null)
                    {
                        if (buttons.Count == 0)
                        {
                            throw new Exception("Geen plekken beschikbaar.");
                        }

                        int buttonIndex = rand.Next(buttons.Count - 1);

                        selectedSegment = EerstePlekOpSpoorVoorTram(buttons[buttonIndex].Spoor, tram);

                        buttons.RemoveAt(buttonIndex);
                    }

                    selectedSegment.ChangeTram(tram);
                    RefreshInterface();
                }
                else
                {
                    throw new Exception("Geen trams beschikbaar.");
                }
            }
            catch (Exception ex)
            {
                _simulationTimer.Stop();
                RefreshInterface();
                MessageBox.Show(ex.Message);
            }

        }

        private List<ButtonAdvanced> GetAllButtonAdvanced()
        {
            List<ButtonAdvanced> list = new List<ButtonAdvanced>();
            foreach (Control control in Controls)
            {
                ButtonAdvanced tb = control as ButtonAdvanced;
                if (tb != null)
                {
                    list.Add(tb);
                }
            }
            return list;
        }

        private void RefreshInterface()
        {
            if (!_simulationTimer.Enabled)
            {
                buttonRunSimulation.Text = "Start simulatie";
            }
            else
            {
                buttonRunSimulation.Text = "Stop simulatie";
            }

            foreach (ButtonAdvanced buttonAdvanced in GetAllButtonAdvanced())
            {
                buttonAdvanced.Reload();
            }
        }

        void buttonAdvanced_Click(object sender, EventArgs e)
        {
            if (_buttonAdvancedSelected != null)
            {
                _buttonAdvancedSelected.Deselect();
            }
            ButtonAdvanced tb = sender as ButtonAdvanced;
            if (tb != null)
            {
                if (tb != _buttonAdvancedSelected)
                {
                    tb.Select();
                }
                else
                {
                    tb = null;
                }

            }
            _buttonAdvancedSelected = tb;
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (_buttonAdvancedSelected == null)
                {
                    throw new Exception("Geen spoor geselecteerd.");
                }

                if (_buttonAdvancedSelected is ButtonSegment)
                {
                    ((ButtonSegment)_buttonAdvancedSelected).Segment.ToggleGeblokkeerd();
                }
                else if (_buttonAdvancedSelected is ButtonSpoor)
                {
                    ((ButtonSpoor)_buttonAdvancedSelected).Spoor.ToggleGeblokkeerd();
                    
                }
                RefreshInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonPlaceTram_Click(object sender, EventArgs e)
        {
            try
            {
                if (_buttonAdvancedSelected == null || (!(_buttonAdvancedSelected is ButtonSegment) && !(_buttonAdvancedSelected is ButtonSpoor)))
                {
                    throw new Exception("Geen spoor of segment geselecteerd.");
                }

                int tramNummer;
                int.TryParse(textBoxTramNummer.Text.Trim(), out tramNummer);

                Tram tram = Tram.GetByNummer(tramNummer);
                if (tram == null) 
                {
                    throw new Exception("Tram niet gevonden.");
                }

                if(_buttonAdvancedSelected is ButtonSegment) 
                {                    
                    ButtonSegment buttonSegment = (ButtonSegment)_buttonAdvancedSelected;
                    if (buttonSegment.Segment.Geblokkeerd) 
                    {
                        throw new Exception("Segment is geblokkeerd.");
                    }
                    if (buttonSegment.Segment.Special == "permanent")
                    {
                        throw new Exception("Segment is permanent dicht.");
                    }

                    if (!buttonSegment.Segment.CheckUitrij())
                    {
                        throw new Exception("Segment is uitrij en is momenteel geblokkeerd.");
                    }

                    buttonSegment.Segment.ChangeTram(tram);
                }
                else 
                {
                    ButtonSpoor buttonSpoor = (ButtonSpoor)_buttonAdvancedSelected;
                    if (buttonSpoor.Spoor.Geblokkeerd)
                    {
                        throw new Exception("Spoor is geblokkeerd.");
                    }

                    Segment firstSegmentOnSpoorAvailable = EerstePlekOpSpoorVoorTram(buttonSpoor.Spoor, tram);

                    if (firstSegmentOnSpoorAvailable == null) 
                    {
                        throw new Exception("Geen segmenten beschikbaar.");
                    }

                    firstSegmentOnSpoorAvailable.ChangeTram(tram);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            RefreshInterface();
        }

        private void buttonTramOverview_Click(object sender, EventArgs e)
        {
            FormTramsOverzicht overview = new FormTramsOverzicht();
            overview.Show();
            overview.FormClosed += overview_FormClosed;
        }

        void overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshInterface();
        }

        private void buttonRunSimulation_Click(object sender, EventArgs e)
        {
            _simulationTimer.Enabled = !_simulationTimer.Enabled;
        }

        private void buttonReservateTram_Click(object sender, EventArgs e)
        {
            try
            {
                int tramnummer;
                int.TryParse(textBoxTramNummer.Text.Trim(), out tramnummer);

                Tram tram = Tram.GetByNummer(tramnummer);
                if (tram == null)
                {
                    throw new Exception("Tram niet gevonden.");
                }

                if (tram.Segment != null)
                {
                    throw new Exception("Tram is al geplaatst.");
                }

                if (!(_buttonAdvancedSelected is ButtonSpoor))
                {
                    throw new Exception("Geen spoor geselecteerd.");
                }

                Spoor spoor = ((ButtonSpoor) _buttonAdvancedSelected).Spoor;

                foreach (ListViewItem subItem in listViewReservations.Items)
                {
                    if (subItem.SubItems[0].Text == tram.Nummer.ToString())
                    {
                        throw new Exception("Tram is al gereserveerd.");
                    }
                }

                ListViewItem item = new ListViewItem(tram.Nummer.ToString());
                item.SubItems.Add(spoor.Nummer.ToString());
                listViewReservations.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewReservations_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.Remove();
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("UPDATE tram SET segment_id = 0");
                db.Execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }
            RefreshInterface();
        }
    }
}