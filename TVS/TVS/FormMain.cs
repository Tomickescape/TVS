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
using Phidgets;
using Phidgets.Events;
using System.IO;

namespace TVS
{

    public partial class FormMain : Form
    {
        private FormTramsOverzicht _formTramsOverzicht = null;
        private Timer _simulationTimer = new Timer();
        private ButtonAdvanced _buttonAdvancedSelected = null;
        string gescandeRFIDCode;
        private RFID rfid;
        
        public FormMain()
        {
            InitializeComponent();
            RFIDInitialize();

            
            foreach (ButtonAdvanced tb in GetAllButtonAdvanced())
            {
                tb.Click += buttonAdvanced_Click;
            }

            _simulationTimer.Tick += _simulationTimer_Tick;
            _simulationTimer.Interval = 3000;

            RefreshInterface();

            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();  //auto dinges snap ik helemaal niet
            foreach (Tram tram in Tram.GetAll())
            {
                strings.Add(tram.Nummer.ToString());  //nummer.tostring = alleen het nummer?
            }
            textBoxTramNummer.AutoCompleteCustomSource = strings;
        }

        private void Output(string text)
        {
            labelOutput.Text = text;
        }

        private void Output(Exception ex)
        {
            Output(ex.Message);
        }

        private void PlaceTram(Segment segment, Tram tram)
        {
            foreach (ListViewItem item in listViewReservations.Items)
            {
                if (item.SubItems[0].Text == tram.Nummer.ToString())
                {
                    item.Remove();
                }
            }

            Output("Tram: " + tram.Nummer + "(" + tram.Type + ") op " + segment.Spoor.Nummer + " . " + segment.Nummer);
            segment.ChangeTram(tram);
            RefreshInterface();
        }
        //start de simulatie
        private void EnableTimer()
        {
            buttonRunSimulation.Text = "Stop simulatie";
            _simulationTimer.Enabled = true;
        }
        //stopt de simulatie
        private void DisableTimer()
        {
            buttonRunSimulation.Text = "Start simulatie";
            _simulationTimer.Enabled = false;
        }

        //de methode van de timer die elke 3 seconde worden aangeroepen
        void _simulationTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random(); // nodige om de trams willekeurige uit de database te laden
            try
            {
                Segment selectedSegment = null;
                List<Tram> trams = Tram.GetAll().FindAll(x => x.Segment == null); //? achter de getall methode   //zolang er nog een segment leeg is?
                if (trams.Count > 0) //als de lijst van trams leeg is
                {

                    Tram tram = null; 

                    foreach (ListViewItem item in listViewReservations.Items)  //listviewreservation?
                    {
                        foreach (Tram subTram in trams) //voor elke tram in de opgehaalde lijst
                        {
                            if (item.SubItems[0].Text == subTram.Nummer.ToString())
                            {
                                tram = subTram;
                                selectedSegment = Spoor.GetBySpoornummer(int.Parse(item.SubItems[1].Text)).FirstSegmentAvailableForTram(tram);
                            }
                        }
                        if (selectedSegment == null)
                        {
                            item.Remove();
                        }
                    }

                    if (tram == null)
                    {
                        tram = trams[rand.Next(trams.Count - 1)]; //?
                    }

                    List<ButtonSpoor> buttons = GetAllButtonAdvanced().FindAll(x => x is ButtonSpoor).Cast<ButtonSpoor>().ToList();  //?
                    selectedSegment = GetRandomSegment(buttons, tram);

                    if (selectedSegment == null) 
                    {

                        throw new Exception("Geen plekken beschikbaar.");
                    }
                    PlaceTram(selectedSegment, tram);
                }
                else
                {
                    throw new Exception("Geen trams beschikbaar.");
                }
            }
            catch (Exception ex) // als er iets mis gaat, zet de timer uit en laat de foutmelding zien
            {
                DisableTimer();
                Output(ex);
            }

        }

        //?
        private Segment GetRandomSegment(List<ButtonSpoor> buttons, Tram tram)
        {
            Segment selectedSegment = null;
            Random rand = new Random();

            if (tram.Lijnen.Count > 0)
            {
                foreach (ButtonSpoor button in new List<ButtonSpoor>(buttons))
                {
                    Spoor spoor = button.Spoor;
                    if (tram.Lijnen.Find(x => x == spoor.Lijnnummer1) == 0 &&
                        tram.Lijnen.Find(x => x == spoor.Lijnnummer2) == 0)
                    {
                        buttons.Remove(button);
                    }
                }
            }

            while (selectedSegment == null)
            {
                if (buttons.Count == 0)
                {
                    return null;
                }

                int buttonIndex = rand.Next(buttons.Count - 1);

                selectedSegment = buttons[buttonIndex].Spoor.FirstSegmentAvailableForTram(tram);

                buttons.RemoveAt(buttonIndex);
            }

            return selectedSegment;
        }

        private List<ButtonAdvanced> GetAllButtonAdvanced()
        {
            List<ButtonAdvanced> list = new List<ButtonAdvanced>();
            foreach (Control control in Controls) // wat is een control collectie?
            {
                ButtonAdvanced tb = control as ButtonAdvanced;
                if (tb != null)
                {
                    list.Add(tb);
                }
            }
            return list;
        }

        //refresh de buttons statussen
        private void RefreshInterface()
        {
            foreach (ButtonAdvanced buttonAdvanced in GetAllButtonAdvanced())
            {
                buttonAdvanced.Reload();
            }
        }
        //
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
                if (_buttonAdvancedSelected == null || (!(_buttonAdvancedSelected is ButtonSegment) && !(_buttonAdvancedSelected is ButtonSpoor)))
                {
                    throw new Exception("Geen spoor of segment geselecteerd.");
                }

                Segment segmentSelected = null;

                if (_buttonAdvancedSelected is ButtonSegment)
                {
                    segmentSelected = ((ButtonSegment)_buttonAdvancedSelected).Segment;
                }
                else if (_buttonAdvancedSelected is ButtonSpoor)
                {
                    Spoor spoor = ((ButtonSpoor) _buttonAdvancedSelected).Spoor;

                    foreach (Segment segment in spoor.Segments)
                    {
                        if (segmentSelected == null || segment.Nummer > segmentSelected.Nummer)
                        {
                            segmentSelected = segment;
                        }
                    }
                }
                    
                segmentSelected.ToggleGeblokkeerd();

                RefreshInterface();
            }
            catch (Exception ex)
            {
                Output(ex);
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
                    Segment segment = ((ButtonSegment)_buttonAdvancedSelected).Segment;

                    if (tram.Lijnen.Count > 0)
                    {
                        Spoor spoor = segment.Spoor;
                        if (tram.Lijnen.Find(x => x == spoor.Lijnnummer1) == 0 &&
                            tram.Lijnen.Find(x => x == spoor.Lijnnummer2) == 0)
                        {
                            throw new Exception(tram.Type + " mag niet op dit spoor.");
                        }
                    }

                    if (segment.Geblokkeerd) 
                    {
                        throw new Exception("Segment is geblokkeerd.");
                    }
                    if (segment.Special == "permanent")
                    {
                        throw new Exception("Segment is permanent dicht.");
                    }

                    if (!segment.CheckUitrij(tram))
                    {
                        throw new Exception("Segment is uitrij en is momenteel geblokkeerd.");
                    }

                    PlaceTram(segment, tram);
                    if (segment.Nummer > 1)
                    {
                        foreach (Segment forSegment in segment.Spoor.Segments)
                        {
                            if (forSegment.Nummer < segment.Nummer && forSegment.Tram == null)
                            {
                                forSegment.ChangeGeblokkeerd(true);
                            }
                        }   
                        RefreshInterface();
                    }
                }
                else 
                {
                    ButtonSpoor buttonSpoor = (ButtonSpoor)_buttonAdvancedSelected; 
                    
                    if (tram.Lijnen.Count > 0)
                    {
                        Spoor spoor = buttonSpoor.Spoor;
                        if (tram.Lijnen.Find(x => x == spoor.Lijnnummer1) == 0 &&
                            tram.Lijnen.Find(x => x == spoor.Lijnnummer2) == 0)
                        {
                            throw new Exception(tram.Type + " mag niet op dit spoor.");
                        }
                    }
                    if (buttonSpoor.Spoor.Geblokkeerd)
                    {
                        throw new Exception("Spoor is geblokkeerd.");
                    }

                    Segment firstSegmentOnSpoorAvailable = buttonSpoor.Spoor.FirstSegmentAvailableForTram(tram);

                    if (firstSegmentOnSpoorAvailable == null) 
                    {
                        throw new Exception("Geen segmenten beschikbaar.");
                    }

                    PlaceTram(firstSegmentOnSpoorAvailable, tram);
                }
            }
            catch (Exception ex)
            {
                Output(ex);
            }
        }

        //laat een lijst met trams zien in een nieuw form
        private void buttonTramOverview_Click(object sender, EventArgs e)
        {
            _formTramsOverzicht = new FormTramsOverzicht();
            _formTramsOverzicht.Show();
            _formTramsOverzicht.FormClosed += overview_FormClosed;
        }

        //herlaad de interface 
        void overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listViewReservations.Items.Count > 0)
            {
                foreach (ListViewItem item in listViewReservations.Items)
                {
                    if (Tram.GetByNummer(int.Parse(item.SubItems[0].Text)) == null)
                    {
                        item.Remove();
                    }
                }
            }

            Output("Overzicht gesloten.");
            RefreshInterface();
        }

        //start de simulatie
        private void buttonRunSimulation_Click(object sender, EventArgs e)
        {
            Output("Simulatie gestart.");
            if (_simulationTimer.Enabled)
            {
                DisableTimer();
            }
            else
            {
                EnableTimer();
            }
        }
        //reserve een tram
        private void buttonReservateTram_Click(object sender, EventArgs e)
        {
            try
            {
                int tramnummer;
                int.TryParse(textBoxTramNummer.Text.Trim(), out tramnummer); // probeer van de tekst een integer te maken  //wordt niet gecatched? 

                Tram tram = Tram.GetByNummer(tramnummer);
                if (tram == null) // tram bestaat niet, getbynumber heeft dus geen tram kunnen retourneren
                {
                    throw new Exception("Tram niet gevonden.");
                }

                if (tram.Segment != null) // het segmentveld van de tram is al ingevuld en dus als geplaatst
                {
                    throw new Exception("Tram is al geplaatst.");
                }


                if (!(_buttonAdvancedSelected is ButtonSpoor) && !(_buttonAdvancedSelected is ButtonSegment)) //als er geen button of segment geselecteerd is
                {
                    throw new Exception("Geen spoor of segment geselecteerd.");
                }

                Spoor spoor = null;
                if (_buttonAdvancedSelected is ButtonSegment) // als er een segment selecteerd is
                {
                    spoor = ((ButtonSegment) _buttonAdvancedSelected).Segment.Spoor; //?
                }
                else
                {
                    spoor = ((ButtonSpoor)_buttonAdvancedSelected).Spoor;
                }

                if (tram.Lijnen.Count > 0) //als de lijnen van deze tram groter dan 0 is
                {
                    if (tram.Lijnen.Find(x => x == spoor.Lijnnummer1) == 0 &&
                        tram.Lijnen.Find(x => x == spoor.Lijnnummer2) == 0) //?
                    {
                        throw new Exception(tram.Type + " mag niet op dit spoor.");
                    }
                }

                foreach (ListViewItem subItem in listViewReservations.Items) //wederom listviewitems?
                {
                    if (subItem.SubItems[0].Text == tram.Nummer.ToString())
                    {
                        throw new Exception("Tram is al gereserveerd.");
                    }
                }

                ListViewItem item = new ListViewItem(tram.Nummer.ToString());
                item.SubItems.Add(spoor.Nummer.ToString()); //?
                listViewReservations.Items.Add(item);
            }
            catch (Exception ex)
            {
                Output(ex);
            }
        }
        //verwijder de reservering zodra deze aangelkikt word
        private void listViewReservations_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                e.Item.Remove();
            }
        }

        //maak alle velden leeg
        private void buttonClean_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("UPDATE tram SET segment_id = 0"); // zet de segment waarden van de trams op 0 //moet dit niet null zijjn?
                db.Execute();

                Output("Alles schoongemaakt.");
            }
            catch (Exception ex)
            {
                Output(ex.Message);
            }
            finally
            {
                db.Close();
            }
            RefreshInterface();
        }
        
        //maak het geselecteerde segment leeg
        private void buttonRemoveTram_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_buttonAdvancedSelected is ButtonSegment)) // geef een melding als er geen segment aangeklikt is
                {
                    throw new Exception("Geen segment geselecteerd");
                }

                ButtonSegment buttonSegment = _buttonAdvancedSelected as ButtonSegment;
                Output("Tram verwijderd van " + buttonSegment.Segment.Spoor.Nummer + ", " + buttonSegment.Segment.Nummer);
                buttonSegment.Segment.ChangeTram(null);
                RefreshInterface();
            }
            catch (Exception ex)
            {
                Output(ex);
            }
            
        }
        //RFID

        //de standaard waarden van de RFID reader
        public void RFIDInitialize()
        {
            rfid = new RFID();
            rfid.open();
            rfid.waitForAttachment();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.Antenna = true;
            rfid.LED = true;
            LBL_RFID.ForeColor = Color.Transparent;
            LBL_RFID.BackColor = Color.Lime;

        }

        public void rfid_Attach(object sender, AttachEventArgs e)
        {

            RFID atached = (RFID)sender;
            LBL_RFID.BackColor = Color.Lime;
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.Antenna = true;
            rfid.LED = true;
        }

        public void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
            LBL_RFID.BackColor = Color.Red;
        }
        public void rfid_Tag(object sender, TagEventArgs e)
        {
            gescandeRFIDCode = e.Tag.ToString();

            try
            {
                Tram tram = Tram.GetByRfid(gescandeRFIDCode);
                if (tram == null)
                {
                    throw new Exception("Tram niet gevonden.");
                }

                if (tram.Segment == null)
                {
                    List<ButtonSpoor> buttons =
                        GetAllButtonAdvanced().FindAll(x => x is ButtonSpoor).Cast<ButtonSpoor>().ToList();
                    Segment segment = GetRandomSegment(buttons, tram);

                    if (segment == null)
                    {
                        throw new Exception("Geen beschikbare segment gevonden.");
                    }

                    PlaceTram(segment, tram);
                }
                else
                {
                    tram.ChangeSegment(null);
                    Output("Tram " + tram.Nummer + "(" + tram.Type + ") afgemeld.");
                    RefreshInterface();
                }
            }
            catch (Exception ex)
            {
                Output(ex);
            }
        }

    }
}