namespace HCI_Projekat.Forms.VolonterForms
{
    partial class WorkWithVolonters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithVolonters));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzavljanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbNewContact = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.lbSifra = new System.Windows.Forms.Label();
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.lbDatumRodjenja = new System.Windows.Forms.Label();
            this.lbJMB = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.tbMjestoPrebivalista = new System.Windows.Forms.TextBox();
            this.lbMjestoPrebivalista = new System.Windows.Forms.Label();
            this.lbPol = new System.Windows.Forms.Label();
            this.lbDrzavljanstvo = new System.Windows.Forms.Label();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.tbDrzavljanstvo = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblWorkWithVolonter = new System.Windows.Forms.Label();
            this.btnRasporediUKamp = new System.Windows.Forms.Button();
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
            this.KorisnickoIme,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.Pol,
            this.Drzavljanstvo,
            this.Prebivaliste,
            this.JMB});
            this.dataGridView1.Location = new System.Drawing.Point(28, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(734, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Width = 127;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 75;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.HeaderText = "Datum rodj";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            this.DatumRodjenja.Width = 112;
            // 
            // Pol
            // 
            this.Pol.HeaderText = "Pol";
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Width = 31;
            // 
            // Drzavljanstvo
            // 
            this.Drzavljanstvo.HeaderText = "Drzavljanstvo";
            this.Drzavljanstvo.Name = "Drzavljanstvo";
            this.Drzavljanstvo.ReadOnly = true;
            this.Drzavljanstvo.Width = 97;
            // 
            // Prebivaliste
            // 
            this.Prebivaliste.HeaderText = "Prebivaliste";
            this.Prebivaliste.Name = "Prebivaliste";
            this.Prebivaliste.ReadOnly = true;
            this.Prebivaliste.Width = 98;
            // 
            // JMB
            // 
            this.JMB.HeaderText = "JMB";
            this.JMB.Name = "JMB";
            this.JMB.ReadOnly = true;
            this.JMB.Width = 91;
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Location = new System.Drawing.Point(28, 76);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(734, 20);
            this.tbFilter.TabIndex = 0;
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
            this.gbNewContact.Controls.Add(this.tbSifra);
            this.gbNewContact.Controls.Add(this.lbSifra);
            this.gbNewContact.Controls.Add(this.tbKorisnickoIme);
            this.gbNewContact.Controls.Add(this.lblKorisnickoIme);
            this.gbNewContact.Controls.Add(this.tbJMB);
            this.gbNewContact.Controls.Add(this.lbDatumRodjenja);
            this.gbNewContact.Controls.Add(this.lbJMB);
            this.gbNewContact.Controls.Add(this.dtpDatumRodjenja);
            this.gbNewContact.Controls.Add(this.tbMjestoPrebivalista);
            this.gbNewContact.Controls.Add(this.lbMjestoPrebivalista);
            this.gbNewContact.Controls.Add(this.lbPol);
            this.gbNewContact.Controls.Add(this.lbDrzavljanstvo);
            this.gbNewContact.Controls.Add(this.cbPol);
            this.gbNewContact.Controls.Add(this.tbDrzavljanstvo);
            this.gbNewContact.Controls.Add(this.tbPrezime);
            this.gbNewContact.Controls.Add(this.lbPrezime);
            this.gbNewContact.Controls.Add(this.tbIme);
            this.gbNewContact.Controls.Add(this.lbIme);
            this.gbNewContact.Location = new System.Drawing.Point(28, 357);
            this.gbNewContact.Name = "gbNewContact";
            this.gbNewContact.Size = new System.Drawing.Size(734, 145);
            this.gbNewContact.TabIndex = 4;
            this.gbNewContact.TabStop = false;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.Info;
            this.btnOcisti.Location = new System.Drawing.Point(593, 114);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 23);
            this.btnOcisti.TabIndex = 19;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(527, 75);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.PasswordChar = '*';
            this.tbSifra.Size = new System.Drawing.Size(141, 20);
            this.tbSifra.TabIndex = 8;
            // 
            // lbSifra
            // 
            this.lbSifra.AutoSize = true;
            this.lbSifra.Location = new System.Drawing.Point(524, 59);
            this.lbSifra.Name = "lbSifra";
            this.lbSifra.Size = new System.Drawing.Size(31, 13);
            this.lbSifra.TabIndex = 17;
            this.lbSifra.Text = "Sifra:";
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(527, 36);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(141, 20);
            this.tbKorisnickoIme.TabIndex = 4;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(524, 20);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorisnickoIme.TabIndex = 15;
            this.lblKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // tbJMB
            // 
            this.tbJMB.Location = new System.Drawing.Point(369, 75);
            this.tbJMB.Name = "tbJMB";
            this.tbJMB.Size = new System.Drawing.Size(141, 20);
            this.tbJMB.TabIndex = 7;
            // 
            // lbDatumRodjenja
            // 
            this.lbDatumRodjenja.AutoSize = true;
            this.lbDatumRodjenja.Location = new System.Drawing.Point(250, 98);
            this.lbDatumRodjenja.Name = "lbDatumRodjenja";
            this.lbDatumRodjenja.Size = new System.Drawing.Size(81, 13);
            this.lbDatumRodjenja.TabIndex = 13;
            this.lbDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // lbJMB
            // 
            this.lbJMB.AutoSize = true;
            this.lbJMB.Location = new System.Drawing.Point(366, 59);
            this.lbJMB.Name = "lbJMB";
            this.lbJMB.Size = new System.Drawing.Size(31, 13);
            this.lbJMB.TabIndex = 12;
            this.lbJMB.Text = "JMB:";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(253, 114);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(210, 20);
            this.dtpDatumRodjenja.TabIndex = 9;
            // 
            // tbMjestoPrebivalista
            // 
            this.tbMjestoPrebivalista.Location = new System.Drawing.Point(369, 36);
            this.tbMjestoPrebivalista.Name = "tbMjestoPrebivalista";
            this.tbMjestoPrebivalista.Size = new System.Drawing.Size(141, 20);
            this.tbMjestoPrebivalista.TabIndex = 3;
            // 
            // lbMjestoPrebivalista
            // 
            this.lbMjestoPrebivalista.AutoSize = true;
            this.lbMjestoPrebivalista.Location = new System.Drawing.Point(366, 20);
            this.lbMjestoPrebivalista.Name = "lbMjestoPrebivalista";
            this.lbMjestoPrebivalista.Size = new System.Drawing.Size(97, 13);
            this.lbMjestoPrebivalista.TabIndex = 9;
            this.lbMjestoPrebivalista.Text = "Mjesto prebivalista:";
            // 
            // lbPol
            // 
            this.lbPol.AutoSize = true;
            this.lbPol.Location = new System.Drawing.Point(219, 59);
            this.lbPol.Name = "lbPol";
            this.lbPol.Size = new System.Drawing.Size(25, 13);
            this.lbPol.TabIndex = 6;
            this.lbPol.Text = "Pol:";
            // 
            // lbDrzavljanstvo
            // 
            this.lbDrzavljanstvo.AutoSize = true;
            this.lbDrzavljanstvo.Location = new System.Drawing.Point(75, 59);
            this.lbDrzavljanstvo.Name = "lbDrzavljanstvo";
            this.lbDrzavljanstvo.Size = new System.Drawing.Size(74, 13);
            this.lbDrzavljanstvo.TabIndex = 4;
            this.lbDrzavljanstvo.Text = "Drzavljanstvo:";
            // 
            // cbPol
            // 
            this.cbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbPol.Location = new System.Drawing.Point(222, 74);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(141, 21);
            this.cbPol.TabIndex = 6;
            // 
            // tbDrzavljanstvo
            // 
            this.tbDrzavljanstvo.Location = new System.Drawing.Point(75, 75);
            this.tbDrzavljanstvo.Name = "tbDrzavljanstvo";
            this.tbDrzavljanstvo.Size = new System.Drawing.Size(141, 20);
            this.tbDrzavljanstvo.TabIndex = 5;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(222, 36);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(141, 20);
            this.tbPrezime.TabIndex = 2;
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(219, 20);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(47, 13);
            this.lbPrezime.TabIndex = 2;
            this.lbPrezime.Text = "Prezime:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(75, 36);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(141, 20);
            this.tbIme.TabIndex = 1;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(75, 20);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(27, 13);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(28, 515);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 39);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj volontera";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnIzmijeni.FlatAppearance.BorderSize = 0;
            this.btnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzmijeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmijeni.Location = new System.Drawing.Point(215, 515);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(173, 39);
            this.btnIzmijeni.TabIndex = 11;
            this.btnIzmijeni.Text = "Izmijeni volontera";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(402, 515);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(173, 39);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obriši volontera";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblWorkWithVolonter
            // 
            this.lblWorkWithVolonter.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkWithVolonter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblWorkWithVolonter.Location = new System.Drawing.Point(228, 18);
            this.lblWorkWithVolonter.Name = "lblWorkWithVolonter";
            this.lblWorkWithVolonter.Size = new System.Drawing.Size(299, 37);
            this.lblWorkWithVolonter.TabIndex = 15;
            this.lblWorkWithVolonter.Text = "Rad sa volonterima";
            this.lblWorkWithVolonter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWorkWithVolonter.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnRasporediUKamp
            // 
            this.btnRasporediUKamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnRasporediUKamp.FlatAppearance.BorderSize = 0;
            this.btnRasporediUKamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRasporediUKamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRasporediUKamp.ForeColor = System.Drawing.Color.White;
            this.btnRasporediUKamp.Location = new System.Drawing.Point(589, 515);
            this.btnRasporediUKamp.Name = "btnRasporediUKamp";
            this.btnRasporediUKamp.Size = new System.Drawing.Size(173, 39);
            this.btnRasporediUKamp.TabIndex = 13;
            this.btnRasporediUKamp.Text = "Rasporedi u kamp";
            this.btnRasporediUKamp.UseVisualStyleBackColor = false;
            this.btnRasporediUKamp.Click += new System.EventHandler(this.btnRasporediUKamp_Click);
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
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkWithVolonters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRasporediUKamp);
            this.Controls.Add(this.lblWorkWithVolonter);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.gbNewContact);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkWithVolonters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.WorkWithVolonters_Load_1);
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
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lbPol;
        private System.Windows.Forms.Label lbDrzavljanstvo;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.TextBox tbDrzavljanstvo;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.TextBox tbMjestoPrebivalista;
        private System.Windows.Forms.Label lbMjestoPrebivalista;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label lbSifra;
        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox tbJMB;
        private System.Windows.Forms.Label lbDatumRodjenja;
        private System.Windows.Forms.Label lbJMB;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label lblWorkWithVolonter;
        private System.Windows.Forms.Button btnRasporediUKamp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzavljanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prebivaliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
    }
}