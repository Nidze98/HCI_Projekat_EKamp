namespace HCI_Projekat.Forms.AdminForms
{
    partial class WorkWithCamps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithCamps));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazivKampa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaduzeniVolonter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbNewContact = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.lbDrzava = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.lbGrad = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbNazivKampa = new System.Windows.Forms.Label();
            this.btnKreirajKamp = new System.Windows.Forms.Button();
            this.btnIzmijeniKamp = new System.Windows.Forms.Button();
            this.btnObrisiKamp = new System.Windows.Forms.Button();
            this.lbWorkWithCamps = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbNewContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivKampa,
            this.Drzava,
            this.Grad,
            this.Status,
            this.ZaduzeniVolonter,
            this.BrojKorisnika});
            this.dataGridView1.Location = new System.Drawing.Point(28, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(734, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NazivKampa
            // 
            this.NazivKampa.HeaderText = "Naziv kampa";
            this.NazivKampa.Name = "NazivKampa";
            this.NazivKampa.ReadOnly = true;
            this.NazivKampa.Width = 150;
            // 
            // Drzava
            // 
            this.Drzava.HeaderText = "Drzava";
            this.Drzava.Name = "Drzava";
            this.Drzava.Width = 90;
            // 
            // Grad
            // 
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.Width = 90;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ZaduzeniVolonter
            // 
            this.ZaduzeniVolonter.HeaderText = "Zaduzeni volonter";
            this.ZaduzeniVolonter.Name = "ZaduzeniVolonter";
            this.ZaduzeniVolonter.ReadOnly = true;
            this.ZaduzeniVolonter.Width = 153;
            // 
            // BrojKorisnika
            // 
            this.BrojKorisnika.HeaderText = "Broj korisnika";
            this.BrojKorisnika.Name = "BrojKorisnika";
            this.BrojKorisnika.ReadOnly = true;
            this.BrojKorisnika.Width = 148;
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(28, 76);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(734, 20);
            this.tbFilter.TabIndex = 3;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(25, 60);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(32, 13);
            this.lbFilter.TabIndex = 2;
            this.lbFilter.Text = "Filter:";
            // 
            // gbNewContact
            // 
            this.gbNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewContact.Controls.Add(this.btnOcisti);
            this.gbNewContact.Controls.Add(this.tbDrzava);
            this.gbNewContact.Controls.Add(this.lbDrzava);
            this.gbNewContact.Controls.Add(this.lbStatus);
            this.gbNewContact.Controls.Add(this.cbStatus);
            this.gbNewContact.Controls.Add(this.tbGrad);
            this.gbNewContact.Controls.Add(this.lbGrad);
            this.gbNewContact.Controls.Add(this.tbIme);
            this.gbNewContact.Controls.Add(this.lbNazivKampa);
            this.gbNewContact.Location = new System.Drawing.Point(28, 357);
            this.gbNewContact.Name = "gbNewContact";
            this.gbNewContact.Size = new System.Drawing.Size(734, 145);
            this.gbNewContact.TabIndex = 4;
            this.gbNewContact.TabStop = false;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.Info;
            this.btnOcisti.Location = new System.Drawing.Point(326, 95);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 23);
            this.btnOcisti.TabIndex = 19;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(369, 36);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.Size = new System.Drawing.Size(141, 20);
            this.tbDrzava.TabIndex = 7;
            // 
            // lbDrzava
            // 
            this.lbDrzava.AutoSize = true;
            this.lbDrzava.Location = new System.Drawing.Point(366, 20);
            this.lbDrzava.Name = "lbDrzava";
            this.lbDrzava.Size = new System.Drawing.Size(44, 13);
            this.lbDrzava.TabIndex = 9;
            this.lbDrzava.Text = "Drzava:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(524, 20);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cbStatus.Location = new System.Drawing.Point(516, 36);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(141, 21);
            this.cbStatus.TabIndex = 10;
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(222, 36);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(141, 20);
            this.tbGrad.TabIndex = 3;
            // 
            // lbGrad
            // 
            this.lbGrad.AutoSize = true;
            this.lbGrad.Location = new System.Drawing.Point(219, 20);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(33, 13);
            this.lbGrad.TabIndex = 2;
            this.lbGrad.Text = "Grad:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(75, 36);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(141, 20);
            this.tbIme.TabIndex = 1;
            // 
            // lbNazivKampa
            // 
            this.lbNazivKampa.AutoSize = true;
            this.lbNazivKampa.Location = new System.Drawing.Point(75, 20);
            this.lbNazivKampa.Name = "lbNazivKampa";
            this.lbNazivKampa.Size = new System.Drawing.Size(72, 13);
            this.lbNazivKampa.TabIndex = 0;
            this.lbNazivKampa.Text = "Naziv kampa:";
            // 
            // btnKreirajKamp
            // 
            this.btnKreirajKamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnKreirajKamp.FlatAppearance.BorderSize = 0;
            this.btnKreirajKamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajKamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajKamp.ForeColor = System.Drawing.Color.White;
            this.btnKreirajKamp.Location = new System.Drawing.Point(28, 515);
            this.btnKreirajKamp.Name = "btnKreirajKamp";
            this.btnKreirajKamp.Size = new System.Drawing.Size(212, 39);
            this.btnKreirajKamp.TabIndex = 8;
            this.btnKreirajKamp.Text = "Kreiraj kamp";
            this.btnKreirajKamp.UseVisualStyleBackColor = false;
            this.btnKreirajKamp.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeniKamp
            // 
            this.btnIzmijeniKamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnIzmijeniKamp.FlatAppearance.BorderSize = 0;
            this.btnIzmijeniKamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeniKamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzmijeniKamp.ForeColor = System.Drawing.Color.White;
            this.btnIzmijeniKamp.Location = new System.Drawing.Point(289, 515);
            this.btnIzmijeniKamp.Name = "btnIzmijeniKamp";
            this.btnIzmijeniKamp.Size = new System.Drawing.Size(212, 39);
            this.btnIzmijeniKamp.TabIndex = 9;
            this.btnIzmijeniKamp.Text = "Izmijeni kamp";
            this.btnIzmijeniKamp.UseVisualStyleBackColor = false;
            this.btnIzmijeniKamp.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisiKamp
            // 
            this.btnObrisiKamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnObrisiKamp.FlatAppearance.BorderSize = 0;
            this.btnObrisiKamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiKamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiKamp.ForeColor = System.Drawing.Color.White;
            this.btnObrisiKamp.Location = new System.Drawing.Point(550, 515);
            this.btnObrisiKamp.Name = "btnObrisiKamp";
            this.btnObrisiKamp.Size = new System.Drawing.Size(212, 39);
            this.btnObrisiKamp.TabIndex = 10;
            this.btnObrisiKamp.Text = "Obriši kamp";
            this.btnObrisiKamp.UseVisualStyleBackColor = false;
            this.btnObrisiKamp.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lbWorkWithCamps
            // 
            this.lbWorkWithCamps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkWithCamps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbWorkWithCamps.Location = new System.Drawing.Point(226, 18);
            this.lbWorkWithCamps.Name = "lbWorkWithCamps";
            this.lbWorkWithCamps.Size = new System.Drawing.Size(327, 37);
            this.lbWorkWithCamps.TabIndex = 15;
            this.lbWorkWithCamps.Text = "Rad sa kampovima";
            this.lbWorkWithCamps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(25, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkWithCamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbWorkWithCamps);
            this.Controls.Add(this.btnObrisiKamp);
            this.Controls.Add(this.btnIzmijeniKamp);
            this.Controls.Add(this.gbNewContact);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKreirajKamp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkWithCamps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.WorkWithCamps_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbNewContact.ResumeLayout(false);
            this.gbNewContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.GroupBox gbNewContact;
        private System.Windows.Forms.Button btnKreirajKamp;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.Label lbGrad;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbNazivKampa;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.Label lbDrzava;
        private System.Windows.Forms.Button btnIzmijeniKamp;
        private System.Windows.Forms.Button btnObrisiKamp;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label lbWorkWithCamps;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKampa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaduzeniVolonter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKorisnika;
    }
}