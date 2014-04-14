namespace TVS
{
    partial class FormLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTramNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTramType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpoorNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSegmentNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.AllowUserToOrderColumns = true;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDateTime,
            this.ColumnTramNummer,
            this.ColumnTramType,
            this.ColumnSpoorNummer,
            this.ColumnSegmentNummer});
            this.dataGridViewLogs.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLogs.MultiSelect = false;
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.Size = new System.Drawing.Size(644, 621);
            this.dataGridViewLogs.TabIndex = 0;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "DateTime";
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            this.ColumnDateTime.Width = 150;
            // 
            // ColumnTramNummer
            // 
            this.ColumnTramNummer.HeaderText = "Tram";
            this.ColumnTramNummer.Name = "ColumnTramNummer";
            this.ColumnTramNummer.ReadOnly = true;
            // 
            // ColumnTramType
            // 
            this.ColumnTramType.HeaderText = "Type";
            this.ColumnTramType.Name = "ColumnTramType";
            this.ColumnTramType.ReadOnly = true;
            // 
            // ColumnSpoorNummer
            // 
            this.ColumnSpoorNummer.HeaderText = "Spoor";
            this.ColumnSpoorNummer.Name = "ColumnSpoorNummer";
            this.ColumnSpoorNummer.ReadOnly = true;
            // 
            // ColumnSegmentNummer
            // 
            this.ColumnSegmentNummer.HeaderText = "Segment";
            this.ColumnSegmentNummer.Name = "ColumnSegmentNummer";
            this.ColumnSegmentNummer.ReadOnly = true;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 645);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "FormLog";
            this.Text = "In en uitrij";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTramNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTramType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpoorNummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSegmentNummer;

    }
}