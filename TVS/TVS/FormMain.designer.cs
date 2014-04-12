namespace TVS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonBlock = new System.Windows.Forms.Button();
            this.BTN_statusOpvragenTrams = new System.Windows.Forms.Button();
            this.BTN_zetTramOpSpoor = new System.Windows.Forms.Button();
            this.GB_Reservering = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LBL_tramnummer = new System.Windows.Forms.Label();
            this.TB_lijn10_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn10_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn13_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn13_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn16_24_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn16_24_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn16_24_3 = new System.Windows.Forms.TextBox();
            this.TB_lijn16_24_4 = new System.Windows.Forms.TextBox();
            this.TB_lijn17_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn17_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn1_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn1_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn1_3 = new System.Windows.Forms.TextBox();
            this.TB_lijn2_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn2_3 = new System.Windows.Forms.TextBox();
            this.TB_lijn2_4 = new System.Windows.Forms.TextBox();
            this.TB_lijn5_1 = new System.Windows.Forms.TextBox();
            this.TB_lijn5_2 = new System.Windows.Forms.TextBox();
            this.TB_lijn5_3 = new System.Windows.Forms.TextBox();
            this.TB_lijn5_4 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_1 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_10 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_2 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_3 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_4 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_5 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_6 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_7 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_8 = new System.Windows.Forms.TextBox();
            this.TB_lijnVrij_9 = new System.Windows.Forms.TextBox();
            this.TB_tramnummer = new System.Windows.Forms.TextBox();
            this.btUitloggen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TB_lijn2_1 = new System.Windows.Forms.TextBox();
            this.GB_Reservering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBlock
            // 
            this.buttonBlock.Location = new System.Drawing.Point(1182, 107);
            this.buttonBlock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(155, 28);
            this.buttonBlock.TabIndex = 13;
            this.buttonBlock.Text = "Toggle Blokkering";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // BTN_statusOpvragenTrams
            // 
            this.BTN_statusOpvragenTrams.Location = new System.Drawing.Point(1181, 147);
            this.BTN_statusOpvragenTrams.Name = "BTN_statusOpvragenTrams";
            this.BTN_statusOpvragenTrams.Size = new System.Drawing.Size(154, 28);
            this.BTN_statusOpvragenTrams.TabIndex = 92;
            this.BTN_statusOpvragenTrams.Text = "Vraag tramstatussen op";
            this.BTN_statusOpvragenTrams.UseVisualStyleBackColor = true;
            this.BTN_statusOpvragenTrams.Click += new System.EventHandler(this.BTN_statusOpvragenTrams_Click);
            // 
            // BTN_zetTramOpSpoor
            // 
            this.BTN_zetTramOpSpoor.Location = new System.Drawing.Point(1181, 188);
            this.BTN_zetTramOpSpoor.Name = "BTN_zetTramOpSpoor";
            this.BTN_zetTramOpSpoor.Size = new System.Drawing.Size(154, 28);
            this.BTN_zetTramOpSpoor.TabIndex = 94;
            this.BTN_zetTramOpSpoor.Text = "Ken spoor aan tram toe";
            this.BTN_zetTramOpSpoor.UseVisualStyleBackColor = true;
            this.BTN_zetTramOpSpoor.Click += new System.EventHandler(this.buttonPlaceTram_Click);
            // 
            // GB_Reservering
            // 
            this.GB_Reservering.BackColor = System.Drawing.Color.LightSkyBlue;
            this.GB_Reservering.Controls.Add(this.listBox1);
            this.GB_Reservering.Location = new System.Drawing.Point(0, 0);
            this.GB_Reservering.Name = "GB_Reservering";
            this.GB_Reservering.Size = new System.Drawing.Size(195, 300);
            this.GB_Reservering.TabIndex = 96;
            this.GB_Reservering.TabStop = false;
            this.GB_Reservering.Text = "Reserveringen";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(168, 260);
            this.listBox1.TabIndex = 95;
            // 
            // LBL_tramnummer
            // 
            this.LBL_tramnummer.AutoSize = true;
            this.LBL_tramnummer.Location = new System.Drawing.Point(979, 154);
            this.LBL_tramnummer.Name = "LBL_tramnummer";
            this.LBL_tramnummer.Size = new System.Drawing.Size(91, 16);
            this.LBL_tramnummer.TabIndex = 91;
            this.LBL_tramnummer.Text = "Tramnummer:";
            // 
            // TB_lijn10_1
            // 
            this.TB_lijn10_1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TB_lijn10_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn10_1.Location = new System.Drawing.Point(508, 44);
            this.TB_lijn10_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn10_1.Multiline = true;
            this.TB_lijn10_1.Name = "TB_lijn10_1";
            this.TB_lijn10_1.ReadOnly = true;
            this.TB_lijn10_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn10_1.TabIndex = 0;
            this.TB_lijn10_1.Text = "10";
            this.TB_lijn10_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn10_2
            // 
            this.TB_lijn10_2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TB_lijn10_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn10_2.Location = new System.Drawing.Point(719, 44);
            this.TB_lijn10_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn10_2.Multiline = true;
            this.TB_lijn10_2.Name = "TB_lijn10_2";
            this.TB_lijn10_2.ReadOnly = true;
            this.TB_lijn10_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn10_2.TabIndex = 19;
            this.TB_lijn10_2.Text = "10";
            this.TB_lijn10_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn13_1
            // 
            this.TB_lijn13_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TB_lijn13_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn13_1.Location = new System.Drawing.Point(872, 44);
            this.TB_lijn13_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn13_1.Multiline = true;
            this.TB_lijn13_1.Name = "TB_lijn13_1";
            this.TB_lijn13_1.ReadOnly = true;
            this.TB_lijn13_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn13_1.TabIndex = 19;
            this.TB_lijn13_1.Text = "13";
            this.TB_lijn13_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn13_2
            // 
            this.TB_lijn13_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TB_lijn13_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn13_2.Location = new System.Drawing.Point(262, 346);
            this.TB_lijn13_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn13_2.Multiline = true;
            this.TB_lijn13_2.Name = "TB_lijn13_2";
            this.TB_lijn13_2.ReadOnly = true;
            this.TB_lijn13_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn13_2.TabIndex = 19;
            this.TB_lijn13_2.Text = "13";
            this.TB_lijn13_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn16_24_1
            // 
            this.TB_lijn16_24_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_lijn16_24_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn16_24_1.Location = new System.Drawing.Point(355, 44);
            this.TB_lijn16_24_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn16_24_1.Multiline = true;
            this.TB_lijn16_24_1.Name = "TB_lijn16_24_1";
            this.TB_lijn16_24_1.ReadOnly = true;
            this.TB_lijn16_24_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn16_24_1.TabIndex = 0;
            this.TB_lijn16_24_1.Text = "16/24";
            this.TB_lijn16_24_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn16_24_2
            // 
            this.TB_lijn16_24_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_lijn16_24_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn16_24_2.Location = new System.Drawing.Point(457, 44);
            this.TB_lijn16_24_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn16_24_2.Multiline = true;
            this.TB_lijn16_24_2.Name = "TB_lijn16_24_2";
            this.TB_lijn16_24_2.ReadOnly = true;
            this.TB_lijn16_24_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn16_24_2.TabIndex = 0;
            this.TB_lijn16_24_2.Text = "16/24";
            this.TB_lijn16_24_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn16_24_3
            // 
            this.TB_lijn16_24_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_lijn16_24_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn16_24_3.Location = new System.Drawing.Point(610, 44);
            this.TB_lijn16_24_3.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn16_24_3.Multiline = true;
            this.TB_lijn16_24_3.Name = "TB_lijn16_24_3";
            this.TB_lijn16_24_3.ReadOnly = true;
            this.TB_lijn16_24_3.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn16_24_3.TabIndex = 0;
            this.TB_lijn16_24_3.Text = "16/24";
            this.TB_lijn16_24_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn16_24_4
            // 
            this.TB_lijn16_24_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TB_lijn16_24_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn16_24_4.Location = new System.Drawing.Point(58, 346);
            this.TB_lijn16_24_4.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn16_24_4.Multiline = true;
            this.TB_lijn16_24_4.Name = "TB_lijn16_24_4";
            this.TB_lijn16_24_4.ReadOnly = true;
            this.TB_lijn16_24_4.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn16_24_4.TabIndex = 19;
            this.TB_lijn16_24_4.Text = "16/24";
            this.TB_lijn16_24_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn17_1
            // 
            this.TB_lijn17_1.BackColor = System.Drawing.Color.Red;
            this.TB_lijn17_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn17_1.Location = new System.Drawing.Point(923, 44);
            this.TB_lijn17_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn17_1.Multiline = true;
            this.TB_lijn17_1.Name = "TB_lijn17_1";
            this.TB_lijn17_1.ReadOnly = true;
            this.TB_lijn17_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn17_1.TabIndex = 25;
            this.TB_lijn17_1.Text = "17";
            this.TB_lijn17_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn17_2
            // 
            this.TB_lijn17_2.BackColor = System.Drawing.Color.Red;
            this.TB_lijn17_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn17_2.Location = new System.Drawing.Point(313, 346);
            this.TB_lijn17_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn17_2.Multiline = true;
            this.TB_lijn17_2.Name = "TB_lijn17_2";
            this.TB_lijn17_2.ReadOnly = true;
            this.TB_lijn17_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn17_2.TabIndex = 19;
            this.TB_lijn17_2.Text = "17";
            this.TB_lijn17_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn1_1
            // 
            this.TB_lijn1_1.BackColor = System.Drawing.Color.Lime;
            this.TB_lijn1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn1_1.Location = new System.Drawing.Point(304, 44);
            this.TB_lijn1_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn1_1.Multiline = true;
            this.TB_lijn1_1.Name = "TB_lijn1_1";
            this.TB_lijn1_1.ReadOnly = true;
            this.TB_lijn1_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn1_1.TabIndex = 0;
            this.TB_lijn1_1.Text = "1";
            this.TB_lijn1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn1_2
            // 
            this.TB_lijn1_2.BackColor = System.Drawing.Color.Lime;
            this.TB_lijn1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn1_2.Location = new System.Drawing.Point(821, 44);
            this.TB_lijn1_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn1_2.Multiline = true;
            this.TB_lijn1_2.Name = "TB_lijn1_2";
            this.TB_lijn1_2.ReadOnly = true;
            this.TB_lijn1_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn1_2.TabIndex = 19;
            this.TB_lijn1_2.Text = "1";
            this.TB_lijn1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn1_3
            // 
            this.TB_lijn1_3.BackColor = System.Drawing.Color.Lime;
            this.TB_lijn1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn1_3.Location = new System.Drawing.Point(364, 346);
            this.TB_lijn1_3.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn1_3.Multiline = true;
            this.TB_lijn1_3.Name = "TB_lijn1_3";
            this.TB_lijn1_3.ReadOnly = true;
            this.TB_lijn1_3.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn1_3.TabIndex = 19;
            this.TB_lijn1_3.Text = "1";
            this.TB_lijn1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn2_2
            // 
            this.TB_lijn2_2.BackColor = System.Drawing.Color.Yellow;
            this.TB_lijn2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn2_2.Location = new System.Drawing.Point(406, 44);
            this.TB_lijn2_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn2_2.Multiline = true;
            this.TB_lijn2_2.Name = "TB_lijn2_2";
            this.TB_lijn2_2.ReadOnly = true;
            this.TB_lijn2_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn2_2.TabIndex = 0;
            this.TB_lijn2_2.Text = "2";
            this.TB_lijn2_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn2_3
            // 
            this.TB_lijn2_3.BackColor = System.Drawing.Color.Yellow;
            this.TB_lijn2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn2_3.Location = new System.Drawing.Point(160, 346);
            this.TB_lijn2_3.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn2_3.Multiline = true;
            this.TB_lijn2_3.Name = "TB_lijn2_3";
            this.TB_lijn2_3.ReadOnly = true;
            this.TB_lijn2_3.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn2_3.TabIndex = 19;
            this.TB_lijn2_3.Text = "2";
            this.TB_lijn2_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn2_4
            // 
            this.TB_lijn2_4.BackColor = System.Drawing.Color.Yellow;
            this.TB_lijn2_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn2_4.Location = new System.Drawing.Point(491, 346);
            this.TB_lijn2_4.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn2_4.Multiline = true;
            this.TB_lijn2_4.Name = "TB_lijn2_4";
            this.TB_lijn2_4.ReadOnly = true;
            this.TB_lijn2_4.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn2_4.TabIndex = 19;
            this.TB_lijn2_4.Text = "2";
            this.TB_lijn2_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn5_1
            // 
            this.TB_lijn5_1.BackColor = System.Drawing.Color.Violet;
            this.TB_lijn5_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn5_1.Location = new System.Drawing.Point(253, 44);
            this.TB_lijn5_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn5_1.Multiline = true;
            this.TB_lijn5_1.Name = "TB_lijn5_1";
            this.TB_lijn5_1.ReadOnly = true;
            this.TB_lijn5_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn5_1.TabIndex = 0;
            this.TB_lijn5_1.Text = "5";
            this.TB_lijn5_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn5_2
            // 
            this.TB_lijn5_2.BackColor = System.Drawing.Color.Violet;
            this.TB_lijn5_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn5_2.Location = new System.Drawing.Point(770, 44);
            this.TB_lijn5_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn5_2.Multiline = true;
            this.TB_lijn5_2.Name = "TB_lijn5_2";
            this.TB_lijn5_2.ReadOnly = true;
            this.TB_lijn5_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn5_2.TabIndex = 19;
            this.TB_lijn5_2.Text = "5";
            this.TB_lijn5_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn5_3
            // 
            this.TB_lijn5_3.BackColor = System.Drawing.Color.Violet;
            this.TB_lijn5_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn5_3.Location = new System.Drawing.Point(109, 346);
            this.TB_lijn5_3.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn5_3.Multiline = true;
            this.TB_lijn5_3.Name = "TB_lijn5_3";
            this.TB_lijn5_3.ReadOnly = true;
            this.TB_lijn5_3.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn5_3.TabIndex = 19;
            this.TB_lijn5_3.Text = "5";
            this.TB_lijn5_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijn5_4
            // 
            this.TB_lijn5_4.BackColor = System.Drawing.Color.Violet;
            this.TB_lijn5_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn5_4.Location = new System.Drawing.Point(211, 346);
            this.TB_lijn5_4.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn5_4.Multiline = true;
            this.TB_lijn5_4.Name = "TB_lijn5_4";
            this.TB_lijn5_4.ReadOnly = true;
            this.TB_lijn5_4.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn5_4.TabIndex = 19;
            this.TB_lijn5_4.Text = "5";
            this.TB_lijn5_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_1
            // 
            this.TB_lijnVrij_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_1.Location = new System.Drawing.Point(559, 44);
            this.TB_lijnVrij_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_1.Multiline = true;
            this.TB_lijnVrij_1.Name = "TB_lijnVrij_1";
            this.TB_lijnVrij_1.ReadOnly = true;
            this.TB_lijnVrij_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_1.TabIndex = 0;
            this.TB_lijnVrij_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_10
            // 
            this.TB_lijnVrij_10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_10.Location = new System.Drawing.Point(821, 346);
            this.TB_lijnVrij_10.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_10.Multiline = true;
            this.TB_lijnVrij_10.Name = "TB_lijnVrij_10";
            this.TB_lijnVrij_10.ReadOnly = true;
            this.TB_lijnVrij_10.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_10.TabIndex = 43;
            this.TB_lijnVrij_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_2
            // 
            this.TB_lijnVrij_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_2.Location = new System.Drawing.Point(668, 44);
            this.TB_lijnVrij_2.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_2.Multiline = true;
            this.TB_lijnVrij_2.Name = "TB_lijnVrij_2";
            this.TB_lijnVrij_2.ReadOnly = true;
            this.TB_lijnVrij_2.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_2.TabIndex = 19;
            this.TB_lijnVrij_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_3
            // 
            this.TB_lijnVrij_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_3.Location = new System.Drawing.Point(7, 346);
            this.TB_lijnVrij_3.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_3.Multiline = true;
            this.TB_lijnVrij_3.Name = "TB_lijnVrij_3";
            this.TB_lijnVrij_3.ReadOnly = true;
            this.TB_lijnVrij_3.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_3.TabIndex = 67;
            this.TB_lijnVrij_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_4
            // 
            this.TB_lijnVrij_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_4.Location = new System.Drawing.Point(440, 346);
            this.TB_lijnVrij_4.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_4.Multiline = true;
            this.TB_lijnVrij_4.Name = "TB_lijnVrij_4";
            this.TB_lijnVrij_4.ReadOnly = true;
            this.TB_lijnVrij_4.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_4.TabIndex = 19;
            this.TB_lijnVrij_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_5
            // 
            this.TB_lijnVrij_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_5.Location = new System.Drawing.Point(542, 346);
            this.TB_lijnVrij_5.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_5.Multiline = true;
            this.TB_lijnVrij_5.Name = "TB_lijnVrij_5";
            this.TB_lijnVrij_5.ReadOnly = true;
            this.TB_lijnVrij_5.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_5.TabIndex = 19;
            this.TB_lijnVrij_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_6
            // 
            this.TB_lijnVrij_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_6.Location = new System.Drawing.Point(593, 346);
            this.TB_lijnVrij_6.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_6.Multiline = true;
            this.TB_lijnVrij_6.Name = "TB_lijnVrij_6";
            this.TB_lijnVrij_6.ReadOnly = true;
            this.TB_lijnVrij_6.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_6.TabIndex = 19;
            this.TB_lijnVrij_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_7
            // 
            this.TB_lijnVrij_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_7.Location = new System.Drawing.Point(668, 346);
            this.TB_lijnVrij_7.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_7.Multiline = true;
            this.TB_lijnVrij_7.Name = "TB_lijnVrij_7";
            this.TB_lijnVrij_7.ReadOnly = true;
            this.TB_lijnVrij_7.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_7.TabIndex = 25;
            this.TB_lijnVrij_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_8
            // 
            this.TB_lijnVrij_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_8.Location = new System.Drawing.Point(719, 346);
            this.TB_lijnVrij_8.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_8.Multiline = true;
            this.TB_lijnVrij_8.Name = "TB_lijnVrij_8";
            this.TB_lijnVrij_8.ReadOnly = true;
            this.TB_lijnVrij_8.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_8.TabIndex = 31;
            this.TB_lijnVrij_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_lijnVrij_9
            // 
            this.TB_lijnVrij_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TB_lijnVrij_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijnVrij_9.Location = new System.Drawing.Point(770, 346);
            this.TB_lijnVrij_9.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijnVrij_9.Multiline = true;
            this.TB_lijnVrij_9.Name = "TB_lijnVrij_9";
            this.TB_lijnVrij_9.ReadOnly = true;
            this.TB_lijnVrij_9.Size = new System.Drawing.Size(43, 30);
            this.TB_lijnVrij_9.TabIndex = 37;
            this.TB_lijnVrij_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_tramnummer
            // 
            this.TB_tramnummer.Location = new System.Drawing.Point(1082, 149);
            this.TB_tramnummer.Name = "TB_tramnummer";
            this.TB_tramnummer.Size = new System.Drawing.Size(92, 22);
            this.TB_tramnummer.TabIndex = 93;
            // 
            // btUitloggen
            // 
            this.btUitloggen.Location = new System.Drawing.Point(1251, 658);
            this.btUitloggen.Margin = new System.Windows.Forms.Padding(4);
            this.btUitloggen.Name = "btUitloggen";
            this.btUitloggen.Size = new System.Drawing.Size(84, 28);
            this.btUitloggen.TabIndex = 7;
            this.btUitloggen.Text = "Afmelden";
            this.btUitloggen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1137, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "ConnectieTestKnopDatabase";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.ErrorImage = global::TVS.Properties.Resources.Achtergrond;
            this.pictureBox2.Image = global::TVS.Properties.Resources.Achtergrond;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1350, 700);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // TB_lijn2_1
            // 
            this.TB_lijn2_1.BackColor = System.Drawing.Color.Yellow;
            this.TB_lijn2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_lijn2_1.Location = new System.Drawing.Point(202, 44);
            this.TB_lijn2_1.Margin = new System.Windows.Forms.Padding(4);
            this.TB_lijn2_1.Multiline = true;
            this.TB_lijn2_1.Name = "TB_lijn2_1";
            this.TB_lijn2_1.ReadOnly = true;
            this.TB_lijn2_1.Size = new System.Drawing.Size(43, 30);
            this.TB_lijn2_1.TabIndex = 0;
            this.TB_lijn2_1.Text = "2";
            this.TB_lijn2_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.GB_Reservering);
            this.Controls.Add(this.BTN_zetTramOpSpoor);
            this.Controls.Add(this.TB_tramnummer);
            this.Controls.Add(this.BTN_statusOpvragenTrams);
            this.Controls.Add(this.LBL_tramnummer);
            this.Controls.Add(this.TB_lijnVrij_3);
            this.Controls.Add(this.TB_lijnVrij_10);
            this.Controls.Add(this.TB_lijnVrij_9);
            this.Controls.Add(this.TB_lijnVrij_8);
            this.Controls.Add(this.TB_lijn17_1);
            this.Controls.Add(this.TB_lijnVrij_7);
            this.Controls.Add(this.TB_lijnVrij_6);
            this.Controls.Add(this.TB_lijnVrij_5);
            this.Controls.Add(this.TB_lijn2_4);
            this.Controls.Add(this.TB_lijnVrij_4);
            this.Controls.Add(this.TB_lijn1_3);
            this.Controls.Add(this.TB_lijn17_2);
            this.Controls.Add(this.TB_lijn13_1);
            this.Controls.Add(this.TB_lijn13_2);
            this.Controls.Add(this.TB_lijn1_2);
            this.Controls.Add(this.TB_lijn5_4);
            this.Controls.Add(this.TB_lijn5_2);
            this.Controls.Add(this.TB_lijn2_3);
            this.Controls.Add(this.TB_lijn10_2);
            this.Controls.Add(this.TB_lijn5_3);
            this.Controls.Add(this.TB_lijnVrij_2);
            this.Controls.Add(this.TB_lijn16_24_4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.btUitloggen);
            this.Controls.Add(this.TB_lijn16_24_3);
            this.Controls.Add(this.TB_lijnVrij_1);
            this.Controls.Add(this.TB_lijn10_1);
            this.Controls.Add(this.TB_lijn16_24_2);
            this.Controls.Add(this.TB_lijn2_2);
            this.Controls.Add(this.TB_lijn16_24_1);
            this.Controls.Add(this.TB_lijn1_1);
            this.Controls.Add(this.TB_lijn5_1);
            this.Controls.Add(this.TB_lijn2_1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 739);
            this.MinimumSize = new System.Drawing.Size(1364, 739);
            this.Name = "FormMain";
            this.Text = "GVB - FormMain";
            this.GB_Reservering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button BTN_statusOpvragenTrams;
        private System.Windows.Forms.Button BTN_zetTramOpSpoor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GB_Reservering;
        private System.Windows.Forms.Label LBL_tramnummer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TB_lijn10_1;
        private System.Windows.Forms.TextBox TB_lijn10_2;
        private System.Windows.Forms.TextBox TB_lijn13_1;
        private System.Windows.Forms.TextBox TB_lijn13_2;
        private System.Windows.Forms.TextBox TB_lijn16_24_1;
        private System.Windows.Forms.TextBox TB_lijn16_24_2;
        private System.Windows.Forms.TextBox TB_lijn16_24_3;
        private System.Windows.Forms.TextBox TB_lijn16_24_4;
        private System.Windows.Forms.TextBox TB_lijn17_1;
        private System.Windows.Forms.TextBox TB_lijn17_2;
        private System.Windows.Forms.TextBox TB_lijn1_1;
        private System.Windows.Forms.TextBox TB_lijn1_2;
        private System.Windows.Forms.TextBox TB_lijn1_3;
        private System.Windows.Forms.TextBox TB_lijn2_2;
        private System.Windows.Forms.TextBox TB_lijn2_3;
        private System.Windows.Forms.TextBox TB_lijn2_4;
        private System.Windows.Forms.TextBox TB_lijn5_1;
        private System.Windows.Forms.TextBox TB_lijn5_2;
        private System.Windows.Forms.TextBox TB_lijn5_3;
        private System.Windows.Forms.TextBox TB_lijn5_4;
        private System.Windows.Forms.TextBox TB_lijnVrij_10;
        private System.Windows.Forms.TextBox TB_lijnVrij_1;
        private System.Windows.Forms.TextBox TB_lijnVrij_2;
        private System.Windows.Forms.TextBox TB_lijnVrij_3;
        private System.Windows.Forms.TextBox TB_lijnVrij_4;
        private System.Windows.Forms.TextBox TB_lijnVrij_5;
        private System.Windows.Forms.TextBox TB_lijnVrij_6;
        private System.Windows.Forms.TextBox TB_lijnVrij_7;
        private System.Windows.Forms.TextBox TB_lijnVrij_8;
        private System.Windows.Forms.TextBox TB_lijnVrij_9;
        private ButtonSpoor buttonSpoor_12;
        private ButtonSpoor buttonSpoor_13;
        private ButtonSpoor buttonSpoor_14;
        private ButtonSpoor buttonSpoor_15;
        private ButtonSpoor buttonSpoor_16;
        private ButtonSpoor buttonSpoor_17;
        private ButtonSpoor buttonSpoor_18;
        private ButtonSpoor buttonSpoor_19;
        private ButtonSpoor buttonSpoor_20;
        private ButtonSpoor buttonSpoor_21;
        private ButtonSpoor buttonSpoor_30;
        private ButtonSpoor buttonSpoor_31;
        private ButtonSpoor buttonSpoor_32;
        private ButtonSpoor buttonSpoor_33;
        private ButtonSpoor buttonSpoor_34;
        private ButtonSpoor buttonSpoor_35;
        private ButtonSpoor buttonSpoor_36;
        private ButtonSpoor buttonSpoor_37;
        private ButtonSpoor buttonSpoor_38;
        private ButtonSpoor buttonSpoor_40;
        private ButtonSpoor buttonSpoor_41;
        private ButtonSpoor buttonSpoor_42;
        private ButtonSpoor buttonSpoor_43;
        private ButtonSpoor buttonSpoor_44;
        private ButtonSpoor buttonSpoor_45;
        private ButtonSpoor buttonSpoor_51;
        private ButtonSpoor buttonSpoor_52;
        private ButtonSpoor buttonSpoor_53;
        private ButtonSpoor buttonSpoor_54;
        private ButtonSpoor buttonSpoor_55;
        private ButtonSpoor buttonSpoor_56;
        private ButtonSpoor buttonSpoor_57;
        private ButtonSpoor buttonSpoor_58;
        private ButtonSpoor buttonSpoor_61;
        private ButtonSpoor buttonSpoor_62;
        private ButtonSpoor buttonSpoor_63;
        private ButtonSpoor buttonSpoor_64;
        private ButtonSpoor buttonSpoor_74;
        private ButtonSpoor buttonSpoor_75;
        private ButtonSpoor buttonSpoor_76;
        private ButtonSpoor buttonSpoor_77;
        private System.Windows.Forms.TextBox TB_tramnummer;
        private ButtonSegment buttonSegment_12_1;
        private ButtonSegment buttonSegment_13_1;
        private ButtonSegment buttonSegment_14_1;
        private ButtonSegment buttonSegment_15_1;
        private ButtonSegment buttonSegment_16_1;
        private ButtonSegment buttonSegment_17_1;
        private ButtonSegment buttonSegment_18_1;
        private ButtonSegment buttonSegment_19_1;
        private ButtonSegment buttonSegment_20_1;
        private ButtonSegment buttonSegment_21_1;
        private ButtonSegment buttonSegment_30_1;
        private ButtonSegment buttonSegment_30_2;
        private ButtonSegment buttonSegment_30_3;
        private ButtonSegment buttonSegment_31_1;
        private ButtonSegment buttonSegment_31_2;
        private ButtonSegment buttonSegment_31_3;
        private ButtonSegment buttonSegment_32_1;
        private ButtonSegment buttonSegment_32_2;
        private ButtonSegment buttonSegment_32_3;
        private ButtonSegment buttonSegment_32_4;
        private ButtonSegment buttonSegment_33_1;
        private ButtonSegment buttonSegment_33_2;
        private ButtonSegment buttonSegment_33_3;
        private ButtonSegment buttonSegment_33_4;
        private ButtonSegment buttonSegment_34_1;
        private ButtonSegment buttonSegment_34_2;
        private ButtonSegment buttonSegment_34_3;
        private ButtonSegment buttonSegment_34_4;
        private ButtonSegment buttonSegment_35_1;
        private ButtonSegment buttonSegment_35_2;
        private ButtonSegment buttonSegment_35_3;
        private ButtonSegment buttonSegment_35_4;
        private ButtonSegment buttonSegment_36_1;
        private ButtonSegment buttonSegment_36_2;
        private ButtonSegment buttonSegment_36_3;
        private ButtonSegment buttonSegment_36_4;
        private ButtonSegment buttonSegment_37_1;
        private ButtonSegment buttonSegment_37_2;
        private ButtonSegment buttonSegment_37_3;
        private ButtonSegment buttonSegment_37_4;
        private ButtonSegment buttonSegment_38_1;
        private ButtonSegment buttonSegment_38_2;
        private ButtonSegment buttonSegment_38_3;
        private ButtonSegment buttonSegment_38_4;
        private ButtonSegment buttonSegment_40_1;
        private ButtonSegment buttonSegment_40_2;
        private ButtonSegment buttonSegment_40_3;
        private ButtonSegment buttonSegment_40_4;
        private ButtonSegment buttonSegment_40_5;
        private ButtonSegment buttonSegment_40_6;
        private ButtonSegment buttonSegment_40_7;
        private ButtonSegment buttonSegment_41_1;
        private ButtonSegment buttonSegment_41_2;
        private ButtonSegment buttonSegment_41_3;
        private ButtonSegment buttonSegment_41_4;
        private ButtonSegment buttonSegment_42_1;
        private ButtonSegment buttonSegment_42_2;
        private ButtonSegment buttonSegment_42_3;
        private ButtonSegment buttonSegment_42_4;
        private ButtonSegment buttonSegment_43_1;
        private ButtonSegment buttonSegment_43_2;
        private ButtonSegment buttonSegment_43_3;
        private ButtonSegment buttonSegment_43_4;
        private ButtonSegment buttonSegment_44_1;
        private ButtonSegment buttonSegment_44_2;
        private ButtonSegment buttonSegment_44_3;
        private ButtonSegment buttonSegment_44_4;
        private ButtonSegment buttonSegment_45_10;
        private ButtonSegment buttonSegment_45_1;
        private ButtonSegment buttonSegment_45_2;
        private ButtonSegment buttonSegment_45_3;
        private ButtonSegment buttonSegment_45_4;
        private ButtonSegment buttonSegment_45_5;
        private ButtonSegment buttonSegment_45_6;
        private ButtonSegment buttonSegment_45_7;
        private ButtonSegment buttonSegment_45_8;
        private ButtonSegment buttonSegment_45_9;
        private ButtonSegment buttonSegment_51_1;
        private ButtonSegment buttonSegment_51_2;
        private ButtonSegment buttonSegment_51_3;
        private ButtonSegment buttonSegment_51_4;
        private ButtonSegment buttonSegment_51_5;
        private ButtonSegment buttonSegment_51_6;
        private ButtonSegment buttonSegment_52_1;
        private ButtonSegment buttonSegment_52_2;
        private ButtonSegment buttonSegment_52_3;
        private ButtonSegment buttonSegment_52_4;
        private ButtonSegment buttonSegment_52_5;
        private ButtonSegment buttonSegment_52_6;
        private ButtonSegment buttonSegment_52_7;
        private ButtonSegment buttonSegment_53_1;
        private ButtonSegment buttonSegment_53_2;
        private ButtonSegment buttonSegment_53_3;
        private ButtonSegment buttonSegment_53_4;
        private ButtonSegment buttonSegment_53_5;
        private ButtonSegment buttonSegment_53_6;
        private ButtonSegment buttonSegment_53_7;
        private ButtonSegment buttonSegment_54_1;
        private ButtonSegment buttonSegment_54_2;
        private ButtonSegment buttonSegment_54_3;
        private ButtonSegment buttonSegment_54_4;
        private ButtonSegment buttonSegment_54_5;
        private ButtonSegment buttonSegment_54_6;
        private ButtonSegment buttonSegment_54_7;
        private ButtonSegment buttonSegment_55_1;
        private ButtonSegment buttonSegment_55_2;
        private ButtonSegment buttonSegment_55_3;
        private ButtonSegment buttonSegment_55_4;
        private ButtonSegment buttonSegment_55_5;
        private ButtonSegment buttonSegment_55_6;
        private ButtonSegment buttonSegment_55_7;
        private ButtonSegment buttonSegment_55_8;
        private ButtonSegment buttonSegment_56_1;
        private ButtonSegment buttonSegment_56_2;
        private ButtonSegment buttonSegment_56_3;
        private ButtonSegment buttonSegment_56_4;
        private ButtonSegment buttonSegment_56_5;
        private ButtonSegment buttonSegment_56_6;
        private ButtonSegment buttonSegment_56_7;
        private ButtonSegment buttonSegment_56_8;
        private ButtonSegment buttonSegment_57_1;
        private ButtonSegment buttonSegment_57_2;
        private ButtonSegment buttonSegment_57_3;
        private ButtonSegment buttonSegment_57_4;
        private ButtonSegment buttonSegment_57_5;
        private ButtonSegment buttonSegment_57_6;
        private ButtonSegment buttonSegment_57_7;
        private ButtonSegment buttonSegment_57_8;
        private ButtonSegment buttonSegment_58_1;
        private ButtonSegment buttonSegment_58_2;
        private ButtonSegment buttonSegment_58_3;
        private ButtonSegment buttonSegment_58_4;
        private ButtonSegment buttonSegment_61_1;
        private ButtonSegment buttonSegment_61_2;
        private ButtonSegment buttonSegment_61_3;
        private ButtonSegment buttonSegment_62_1;
        private ButtonSegment buttonSegment_62_2;
        private ButtonSegment buttonSegment_62_3;
        private ButtonSegment buttonSegment_63_1;
        private ButtonSegment buttonSegment_63_2;
        private ButtonSegment buttonSegment_63_3;
        private ButtonSegment buttonSegment_63_4;
        private ButtonSegment buttonSegment_64_1;
        private ButtonSegment buttonSegment_64_2;
        private ButtonSegment buttonSegment_64_3;
        private ButtonSegment buttonSegment_64_4;
        private ButtonSegment buttonSegment_64_5;
        private ButtonSegment buttonSegment_74_1;
        private ButtonSegment buttonSegment_74_2;
        private ButtonSegment buttonSegment_74_3;
        private ButtonSegment buttonSegment_74_4;
        private ButtonSegment buttonSegment_74_5;
        private ButtonSegment buttonSegment_75_1;
        private ButtonSegment buttonSegment_75_2;
        private ButtonSegment buttonSegment_75_3;
        private ButtonSegment buttonSegment_75_4;
        private ButtonSegment buttonSegment_75_5;
        private ButtonSegment buttonSegment_76_1;
        private ButtonSegment buttonSegment_76_2;
        private ButtonSegment buttonSegment_76_3;
        private ButtonSegment buttonSegment_76_4;
        private ButtonSegment buttonSegment_76_5;
        private ButtonSegment buttonSegment_77_1;
        private ButtonSegment buttonSegment_77_2;
        private ButtonSegment buttonSegment_77_3;
        private ButtonSegment buttonSegment_77_4;
        private ButtonSegment buttonSegment_77_5;
        public System.Windows.Forms.Button btUitloggen;
        private System.Windows.Forms.TextBox TB_lijn2_1;
    }
}

