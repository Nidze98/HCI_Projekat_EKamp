namespace HCI_Projekat.Forms.AdminForms
{
    partial class WorkWithAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithAdmins));
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
            this.lbKorisnickoIme = new System.Windows.Forms.Label();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.lbDatumRodj = new System.Windows.Forms.Label();
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
            this.btnDodajAdmina = new System.Windows.Forms.Button();
            this.btnIzmijeniAdmina = new System.Windows.Forms.Button();
            this.btnObrisiAdmina = new System.Windows.Forms.Button();
            this.lbRadSaAdministratorimaTop = new System.Windows.Forms.Label();
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
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
            this.lbFilter.Click += new System.EventHandler(this.lbFilter_Click);
            // 
            // gbNewContact
            // 
            this.gbNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNewContact.Controls.Add(this.btnOcisti);
            this.gbNewContact.Controls.Add(this.tbSifra);
            this.gbNewContact.Controls.Add(this.lbSifra);
            this.gbNewContact.Controls.Add(this.tbKorisnickoIme);
            this.gbNewContact.Controls.Add(this.lbKorisnickoIme);
            this.gbNewContact.Controls.Add(this.tbJMB);
            this.gbNewContact.Controls.Add(this.lbDatumRodj);
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
            // lbKorisnickoIme
            // 
            this.lbKorisnickoIme.AutoSize = true;
            this.lbKorisnickoIme.Location = new System.Drawing.Point(524, 20);
            this.lbKorisnickoIme.Name = "lbKorisnickoIme";
            this.lbKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lbKorisnickoIme.TabIndex = 15;
            this.lbKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // tbJMB
            // 
            this.tbJMB.Location = new System.Drawing.Point(369, 75);
            this.tbJMB.Name = "tbJMB";
            this.tbJMB.Size = new System.Drawing.Size(141, 20);
            this.tbJMB.TabIndex = 7;
            // 
            // lbDatumRodj
            // 
            this.lbDatumRodj.AutoSize = true;
            this.lbDatumRodj.Location = new System.Drawing.Point(250, 98);
            this.lbDatumRodj.Name = "lbDatumRodj";
            this.lbDatumRodj.Size = new System.Drawing.Size(81, 13);
            this.lbDatumRodj.TabIndex = 13;
            this.lbDatumRodj.Text = "Datum rodjenja:";
            // 
            // lbJMB
            // 
            this.lbJMB.AutoSize = true;
            this.lbJMB.Location = new System.Drawing.Point(366, 59);
            this.lbJMB.Name = "lbJMB";
            this.lbJMB.Size = new System.Drawing.Size(31, 13);
            this.lbJMB.TabIndex = 12;
            this.lbJMB.Text = "JMB:";
            this.lbJMB.Click += new System.EventHandler(this.label3_Click);
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
            this.lbPol.Click += new System.EventHandler(this.lbGroup_Click);
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
            this.lbIme.Click += new System.EventHandler(this.lbFirstName_Click);
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDodajAdmina.FlatAppearance.BorderSize = 0;
            this.btnDodajAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajAdmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAdmina.ForeColor = System.Drawing.Color.White;
            this.btnDodajAdmina.Location = new System.Drawing.Point(28, 515);
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.Size = new System.Drawing.Size(212, 39);
            this.btnDodajAdmina.TabIndex = 10;
            this.btnDodajAdmina.Text = "Dodaj admina";
            this.btnDodajAdmina.UseVisualStyleBackColor = false;
            this.btnDodajAdmina.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeniAdmina
            // 
            this.btnIzmijeniAdmina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnIzmijeniAdmina.FlatAppearance.BorderSize = 0;
            this.btnIzmijeniAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeniAdmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzmijeniAdmina.ForeColor = System.Drawing.Color.White;
            this.btnIzmijeniAdmina.Location = new System.Drawing.Point(289, 515);
            this.btnIzmijeniAdmina.Name = "btnIzmijeniAdmina";
            this.btnIzmijeniAdmina.Size = new System.Drawing.Size(212, 39);
            this.btnIzmijeniAdmina.TabIndex = 11;
            this.btnIzmijeniAdmina.Text = "Izmijeni admina";
            this.btnIzmijeniAdmina.UseVisualStyleBackColor = false;
            this.btnIzmijeniAdmina.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisiAdmina
            // 
            this.btnObrisiAdmina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnObrisiAdmina.FlatAppearance.BorderSize = 0;
            this.btnObrisiAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiAdmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiAdmina.ForeColor = System.Drawing.Color.White;
            this.btnObrisiAdmina.Location = new System.Drawing.Point(550, 515);
            this.btnObrisiAdmina.Name = "btnObrisiAdmina";
            this.btnObrisiAdmina.Size = new System.Drawing.Size(212, 39);
            this.btnObrisiAdmina.TabIndex = 12;
            this.btnObrisiAdmina.Text = "Obrisi admina";
            this.btnObrisiAdmina.UseVisualStyleBackColor = false;
            this.btnObrisiAdmina.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lbRadSaAdministratorimaTop
            // 
            this.lbRadSaAdministratorimaTop.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRadSaAdministratorimaTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbRadSaAdministratorimaTop.Location = new System.Drawing.Point(245, 18);
            this.lbRadSaAdministratorimaTop.Name = "lbRadSaAdministratorimaTop";
            this.lbRadSaAdministratorimaTop.Size = new System.Drawing.Size(373, 37);
            this.lbRadSaAdministratorimaTop.TabIndex = 15;
            this.lbRadSaAdministratorimaTop.Text = "Rad sa administratorima";
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
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WorkWithAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbRadSaAdministratorimaTop);
            this.Controls.Add(this.btnObrisiAdmina);
            this.Controls.Add(this.btnIzmijeniAdmina);
            this.Controls.Add(this.gbNewContact);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodajAdmina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkWithAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.WorkWithAdmins_Load);
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
        private System.Windows.Forms.Button btnDodajAdmina;
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
        private System.Windows.Forms.Label lbKorisnickoIme;
        private System.Windows.Forms.TextBox tbJMB;
        private System.Windows.Forms.Label lbDatumRodj;
        private System.Windows.Forms.Label lbJMB;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnIzmijeniAdmina;
        private System.Windows.Forms.Button btnObrisiAdmina;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label lbRadSaAdministratorimaTop;
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