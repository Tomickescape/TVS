﻿namespace TVS
{
    partial class FormTramsOverzicht
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
            this.dataGridViewTrams = new System.Windows.Forms.DataGridView();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSpoornummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddTram = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrams)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrams
            // 
            this.dataGridViewTrams.AllowUserToAddRows = false;
            this.dataGridViewTrams.AllowUserToDeleteRows = false;
            this.dataGridViewTrams.AllowUserToOrderColumns = true;
            this.dataGridViewTrams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnNummer,
            this.ColumnStatus,
            this.ColumnSpoornummer});
            this.dataGridViewTrams.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTrams.MultiSelect = false;
            this.dataGridViewTrams.Name = "dataGridViewTrams";
            this.dataGridViewTrams.Size = new System.Drawing.Size(727, 621);
            this.dataGridViewTrams.TabIndex = 0;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Width = 200;
            // 
            // ColumnNummer
            // 
            this.ColumnNummer.HeaderText = "Nummer";
            this.ColumnNummer.Name = "ColumnNummer";
            this.ColumnNummer.ReadOnly = true;
            this.ColumnNummer.Width = 200;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnSpoornummer
            // 
            this.ColumnSpoornummer.HeaderText = "Spoor";
            this.ColumnSpoornummer.Name = "ColumnSpoornummer";
            this.ColumnSpoornummer.ReadOnly = true;
            this.ColumnSpoornummer.Width = 200;
            // 
            // buttonAddTram
            // 
            this.buttonAddTram.Location = new System.Drawing.Point(745, 12);
            this.buttonAddTram.Name = "buttonAddTram";
            this.buttonAddTram.Size = new System.Drawing.Size(196, 23);
            this.buttonAddTram.TabIndex = 1;
            this.buttonAddTram.Text = "Voeg tram toe";
            this.buttonAddTram.UseVisualStyleBackColor = true;
            this.buttonAddTram.Click += new System.EventHandler(this.buttonAddTram_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(745, 41);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(196, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Verwijder tram";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormTramsOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 645);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddTram);
            this.Controls.Add(this.dataGridViewTrams);
            this.Name = "FormTramsOverzicht";
            this.Text = "Overzicht Trams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNummer;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpoornummer;
        private System.Windows.Forms.Button buttonAddTram;
        private System.Windows.Forms.Button buttonDelete;

    }
}