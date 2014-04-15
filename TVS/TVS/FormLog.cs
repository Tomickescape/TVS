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
    public partial class FormLog : Form
    {

        public FormLog()
        {
            InitializeComponent();    
            
            RefreshInterface();
        }
        
        public void RefreshInterface()
        {
            try
            {
                dataGridViewLogs.Rows.Clear();

                foreach (Log log in Log.GetAll())
                {
                    Segment segment = log.Segment;

                    int index = dataGridViewLogs.Rows.Add(log.Created.ToString(), log.Tram.Nummer.ToString(), log.Tram.Type, (segment != null ? segment.Nummer.ToString() : ""), (segment != null ? segment.Spoor.Nummer.ToString() : ""));
                    
                    DataGridViewRow row = dataGridViewLogs.Rows[index];
                    //als het segment leeg is dan maak de regels rood, dit is dan uitrij
                    if (segment == null)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
