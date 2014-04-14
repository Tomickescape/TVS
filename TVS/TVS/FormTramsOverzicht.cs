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
        private FormCreateTram formCreateTram = null;

        public FormTramsOverzicht()
        {
            InitializeComponent();

            ColumnStatus.Items.AddRange(Enum.GetNames(typeof(Status)));           


            dataGridViewTrams.CellValueChanged += dataGridViewTrams_CellValueChanged;
            RefreshInterface();
        }

        private void RefreshInterface()
        {
            dataGridViewTrams.Rows.Clear();

            foreach (Tram tram in Tram.GetAll())
            {
                AddTram(tram);
            }
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

        private void buttonAddTram_Click(object sender, EventArgs e)
        {
            formCreateTram = new FormCreateTram();
            formCreateTram.Show();

            formCreateTram.Disposed += form_Disposed;
        }

        void form_Disposed(object sender, EventArgs e)
        {
            RefreshInterface();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            try
            {
                if (dataGridViewTrams.SelectedRows.Count > 0)
                {
                    row = dataGridViewTrams.SelectedRows[0];
                }
                else if (dataGridViewTrams.SelectedCells.Count > 0)
                {
                    row = dataGridViewTrams.SelectedCells[0].OwningRow;
                }
                else
                {
                    throw new Exception("Geen rij of cel geselecteerd.");
                }

                Tram tram = row.Tag as Tram;

                if (tram == null)
                {
                    throw new Exception("Tram niet gevonden.");
                }

                tram.Delete();
                RefreshInterface();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
