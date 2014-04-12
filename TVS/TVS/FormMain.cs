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
            this.buttonSegment_12_1 = new ButtonSegment(1, 12);
            this.buttonSegment_13_1 = new ButtonSegment(1, 13);
            this.buttonSegment_14_1 = new ButtonSegment(1, 14);
            this.buttonSegment_15_1 = new ButtonSegment(1, 15);
            this.buttonSegment_16_1 = new ButtonSegment(1, 16);
            this.buttonSegment_17_1 = new ButtonSegment(1, 17);
            this.buttonSegment_18_1 = new ButtonSegment(1, 18);
            this.buttonSegment_19_1 = new ButtonSegment(1, 19);
            this.buttonSegment_20_1 = new ButtonSegment(1, 20);
            this.buttonSegment_21_1 = new ButtonSegment(1, 21);
            this.buttonSegment_30_1 = new ButtonSegment(1, 30);
            this.buttonSegment_30_2 = new ButtonSegment(2, 30);
            this.buttonSegment_30_3 = new ButtonSegment(3, 30);
            this.buttonSegment_31_1 = new ButtonSegment(1, 31);
            this.buttonSegment_31_2 = new ButtonSegment(2, 31);
            this.buttonSegment_31_3 = new ButtonSegment(3, 31);
            this.buttonSegment_32_1 = new ButtonSegment(1, 32);
            this.buttonSegment_32_2 = new ButtonSegment(2, 32);
            this.buttonSegment_32_3 = new ButtonSegment(3, 32);
            this.buttonSegment_32_4 = new ButtonSegment(4, 32);
            this.buttonSegment_33_1 = new ButtonSegment(1, 33);
            this.buttonSegment_33_2 = new ButtonSegment(2, 33);
            this.buttonSegment_33_3 = new ButtonSegment(3, 33);
            this.buttonSegment_33_4 = new ButtonSegment(4, 33);
            this.buttonSegment_34_1 = new ButtonSegment(1, 34);
            this.buttonSegment_34_2 = new ButtonSegment(2, 34);
            this.buttonSegment_34_3 = new ButtonSegment(3, 34);
            this.buttonSegment_34_4 = new ButtonSegment(4, 34);
            this.buttonSegment_35_1 = new ButtonSegment(1, 35);
            this.buttonSegment_35_2 = new ButtonSegment(2, 35);
            this.buttonSegment_35_3 = new ButtonSegment(3, 35);
            this.buttonSegment_35_4 = new ButtonSegment(4, 35);
            this.buttonSegment_36_1 = new ButtonSegment(1, 36);
            this.buttonSegment_36_2 = new ButtonSegment(2, 36);
            this.buttonSegment_36_3 = new ButtonSegment(3, 36);
            this.buttonSegment_36_4 = new ButtonSegment(4, 36);
            this.buttonSegment_37_1 = new ButtonSegment(1, 37);
            this.buttonSegment_37_2 = new ButtonSegment(2, 37);
            this.buttonSegment_37_3 = new ButtonSegment(3, 37);
            this.buttonSegment_37_4 = new ButtonSegment(4, 37);
            this.buttonSegment_38_1 = new ButtonSegment(1, 38);
            this.buttonSegment_38_2 = new ButtonSegment(2, 38);
            this.buttonSegment_38_3 = new ButtonSegment(3, 38);
            this.buttonSegment_38_4 = new ButtonSegment(4, 38);
            this.buttonSegment_40_1 = new ButtonSegment(1, 40);
            this.buttonSegment_40_2 = new ButtonSegment(2, 40);
            this.buttonSegment_40_3 = new ButtonSegment(3, 40);
            this.buttonSegment_40_4 = new ButtonSegment(4, 40);
            this.buttonSegment_40_5 = new ButtonSegment(5, 40);
            this.buttonSegment_40_6 = new ButtonSegment(6, 40);
            this.buttonSegment_40_7 = new ButtonSegment(7, 40);
            this.buttonSegment_41_1 = new ButtonSegment(1, 41);
            this.buttonSegment_41_2 = new ButtonSegment(2, 41);
            this.buttonSegment_41_3 = new ButtonSegment(3, 41);
            this.buttonSegment_41_4 = new ButtonSegment(4, 41);
            this.buttonSegment_42_1 = new ButtonSegment(1, 42);
            this.buttonSegment_42_2 = new ButtonSegment(2, 42);
            this.buttonSegment_42_3 = new ButtonSegment(3, 42);
            this.buttonSegment_42_4 = new ButtonSegment(4, 42);
            this.buttonSegment_43_1 = new ButtonSegment(1, 43);
            this.buttonSegment_43_2 = new ButtonSegment(2, 43);
            this.buttonSegment_43_3 = new ButtonSegment(3, 43);
            this.buttonSegment_43_4 = new ButtonSegment(4, 43);
            this.buttonSegment_44_1 = new ButtonSegment(1, 44);
            this.buttonSegment_44_2 = new ButtonSegment(2, 44);
            this.buttonSegment_44_3 = new ButtonSegment(3, 44);
            this.buttonSegment_44_4 = new ButtonSegment(4, 44);
            this.buttonSegment_45_1 = new ButtonSegment(1, 45);
            this.buttonSegment_45_10 = new ButtonSegment(10, 45);
            this.buttonSegment_45_2 = new ButtonSegment(2, 45);
            this.buttonSegment_45_3 = new ButtonSegment(3, 45);
            this.buttonSegment_45_4 = new ButtonSegment(4, 45);
            this.buttonSegment_45_5 = new ButtonSegment(5, 45);
            this.buttonSegment_45_6 = new ButtonSegment(6, 45);
            this.buttonSegment_45_7 = new ButtonSegment(7, 45);
            this.buttonSegment_45_8 = new ButtonSegment(8, 45);
            this.buttonSegment_45_9 = new ButtonSegment(9, 45);
            this.buttonSegment_51_1 = new ButtonSegment(1, 51);
            this.buttonSegment_51_2 = new ButtonSegment(2, 51);
            this.buttonSegment_51_3 = new ButtonSegment(3, 51);
            this.buttonSegment_51_4 = new ButtonSegment(4, 51);
            this.buttonSegment_51_5 = new ButtonSegment(5, 51);
            this.buttonSegment_51_6 = new ButtonSegment(6, 51);
            this.buttonSegment_52_1 = new ButtonSegment(1, 52);
            this.buttonSegment_52_2 = new ButtonSegment(2, 52);
            this.buttonSegment_52_3 = new ButtonSegment(3, 52);
            this.buttonSegment_52_4 = new ButtonSegment(4, 52);
            this.buttonSegment_52_5 = new ButtonSegment(5, 52);
            this.buttonSegment_52_6 = new ButtonSegment(6, 52);
            this.buttonSegment_52_7 = new ButtonSegment(7, 52);
            this.buttonSegment_53_1 = new ButtonSegment(1, 53);
            this.buttonSegment_53_2 = new ButtonSegment(2, 53);
            this.buttonSegment_53_3 = new ButtonSegment(3, 53);
            this.buttonSegment_53_4 = new ButtonSegment(4, 53);
            this.buttonSegment_53_5 = new ButtonSegment(5, 53);
            this.buttonSegment_53_6 = new ButtonSegment(6, 53);
            this.buttonSegment_53_7 = new ButtonSegment(7, 53);
            this.buttonSegment_54_1 = new ButtonSegment(1, 54);
            this.buttonSegment_54_2 = new ButtonSegment(2, 54);
            this.buttonSegment_54_3 = new ButtonSegment(3, 54);
            this.buttonSegment_54_4 = new ButtonSegment(4, 54);
            this.buttonSegment_54_5 = new ButtonSegment(5, 54);
            this.buttonSegment_54_6 = new ButtonSegment(6, 54);
            this.buttonSegment_54_7 = new ButtonSegment(7, 54);
            this.buttonSegment_55_1 = new ButtonSegment(1, 55);
            this.buttonSegment_55_2 = new ButtonSegment(2, 55);
            this.buttonSegment_55_3 = new ButtonSegment(3, 55);
            this.buttonSegment_55_4 = new ButtonSegment(4, 55);
            this.buttonSegment_55_5 = new ButtonSegment(5, 55);
            this.buttonSegment_55_6 = new ButtonSegment(6, 55);
            this.buttonSegment_55_7 = new ButtonSegment(7, 55);
            this.buttonSegment_55_8 = new ButtonSegment(8, 55);
            this.buttonSegment_56_1 = new ButtonSegment(1, 56);
            this.buttonSegment_56_2 = new ButtonSegment(2, 56);
            this.buttonSegment_56_3 = new ButtonSegment(3, 56);
            this.buttonSegment_56_4 = new ButtonSegment(4, 56);
            this.buttonSegment_56_5 = new ButtonSegment(5, 56);
            this.buttonSegment_56_6 = new ButtonSegment(6, 56);
            this.buttonSegment_56_7 = new ButtonSegment(7, 56);
            this.buttonSegment_56_8 = new ButtonSegment(8, 56);
            this.buttonSegment_57_1 = new ButtonSegment(1, 57);
            this.buttonSegment_57_2 = new ButtonSegment(2, 57);
            this.buttonSegment_57_3 = new ButtonSegment(3, 57);
            this.buttonSegment_57_4 = new ButtonSegment(4, 57);
            this.buttonSegment_57_5 = new ButtonSegment(5, 57);
            this.buttonSegment_57_6 = new ButtonSegment(6, 57);
            this.buttonSegment_57_7 = new ButtonSegment(7, 57);
            this.buttonSegment_57_8 = new ButtonSegment(8, 57);
            this.buttonSegment_58_1 = new ButtonSegment(1, 58);
            this.buttonSegment_58_2 = new ButtonSegment(2, 58);
            this.buttonSegment_58_3 = new ButtonSegment(3, 58);
            this.buttonSegment_58_4 = new ButtonSegment(4, 58);
            this.buttonSegment_61_1 = new ButtonSegment(1, 61);
            this.buttonSegment_61_2 = new ButtonSegment(2, 61);
            this.buttonSegment_61_3 = new ButtonSegment(3, 61);
            this.buttonSegment_62_1 = new ButtonSegment(1, 62);
            this.buttonSegment_62_2 = new ButtonSegment(2, 62);
            this.buttonSegment_62_3 = new ButtonSegment(3, 62);
            this.buttonSegment_63_1 = new ButtonSegment(1, 63);
            this.buttonSegment_63_2 = new ButtonSegment(2, 63);
            this.buttonSegment_63_3 = new ButtonSegment(3, 63);
            this.buttonSegment_63_4 = new ButtonSegment(4, 63);
            this.buttonSegment_64_1 = new ButtonSegment(1, 64);
            this.buttonSegment_64_2 = new ButtonSegment(2, 64);
            this.buttonSegment_64_3 = new ButtonSegment(3, 64);
            this.buttonSegment_64_4 = new ButtonSegment(4, 64);
            this.buttonSegment_64_5 = new ButtonSegment(5, 64);
            this.buttonSegment_74_1 = new ButtonSegment(1, 74);
            this.buttonSegment_74_2 = new ButtonSegment(2, 74);
            this.buttonSegment_74_3 = new ButtonSegment(3, 74);
            this.buttonSegment_74_4 = new ButtonSegment(4, 74);
            this.buttonSegment_74_5 = new ButtonSegment(5, 74);
            this.buttonSegment_75_1 = new ButtonSegment(1, 75);
            this.buttonSegment_75_2 = new ButtonSegment(2, 75);
            this.buttonSegment_75_3 = new ButtonSegment(3, 75);
            this.buttonSegment_75_4 = new ButtonSegment(4, 75);
            this.buttonSegment_75_5 = new ButtonSegment(5, 75);
            this.buttonSegment_76_1 = new ButtonSegment(1, 76);
            this.buttonSegment_76_2 = new ButtonSegment(2, 76);
            this.buttonSegment_76_3 = new ButtonSegment(3, 76);
            this.buttonSegment_76_4 = new ButtonSegment(4, 76);
            this.buttonSegment_76_5 = new ButtonSegment(5, 76);
            this.buttonSegment_77_1 = new ButtonSegment(1, 77);
            this.buttonSegment_77_2 = new ButtonSegment(2, 77);
            this.buttonSegment_77_3 = new ButtonSegment(3, 77);
            this.buttonSegment_77_4 = new ButtonSegment(4, 77);
            this.buttonSegment_77_5 = new ButtonSegment(5, 77);
            this.buttonSpoor_12 = new ButtonSpoor(12);
            this.buttonSpoor_13 = new ButtonSpoor(13);
            this.buttonSpoor_14 = new ButtonSpoor(14);
            this.buttonSpoor_15 = new ButtonSpoor(15);
            this.buttonSpoor_16 = new ButtonSpoor(16);
            this.buttonSpoor_17 = new ButtonSpoor(17);
            this.buttonSpoor_18 = new ButtonSpoor(18);
            this.buttonSpoor_19 = new ButtonSpoor(19);
            this.buttonSpoor_20 = new ButtonSpoor(20);
            this.buttonSpoor_21 = new ButtonSpoor(21);
            this.buttonSpoor_30 = new ButtonSpoor(30);
            this.buttonSpoor_31 = new ButtonSpoor(31);
            this.buttonSpoor_32 = new ButtonSpoor(32);
            this.buttonSpoor_33 = new ButtonSpoor(33);
            this.buttonSpoor_34 = new ButtonSpoor(34);
            this.buttonSpoor_35 = new ButtonSpoor(35);
            this.buttonSpoor_36 = new ButtonSpoor(36);
            this.buttonSpoor_37 = new ButtonSpoor(37);
            this.buttonSpoor_38 = new ButtonSpoor(38);
            this.buttonSpoor_40 = new ButtonSpoor(40);
            this.buttonSpoor_41 = new ButtonSpoor(41);
            this.buttonSpoor_42 = new ButtonSpoor(42);
            this.buttonSpoor_43 = new ButtonSpoor(43);
            this.buttonSpoor_44 = new ButtonSpoor(44);
            this.buttonSpoor_45 = new ButtonSpoor(45);
            this.buttonSpoor_51 = new ButtonSpoor(51);
            this.buttonSpoor_52 = new ButtonSpoor(52);
            this.buttonSpoor_53 = new ButtonSpoor(53);
            this.buttonSpoor_54 = new ButtonSpoor(54);
            this.buttonSpoor_55 = new ButtonSpoor(55);
            this.buttonSpoor_56 = new ButtonSpoor(56);
            this.buttonSpoor_57 = new ButtonSpoor(57);
            this.buttonSpoor_58 = new ButtonSpoor(58);
            this.buttonSpoor_61 = new ButtonSpoor(61);
            this.buttonSpoor_62 = new ButtonSpoor(62);
            this.buttonSpoor_63 = new ButtonSpoor(63);
            this.buttonSpoor_64 = new ButtonSpoor(64);
            this.buttonSpoor_74 = new ButtonSpoor(74);
            this.buttonSpoor_75 = new ButtonSpoor(75);
            this.buttonSpoor_76 = new ButtonSpoor(76);
            InitializeComponent();

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