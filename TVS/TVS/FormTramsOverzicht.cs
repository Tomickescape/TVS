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
    public partial class FormTramsOverzicht : Form
    {
        public FormTramsOverzicht()
        {
            InitializeComponent();

            ColumnStatus.Items.AddRange(Enum.GetNames(typeof(Status)));           

            foreach (Tram tram in Tram.GetAll())
            {
                AddTram(tram);
            }

            dataGridViewTrams.CellValueChanged += dataGridViewTrams_CellValueChanged;
           
        }

        void dataGridViewTrams_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            Tram tram = row.Tag as Tram;
            if (tram != null) 
            {
                if (dataGridViewTrams.Columns[e.ColumnIndex] == ColumnStatus)
                {
                    DataGridViewComboBoxCell cellCB = cell as DataGridViewComboBoxCell;
                    Status status;
                    Enum.TryParse<Status>(cellCB.Value.ToString(), out status);
                    tram.ChangeStatus(status);
                }
            }
        }

        public void AddTram(Tram tram)
        {
            Segment segment = tram.Segment;
            int index = dataGridViewTrams.Rows.Add(tram.Type, tram.Nummer, tram.Status.ToString(), segment != null ? segment.Spoor.Nummer.ToString() : "");

            dataGridViewTrams.Rows[index].Tag = tram;
        }
    }
}
