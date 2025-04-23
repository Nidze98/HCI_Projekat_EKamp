namespace HCI_Projekat.Forms
{
    partial class VolonterWorkWithKorisniciKampa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolonterWorkWithKorisniciKampa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drzavljanstvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dolazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odlazak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbNewContact = new System.Windows.Forms.GroupBox();
            this.lbDo = new System.Windows.Forms.Label();
            this.lbOd = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.tbTipNesrece = new System.Windows.Forms.TextBox();
            this.lbTipNesrece = new System.Windows.Forms.Label();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.lbDatumRodj = new System.Windows.Forms.Label();
            this.lbJMB = new System.Windows.Forms.Label();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
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
            this.btnDodajKorisnikaKampa = new System.Windows.Forms.Button();
            this.btnIzmijeniKorisnikaKampa = new System.Windows.Forms.Button();
            this.btnObrisiKorisnikaKampa = new System.Windows.Forms.Button();
            this.lbDobrodosliZaduzeniSte = new System.Windows.Forms.Label();
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
            this.Ime,
            this.Prezime,
            this.JMB,
            this.Drzavljanstvo,
            this.Pol,
            this.Dolazak,
            this.Odlazak,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(28, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(734, 261);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // JMB
            // 
            this.JMB.HeaderText = "JMB";
            this.JMB.Name = "JMB";
            this.JMB.ReadOnly = true;
            // 
            // Drzavljanstvo
            // 
            this.Drzavljanstvo.HeaderText = "Drzavljanstvo";
            this.Drzavljanstvo.Name = "Drzavljanstvo";
            this.Drzavljanstvo.ReadOnly = true;
            // 
            // Pol
            // 
            this.Pol.HeaderText = "Pol";
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Width = 31;
            // 
            // Dolazak
            // 
            this.Dolazak.HeaderText = "Dolazak";
            this.Dolazak.Name = "Dolazak";
            this.Dolazak.ReadOnly = true;
            // 
            // Odlazak
            // 
            this.Odlazak.HeaderText = "Odlazak";
            this.Odlazak.Name = "Odlazak";
            this.Odlazak.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.gbNewContact.Controls.Add(this.lbDo);
            this.gbNewContact.Controls.Add(this.lbOd);
            this.gbNewContact.Controls.Add(this.lbStatus);
            this.gbNewContact.Controls.Add(this.cbStatus);
            this.gbNewContact.Controls.Add(this.dtpDO);
            this.gbNewContact.Controls.Add(this.dtpDatumRodjenja);
            this.gbNewContact.Controls.Add(this.btnOcisti);
            this.gbNewContact.Controls.Add(this.tbTipNesrece);
            this.gbNewContact.Controls.Add(this.lbTipNesrece);
            this.gbNewContact.Controls.Add(this.tbJMB);
            this.gbNewContact.Controls.Add(this.lbDatumRodj);
            this.gbNewContact.Controls.Add(this.lbJMB);
            this.gbNewContact.Controls.Add(this.dtpOD);
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
            this.gbNewContact.Enter += new System.EventHandler(this.gbNewContact_Enter);
            // 
            // lbDo
            // 
            this.lbDo.AutoSize = true;
            this.lbDo.Location = new System.Drawing.Point(492, 101);
            this.lbDo.Name = "lbDo";
            this.lbDo.Size = new System.Drawing.Size(24, 13);
            this.lbDo.TabIndex = 25;
            this.lbDo.Text = "Do:";
            // 
            // lbOd
            // 
            this.lbOd.AutoSize = true;
            this.lbOd.Location = new System.Drawing.Point(260, 101);
            this.lbOd.Name = "lbOd";
            this.lbOd.Size = new System.Drawing.Size(24, 13);
            this.lbOd.TabIndex = 24;
            this.lbOd.Text = "Od:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(524, 60);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 22;
            this.lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cbStatus.Location = new System.Drawing.Point(527, 75);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(141, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(495, 117);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(210, 20);
            this.dtpDO.TabIndex = 11;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(34, 117);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(210, 20);
            this.dtpDatumRodjenja.TabIndex = 9;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.SystemColors.Info;
            this.btnOcisti.Location = new System.Drawing.Point(679, 73);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(49, 23);
            this.btnOcisti.TabIndex = 19;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTipNesrece
            // 
            this.tbTipNesrece.Location = new System.Drawing.Point(527, 36);
            this.tbTipNesrece.Name = "tbTipNesrece";
            this.tbTipNesrece.Size = new System.Drawing.Size(141, 20);
            this.tbTipNesrece.TabIndex = 4;
            // 
            // lbTipNesrece
            // 
            this.lbTipNesrece.AutoSize = true;
            this.lbTipNesrece.Location = new System.Drawing.Point(524, 20);
            this.lbTipNesrece.Name = "lbTipNesrece";
            this.lbTipNesrece.Size = new System.Drawing.Size(69, 13);
            this.lbTipNesrece.TabIndex = 15;
            this.lbTipNesrece.Text = "Tip nesreće: ";
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
            this.lbDatumRodj.Location = new System.Drawing.Point(31, 101);
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
            // 
            // dtpOD
            // 
            this.dtpOD.Location = new System.Drawing.Point(263, 117);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(210, 20);
            this.dtpOD.TabIndex = 10;
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
            // btnDodajKorisnikaKampa
            // 
            this.btnDodajKorisnikaKampa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDodajKorisnikaKampa.FlatAppearance.BorderSize = 0;
            this.btnDodajKorisnikaKampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKorisnikaKampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKorisnikaKampa.ForeColor = System.Drawing.Color.White;
            this.btnDodajKorisnikaKampa.Location = new System.Drawing.Point(28, 515);
            this.btnDodajKorisnikaKampa.Name = "btnDodajKorisnikaKampa";
            this.btnDodajKorisnikaKampa.Size = new System.Drawing.Size(212, 39);
            this.btnDodajKorisnikaKampa.TabIndex = 12;
            this.btnDodajKorisnikaKampa.Text = "Dodaj korisnika kampa";
            this.btnDodajKorisnikaKampa.UseVisualStyleBackColor = false;
            this.btnDodajKorisnikaKampa.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmijeniKorisnikaKampa
            // 
            this.btnIzmijeniKorisnikaKampa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnIzmijeniKorisnikaKampa.FlatAppearance.BorderSize = 0;
            this.btnIzmijeniKorisnikaKampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmijeniKorisnikaKampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnIzmijeniKorisnikaKampa.ForeColor = System.Drawing.Color.White;
            this.btnIzmijeniKorisnikaKampa.Location = new System.Drawing.Point(289, 515);
            this.btnIzmijeniKorisnikaKampa.Name = "btnIzmijeniKorisnikaKampa";
            this.btnIzmijeniKorisnikaKampa.Size = new System.Drawing.Size(212, 39);
            this.btnIzmijeniKorisnikaKampa.TabIndex = 13;
            this.btnIzmijeniKorisnikaKampa.Text = "Izmijeni korisnika kampa";
            this.btnIzmijeniKorisnikaKampa.UseVisualStyleBackColor = false;
            this.btnIzmijeniKorisnikaKampa.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnObrisiKorisnikaKampa
            // 
            this.btnObrisiKorisnikaKampa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnObrisiKorisnikaKampa.FlatAppearance.BorderSize = 0;
            this.btnObrisiKorisnikaKampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiKorisnikaKampa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnObrisiKorisnikaKampa.ForeColor = System.Drawing.Color.White;
            this.btnObrisiKorisnikaKampa.Location = new System.Drawing.Point(550, 515);
            this.btnObrisiKorisnikaKampa.Name = "btnObrisiKorisnikaKampa";
            this.btnObrisiKorisnikaKampa.Size = new System.Drawing.Size(212, 39);
            this.btnObrisiKorisnikaKampa.TabIndex = 14;
            this.btnObrisiKorisnikaKampa.Text = "Obrisi korisnika kampa";
            this.btnObrisiKorisnikaKampa.UseVisualStyleBackColor = false;
            this.btnObrisiKorisnikaKampa.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lbDobrodosliZaduzeniSte
            // 
            this.lbDobrodosliZaduzeniSte.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDobrodosliZaduzeniSte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbDobrodosliZaduzeniSte.Location = new System.Drawing.Point(57, 18);
            this.lbDobrodosliZaduzeniSte.Name = "lbDobrodosliZaduzeniSte";
            this.lbDobrodosliZaduzeniSte.Size = new System.Drawing.Size(705, 37);
            this.lbDobrodosliZaduzeniSte.TabIndex = 15;
            this.lbDobrodosliZaduzeniSte.Text = "Dobrodošli, zaduženi ste za kamp";
            this.lbDobrodosliZaduzeniSte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDobrodosliZaduzeniSte.UseMnemonic = false;
            this.lbDobrodosliZaduzeniSte.Click += new System.EventHandler(this.labelWelcome_Click);
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
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VolonterWorkWithKorisniciKampa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbDobrodosliZaduzeniSte);
            this.Controls.Add(this.btnObrisiKorisnikaKampa);
            this.Controls.Add(this.btnIzmijeniKorisnikaKampa);
            this.Controls.Add(this.gbNewContact);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodajKorisnikaKampa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VolonterWorkWithKorisniciKampa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-Camp";
            this.Load += new System.EventHandler(this.VolonterWorkWithKorisniciKampa_Load);
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
            private System.Windows.Forms.Button btnDodajKorisnikaKampa;
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
            private System.Windows.Forms.TextBox tbTipNesrece;
            private System.Windows.Forms.Label lbTipNesrece;
            private System.Windows.Forms.TextBox tbJMB;
            private System.Windows.Forms.Label lbDatumRodj;
            private System.Windows.Forms.Label lbJMB;
            private System.Windows.Forms.DateTimePicker dtpOD;
            private System.Windows.Forms.Button btnIzmijeniKorisnikaKampa;
            private System.Windows.Forms.Button btnObrisiKorisnikaKampa;
            private System.Windows.Forms.Button btnOcisti;
            private System.Windows.Forms.Label lbDobrodosliZaduzeniSte;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbDo;
        private System.Windows.Forms.Label lbOd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drzavljanstvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dolazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odlazak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
    }