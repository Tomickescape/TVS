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
        private List<ButtonSegment> segments = new List<ButtonSegment>();
        private List<Spoor> sporen;
        private List<Tram> trams;

        private ButtonAdvanced _buttonAdvancedSelected = null;

        public FormMain()
        {
            InitializeComponent();

            buttonSegment_12_1.Segmentnummer = 1;
            buttonSegment_12_1.Spoornummer = 12;
            buttonSegment_13_1.Segmentnummer = 13;
            buttonSegment_13_1.Spoornummer = 1;

            trams = Tram.GetAll();

            segments.Add(buttonSegment_13_1);
            segments.Add(buttonSegment_14_1);
            segments.Add(buttonSegment_15_1);
            segments.Add(buttonSegment_16_1);
            segments.Add(buttonSegment_17_1);
            segments.Add(buttonSegment_18_1);
            segments.Add(buttonSegment_19_1);
            segments.Add(buttonSegment_20_1);
            segments.Add(buttonSegment_21_1);
            segments.Add(buttonSegment_40_1);
            segments.Add(buttonSegment_40_2);
            segments.Add(buttonSegment_40_5);
            segments.Add(buttonSegment_40_3);
            segments.Add(buttonSegment_40_6);
            segments.Add(buttonSegment_40_4);
            segments.Add(buttonSegment_40_7);
            segments.Add(buttonSegment_57_5);
            segments.Add(buttonSegment_57_6);
            segments.Add(buttonSegment_57_7);
            segments.Add(buttonSegment_57_8);
            segments.Add(buttonSegment_56_5);
            segments.Add(buttonSegment_56_6);
            segments.Add(buttonSegment_56_7);
            segments.Add(buttonSegment_56_8);
            segments.Add(buttonSegment_55_5);
            segments.Add(buttonSegment_55_6);
            segments.Add(buttonSegment_55_7);
            segments.Add(buttonSegment_55_8);
            segments.Add(buttonSegment_54_5);
            segments.Add(buttonSegment_54_6);
            segments.Add(buttonSegment_54_7);
            segments.Add(buttonSegment_53_5);
            segments.Add(buttonSegment_53_6);
            segments.Add(buttonSegment_53_7);
            segments.Add(buttonSegment_52_5);
            segments.Add(buttonSegment_52_6);
            segments.Add(buttonSegment_52_7);
            segments.Add(buttonSegment_51_5);
            segments.Add(buttonSegment_51_6);
            segments.Add(buttonSegment_64_5);
            segments.Add(buttonSegment_74_5);
            segments.Add(buttonSegment_75_5);
            segments.Add(buttonSegment_76_5);
            segments.Add(buttonSegment_77_5);
            segments.Add(buttonSegment_45_5);
            segments.Add(buttonSegment_45_6);
            segments.Add(buttonSegment_45_7);
            segments.Add(buttonSegment_45_8);
            segments.Add(buttonSegment_45_9);
            segments.Add(buttonSegment_45_10);
            segments.Add(buttonSegment_12_1);
            segments.Add(buttonSegment_58_4);
            segments.Add(buttonSegment_58_3);
            segments.Add(buttonSegment_58_2);
            segments.Add(buttonSegment_58_1);
            segments.Add(buttonSegment_77_4);
            segments.Add(buttonSegment_77_3);
            segments.Add(buttonSegment_77_2);
            segments.Add(buttonSegment_77_1);
            segments.Add(buttonSegment_76_4);
            segments.Add(buttonSegment_76_3);
            segments.Add(buttonSegment_76_2);
            segments.Add(buttonSegment_76_1);
            segments.Add(buttonSegment_45_1);
            segments.Add(buttonSegment_45_2);
            segments.Add(buttonSegment_45_3);
            segments.Add(buttonSegment_45_4);
            segments.Add(buttonSegment_75_4);
            segments.Add(buttonSegment_75_3);
            segments.Add(buttonSegment_75_2);
            segments.Add(buttonSegment_75_1);
            segments.Add(buttonSegment_41_1);
            segments.Add(buttonSegment_42_1);
            segments.Add(buttonSegment_43_1);
            segments.Add(buttonSegment_44_1);
            segments.Add(buttonSegment_41_2);
            segments.Add(buttonSegment_42_2);
            segments.Add(buttonSegment_43_2);
            segments.Add(buttonSegment_44_2);
            segments.Add(buttonSegment_41_3);
            segments.Add(buttonSegment_42_3);
            segments.Add(buttonSegment_43_3);
            segments.Add(buttonSegment_44_3);
            segments.Add(buttonSegment_41_4);
            segments.Add(buttonSegment_42_4);
            segments.Add(buttonSegment_43_4);
            segments.Add(buttonSegment_44_4);
            segments.Add(buttonSegment_74_4);
            segments.Add(buttonSegment_74_3);
            segments.Add(buttonSegment_74_2);
            segments.Add(buttonSegment_74_1);
            segments.Add(buttonSegment_61_1);
            segments.Add(buttonSegment_61_2);
            segments.Add(buttonSegment_61_3);
            segments.Add(buttonSegment_62_1);
            segments.Add(buttonSegment_62_2);
            segments.Add(buttonSegment_62_3);
            segments.Add(buttonSegment_63_1);
            segments.Add(buttonSegment_63_2);
            segments.Add(buttonSegment_63_3);
            segments.Add(buttonSegment_63_4);
            segments.Add(buttonSegment_64_1);
            segments.Add(buttonSegment_64_2);
            segments.Add(buttonSegment_64_3);
            segments.Add(buttonSegment_64_4);
            segments.Add(buttonSegment_51_1);
            segments.Add(buttonSegment_51_2);
            segments.Add(buttonSegment_51_3);
            segments.Add(buttonSegment_51_4);
            segments.Add(buttonSegment_52_1);
            segments.Add(buttonSegment_52_2);
            segments.Add(buttonSegment_52_3);
            segments.Add(buttonSegment_52_4);
            segments.Add(buttonSegment_53_1);
            segments.Add(buttonSegment_53_2);
            segments.Add(buttonSegment_53_3);
            segments.Add(buttonSegment_53_4);
            segments.Add(buttonSegment_54_1);
            segments.Add(buttonSegment_54_2);
            segments.Add(buttonSegment_54_3);
            segments.Add(buttonSegment_54_4);
            segments.Add(buttonSegment_55_1);
            segments.Add(buttonSegment_55_2);
            segments.Add(buttonSegment_55_3);
            segments.Add(buttonSegment_55_4);
            segments.Add(buttonSegment_56_1);
            segments.Add(buttonSegment_56_2);
            segments.Add(buttonSegment_56_3);
            segments.Add(buttonSegment_56_4);
            segments.Add(buttonSegment_38_4);
            segments.Add(buttonSegment_37_4);
            segments.Add(buttonSegment_36_4);
            segments.Add(buttonSegment_35_4);
            segments.Add(buttonSegment_34_4);
            segments.Add(buttonSegment_33_4);
            segments.Add(buttonSegment_32_4);
            segments.Add(buttonSegment_57_4);
            segments.Add(buttonSegment_57_3);
            segments.Add(buttonSegment_57_2);
            segments.Add(buttonSegment_57_1);
            segments.Add(buttonSegment_30_1);
            segments.Add(buttonSegment_30_2);
            segments.Add(buttonSegment_30_3);
            segments.Add(buttonSegment_31_1);
            segments.Add(buttonSegment_31_2);
            segments.Add(buttonSegment_31_3);
            segments.Add(buttonSegment_32_1);
            segments.Add(buttonSegment_32_2);
            segments.Add(buttonSegment_32_3);
            segments.Add(buttonSegment_33_1);
            segments.Add(buttonSegment_33_2);
            segments.Add(buttonSegment_33_3);
            segments.Add(buttonSegment_34_1);
            segments.Add(buttonSegment_34_2);
            segments.Add(buttonSegment_34_3);
            segments.Add(buttonSegment_35_1);
            segments.Add(buttonSegment_35_2);
            segments.Add(buttonSegment_35_3);
            segments.Add(buttonSegment_36_1);
            segments.Add(buttonSegment_36_2);
            segments.Add(buttonSegment_36_3);
            segments.Add(buttonSegment_37_1);
            segments.Add(buttonSegment_37_2);
            segments.Add(buttonSegment_37_3);
            segments.Add(buttonSegment_38_1);
            segments.Add(buttonSegment_38_2);
            segments.Add(buttonSegment_38_3);

            foreach (ButtonAdvanced tb in GetAllButtonAdvanced())
            {
                tb.Click += buttonAdvanced_Click;
            }

            RefreshInterface();
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
            List<ButtonSpoor> sporen = GetAllButtonAdvanced().FindAll(x => x is ButtonSpoor).Cast<ButtonSpoor>().ToList();

            while (sporen.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(sporen.Count);

                ButtonSpoor buttonSpoor = sporen[index];

                Segment randomSegment = null;
                if (!buttonSpoor.Spoor.Geblokkeerd)
                {
                    foreach (Segment segment in buttonSpoor.Spoor.Segments)
                    {
                        if (!segment.Geblokkeerd)
                        {
                            if (segment.Tram == null)
                            {
                                if (randomSegment != null)
                                {
                                    if (segment.Nummer < randomSegment.Nummer)
                                    {
                                        randomSegment = segment;
                                    }
                                }
                                else
                                {
                                    randomSegment = segment;
                                }
                            }
                        }
                    }
                }

                sporen.RemoveAt(index);

                if (randomSegment != null)
                {
                    try
                    {
                        randomSegment.ChangeTram(trams[rand.Next(trams.Count)]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    RefreshInterface();
                    return;
                }
            }

            MessageBox.Show("Geen locatie voor tram gevonden.");
        }

        private void BTN_statusOpvragenTrams_Click(object sender, EventArgs e)
        {
            FormTramsOverzicht TramOverzicht = new FormTramsOverzicht();
            TramOverzicht.Show();
        }
    }
}