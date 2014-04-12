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

namespace TramVerdeelSysteem__TVS_
{

    public partial class FormMain : Form
    {
        private List<TextBoxSegment> segments = new List<TextBoxSegment>();

        List<Spoor> sporen;
        List<Tram> trams;

        public FormMain()
        {
            InitializeComponent();

            trams = Tram.GetAll();

            segments.Add(TB_segment13_1);
            segments.Add(TB_segment14_1);
            segments.Add(TB_segment15_1);
            segments.Add(TB_segment16_1);
            segments.Add(TB_segment17_1);
            segments.Add(TB_segment18_1);
            segments.Add(TB_segment19_1);
            segments.Add(TB_segment20_1);
            segments.Add(TB_segment21_1);
            segments.Add(TB_segment40_1);
            segments.Add(TB_segment40_2);
            segments.Add(TB_segment40_5);
            segments.Add(TB_segment40_3);
            segments.Add(TB_segment40_6);
            segments.Add(TB_segment40_4);
            segments.Add(TB_segment40_7);
            segments.Add(TB_segment57_5);
            segments.Add(TB_segment57_6);
            segments.Add(TB_segment57_7);
            segments.Add(TB_segment57_8);
            segments.Add(TB_segment56_5);
            segments.Add(TB_segment56_6);
            segments.Add(TB_segment56_7);
            segments.Add(TB_segment56_8);
            segments.Add(TB_segment55_5);
            segments.Add(TB_segment55_6);
            segments.Add(TB_segment55_7);
            segments.Add(TB_segment55_8);
            segments.Add(TB_segment54_5);
            segments.Add(TB_segment54_6);
            segments.Add(TB_segment54_7);
            segments.Add(TB_segment53_5);
            segments.Add(TB_segment53_6);
            segments.Add(TB_segment53_7);
            segments.Add(TB_segment52_5);
            segments.Add(TB_segment52_6);
            segments.Add(TB_segment52_7);
            segments.Add(TB_segment51_5);
            segments.Add(TB_segment51_6);
            segments.Add(TB_segment64_5);
            segments.Add(TB_segment74_5);
            segments.Add(TB_segment75_5);
            segments.Add(TB_segment76_5);
            segments.Add(TB_segment77_5);
            segments.Add(TB_segment45_5);
            segments.Add(TB_segment45_6);
            segments.Add(TB_segment45_7);
            segments.Add(TB_segment45_8);
            segments.Add(TB_segment45_9);
            segments.Add(TB_segment45_10);
            segments.Add(TB_segment12_1);
            segments.Add(TB_segment58_4);
            segments.Add(TB_segment58_3);
            segments.Add(TB_segment58_2);
            segments.Add(TB_segment58_1);
            segments.Add(TB_segment77_4);
            segments.Add(TB_segment77_3);
            segments.Add(TB_segment77_2);
            segments.Add(TB_segment77_1);
            segments.Add(TB_segment76_4);
            segments.Add(TB_segment76_3);
            segments.Add(TB_segment76_2);
            segments.Add(TB_segment76_1);
            segments.Add(TB_segment45_1);
            segments.Add(TB_segment45_2);
            segments.Add(TB_segment45_3);
            segments.Add(TB_segment45_4);
            segments.Add(TB_segment75_4);
            segments.Add(TB_segment75_3);
            segments.Add(TB_segment75_2);
            segments.Add(TB_segment75_1);
            segments.Add(TB_segment41_1);
            segments.Add(TB_segment42_1);
            segments.Add(TB_segment43_1);
            segments.Add(TB_segment44_1);
            segments.Add(TB_segment41_2);
            segments.Add(TB_segment42_2);
            segments.Add(TB_segment43_2);
            segments.Add(TB_segment44_2);
            segments.Add(TB_segment41_3);
            segments.Add(TB_segment42_3);
            segments.Add(TB_segment43_3);
            segments.Add(TB_segment44_3);
            segments.Add(TB_segment41_4);
            segments.Add(TB_segment42_4);
            segments.Add(TB_segment43_4);
            segments.Add(TB_segment44_4);
            segments.Add(TB_segment74_4);
            segments.Add(TB_segment74_3);
            segments.Add(TB_segment74_2);
            segments.Add(TB_segment74_1);
            segments.Add(TB_segment61_1);
            segments.Add(TB_segment61_2);
            segments.Add(TB_segment61_3);
            segments.Add(TB_segment62_1);
            segments.Add(TB_segment62_2);
            segments.Add(TB_segment62_3);
            segments.Add(TB_segment63_1);
            segments.Add(TB_segment63_2);
            segments.Add(TB_segment63_3);
            segments.Add(TB_segment63_4);
            segments.Add(TB_segment64_1);
            segments.Add(TB_segment64_2);
            segments.Add(TB_segment64_3);
            segments.Add(TB_segment64_4);
            segments.Add(TB_segment51_1);
            segments.Add(TB_segment51_2);
            segments.Add(TB_segment51_3);
            segments.Add(TB_segment51_4);
            segments.Add(TB_segment52_1);
            segments.Add(TB_segment52_2);
            segments.Add(TB_segment52_3);
            segments.Add(TB_segment52_4);
            segments.Add(TB_segment53_1);
            segments.Add(TB_segment53_2);
            segments.Add(TB_segment53_3);
            segments.Add(TB_segment53_4);
            segments.Add(TB_segment54_1);
            segments.Add(TB_segment54_2);
            segments.Add(TB_segment54_3);
            segments.Add(TB_segment54_4);
            segments.Add(TB_segment55_1);
            segments.Add(TB_segment55_2);
            segments.Add(TB_segment55_3);
            segments.Add(TB_segment55_4);
            segments.Add(TB_segment56_1);
            segments.Add(TB_segment56_2);
            segments.Add(TB_segment56_3);
            segments.Add(TB_segment56_4);
            segments.Add(TB_segment38_4);
            segments.Add(TB_segment37_4);
            segments.Add(TB_segment36_4);
            segments.Add(TB_segment35_4);
            segments.Add(TB_segment34_4);
            segments.Add(TB_segment33_4);
            segments.Add(TB_segment32_4);
            segments.Add(TB_segment57_4);
            segments.Add(TB_segment57_3);
            segments.Add(TB_segment57_2);
            segments.Add(TB_segment57_1);
            segments.Add(TB_segment30_1);
            segments.Add(TB_segment30_2);
            segments.Add(TB_segment30_3);
            segments.Add(TB_segment31_1);
            segments.Add(TB_segment31_2);
            segments.Add(TB_segment31_3);
            segments.Add(TB_segment32_1);
            segments.Add(TB_segment32_2);
            segments.Add(TB_segment32_3);
            segments.Add(TB_segment33_1);
            segments.Add(TB_segment33_2);
            segments.Add(TB_segment33_3);
            segments.Add(TB_segment34_1);
            segments.Add(TB_segment34_2);
            segments.Add(TB_segment34_3);
            segments.Add(TB_segment35_1);
            segments.Add(TB_segment35_2);
            segments.Add(TB_segment35_3);
            segments.Add(TB_segment36_1);
            segments.Add(TB_segment36_2);
            segments.Add(TB_segment36_3);
            segments.Add(TB_segment37_1);
            segments.Add(TB_segment37_2);
            segments.Add(TB_segment37_3);
            segments.Add(TB_segment38_1);
            segments.Add(TB_segment38_2);
            segments.Add(TB_segment38_3);

            RefreshSegments();
        }

        private void BTN_SpoorBlokkade_Click(object sender, EventArgs e)
        {
            try
            {
                int spoornummer = Convert.ToInt32(TB_spoornummer.Text.Trim());
                Spoor spoor = Spoor.GetBySpoornummer(spoornummer);

                if (spoor != null)
                {
                    MessageBox.Show(spoor.Geblokkeerd.ToString());
                    spoor.ChangeStatus(!spoor.Geblokkeerd);
                }


                RefreshSegments();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefreshSegments()
        {
            foreach (TextBoxSegment segment in segments)
            {
                segment.LoadSegment();
            }
        }

        private void btUitloggen_Click(object sender, EventArgs e)
        {
            FormLogin inlogform;
            inlogform = new FormLogin();
            inlogform.Show();
            this.Close();
        }
        private void TB_statusOpvragenTram_Click(object sender, EventArgs e)
        {
            //    admin.VraagStatussenOp
            foreach (Tram t in trams)
            {
                if (TB_tramnummer.Text != "")
                {
                    if (t.Nummer == Convert.ToInt32(TB_tramnummer.Text))
                    {


                        // b.BlokkeringStatusWijzigen(t);
                    }
                    else
                    {
                        MessageBox.Show("Sorry, dit is geen bestaand spoornummer");
                    }
                }
                else
                {
                    MessageBox.Show("Voer aub een spoornummer in!");
                }
                TB_spoornummer.Clear();
            }
        }

        private void btUitloggen_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void BTN_zetTramOpSpoor_Click(object sender, EventArgs e)
        {

            List<TextBoxSegment> segmentCollection = new List<TextBoxSegment>(segments);
            
            while (true)
            {
                Random rand = new Random();
                int index = rand.Next(segmentCollection.Count);
                TextBoxSegment textBox = segmentCollection[index];
                if (textBox.Segment != null && !textBox.Segment.Geblokkeerd && textBox.Text.Length == 0)
                {
                    if (textBox.Segment.Nummer > 1)
                    {
                        foreach (TextBoxSegment tbs in segmentCollection.ToList())
                        {
                            if (tbs.Segment != null && tbs.Segment.Spoor.Nummer == textBox.Segment.Spoornummer &&
                                tbs.Segment.Nummer < textBox.Segment.Nummer)
                            {
                                if (
                                    !tbs.Segment.Geblokkeerd && tbs.Text.Length == 0)
                                {
                                    textBox = tbs;
                                }
                                segmentCollection.Remove(tbs);
                            }
                        }
                    }

                    textBox.Segment.ChangeTram(trams[rand.Next(trams.Count)]);
                    textBox.LoadSegment();
                    return;
                }

                segmentCollection.RemoveAt(index);
            }


        }

        private void BTN_statusOpvragenTrams_Click(object sender, EventArgs e)
        {
            FormTramsOverzicht TramOverzicht = new FormTramsOverzicht();
            TramOverzicht.Show();
        }
    }
}