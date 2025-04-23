using Google.Protobuf.WellKnownTypes;
using HCI_Projekat.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Projekat.Forms
{
    public partial class VolonterWorkWithKorisniciKampa : Form
    {
        private Volonter volonter;
        ResourceManager rm ;

        KorisnikKampa currentCickedKorisnikKamp;
        List<KorisnikKampa> korisnikKampaList;
        public VolonterWorkWithKorisniciKampa(Volonter o)
        {
            InitializeComponent();
            this.volonter = o;
             rm=volonter.GetResourceManagerLanguage();
            setLanguage();
            setTheme();
           
            volonter.setKamp();
            if (volonter.Kamp == null)
            {

                string msg = rm.GetString("label_VWWKK_Top_Negative");
                lbDobrodosliZaduzeniSte.Text =  msg + ":";
                MessageBox.Show(msg);
                return;  
                
            }
            else
            {
                lbDobrodosliZaduzeniSte.Text = rm.GetString("label_VWWKK_Top") +" "+ volonter.Kamp.ime;
                korisnikKampaList = DBUtil.DBUtil.LoadKorisnikKampaList(volonter.Kamp);
                FillGrid();
            }
        }


        private void gbNewContact_Enter(object sender, EventArgs e)
        {

        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid(tbFilter.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            korisnikKampaList = GetKorisnikKampa();
            // Check if the clicked cell is not the header row
            if (e.RowIndex >= 0)
            {
                // Get the index of the clicked row
                int rowIndex = e.RowIndex;
                // Get the Kamp object associated with the clicked row
                currentCickedKorisnikKamp = korisnikKampaList[rowIndex];
                FillTextBoxes(currentCickedKorisnikKamp); 

            }
        }
        private void FillTextBoxes(KorisnikKampa korisnikKampa)
        {
            if (korisnikKampa != null)
            {
                tbIme.Text = korisnikKampa.Ime;
                tbPrezime.Text = korisnikKampa.Prezime;

                dtpDatumRodjenja.Text = korisnikKampa.DatumRodjenja.ToShortDateString();
                cbPol.Text = korisnikKampa.Pol.ToString();
                tbDrzavljanstvo.Text = korisnikKampa.Drzavljanstvo;
                tbMjestoPrebivalista.Text = korisnikKampa.MjestoPrebivalista;
                tbTipNesrece.Text = korisnikKampa.TipNesrece;
                cbStatus.Text = korisnikKampa.Status.ToString();
                tbJMB.Text = korisnikKampa.JMB;

              
                dtpDO.Text = korisnikKampa.DatumDO.ToShortDateString();
                dtpOD.Text = korisnikKampa.DatumOD.ToShortDateString();
               



            }
        }

        private void VolonterWorkWithKorisniciKampa_Load(object sender, EventArgs e)
        {

        }
        private void FillGrid(string filter = null)
        {
            dataGridView1.Rows.Clear();
            korisnikKampaList = GetKorisnikKampa(filter);
            foreach (KorisnikKampa a in korisnikKampaList)
            {
                DataGridViewRow row = new DataGridViewRow();
                string datumDO = string.Empty;
                string datumOD = string.Empty;

                datumDO = a.DatumDO.ToShortDateString() ?? string.Empty;
                datumOD = a.DatumOD.ToShortDateString() ?? string.Empty;
                

                row.CreateCells(dataGridView1, a.Ime, a.Prezime, a.JMB, a.Drzavljanstvo, a.Pol, datumDO, datumOD, a.Status);
                dataGridView1.Rows.Add(row);
            }
        }
        private List<KorisnikKampa> GetKorisnikKampa(string filter = null)
        {

            List<KorisnikKampa> korisnikKampaList = DBUtil.DBUtil.LoadKorisnikKampaList(volonter.Kamp);
            if (filter != null)
            {
                korisnikKampaList = FilterByName(filter, korisnikKampaList);
            }
            return korisnikKampaList;
        }
        private List<KorisnikKampa> FilterByName(string partialName, List<KorisnikKampa> korisniks)
        {
            if (korisniks == null)
            {
                // Handle the case where the list is null
                return null;
            }

            // Use LINQ to filter the list based on the partial name match
            var filteredList = korisniks
                .Where(obj => obj.Ime.ToLower().Contains(partialName.ToLower()))
                .ToList();

            return filteredList;
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (IsValidValues())
            {
                // If all checks passed, proceed to add the administrator
                KorisnikKampa korisnikKampa = new KorisnikKampa()
                {
                    JMB = tbJMB.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Pol = cbPol.SelectedItem.ToString().FirstOrDefault(),
                    Drzavljanstvo = tbDrzavljanstvo.Text,
                    MjestoPrebivalista = tbMjestoPrebivalista.Text,
                    TipNesrece = tbTipNesrece.Text,
                    Status = cbStatus.SelectedItem.ToString(),
                    DatumDO = dtpDO.Value,
                    DatumOD = dtpOD.Value,
                    VolonterJMB = volonter.JMB,
                    KampID = volonter.Kamp.id
                };
                // Add the administrator to the database
                DBUtil.DBUtil.AddKorisnikKampa(korisnikKampa);
                MessageBox.Show(rm.GetString("Uspjesno dodano"));
                // Refresh the grid
                FillGrid();
                ClearFields();
            }
            else return;
        }
        private Boolean IsValidValues(bool addingNew = true)
        {
            // Check if any textbox is empty
            if (string.IsNullOrWhiteSpace(tbJMB.Text) ||
                string.IsNullOrWhiteSpace(tbIme.Text) ||
                string.IsNullOrWhiteSpace(tbPrezime.Text) ||
                string.IsNullOrWhiteSpace(tbDrzavljanstvo.Text) ||
                string.IsNullOrWhiteSpace(tbMjestoPrebivalista.Text) ||
                string.IsNullOrWhiteSpace(tbTipNesrece.Text) ||
                string.IsNullOrWhiteSpace(cbPol.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text))


            {
                MessageBox.Show(rm.GetString("Sva polja moraju biti popunjena"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method
            }
            // Check if JMB is 13 characters
            if (tbJMB.Text.Length != 13)
            {
                MessageBox.Show(rm.GetString("JMB mora imati tacno 13 brojeva"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method
            }

            // Check if JMB is unique in the database
            if (addingNew)
            {
                foreach (KorisnikKampa a in korisnikKampaList)
                {
                    if (a.JMB.Equals(tbJMB.Text))
                    {
                        MessageBox.Show(rm.GetString("JMB vec postoji u bazi podataka"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Exit the method
                    }
                }
            }

            return true;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            if (IsValidValues(false))
            {
                if (changesHappened())
                {
                    currentCickedKorisnikKamp.JMB = tbJMB.Text;
                    currentCickedKorisnikKamp.Ime = tbIme.Text;
                    currentCickedKorisnikKamp.Prezime = tbPrezime.Text;
                    currentCickedKorisnikKamp.DatumRodjenja = dtpDatumRodjenja.Value;
                    currentCickedKorisnikKamp.Pol = cbPol.SelectedItem.ToString().FirstOrDefault();
                    currentCickedKorisnikKamp.Drzavljanstvo = tbDrzavljanstvo.Text;
                    currentCickedKorisnikKamp.MjestoPrebivalista = tbMjestoPrebivalista.Text;
                    currentCickedKorisnikKamp.TipNesrece = tbTipNesrece.Text;
                    currentCickedKorisnikKamp.Status = cbStatus.SelectedItem.ToString();
                    currentCickedKorisnikKamp.DatumDO = dtpDO.Value;
                    currentCickedKorisnikKamp.DatumOD = dtpOD.Value;


                    DBUtil.DBUtil.UpdateKorisnikKampa(currentCickedKorisnikKamp);
                    MessageBox.Show(rm.GetString("Uspjesno azurirano")); 
                    // Refresh the grid
                    FillGrid();
                    ClearFields();
                    
                }
                else
                {
                    MessageBox.Show(rm.GetString("Niste unijeli ni jednu promjenu"));
                }
                
            }
            else return;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (IsValidValues(false))
            {
                // Add the administrator to the database
                DBUtil.DBUtil.DeleteKorisnikKampa(currentCickedKorisnikKamp);
                MessageBox.Show(rm.GetString("Uspjesno obrisano"));
                // Refresh the grid
                FillGrid();
                ClearFields();
            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            tbJMB.Text=String.Empty;
            tbIme.Text = String.Empty;
            tbPrezime.Text = String.Empty;
            dtpDatumRodjenja.Text=String.Empty;
            cbPol.SelectedIndex = -1;
            tbDrzavljanstvo.Text=String.Empty;
            tbMjestoPrebivalista.Text=String.Empty;
            tbTipNesrece.Text = String.Empty;
            cbStatus.SelectedIndex = -1;
            dtpDO.Text = String.Empty;
            dtpOD.Text = String.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void setTheme()
        {
            if ("".Equals(volonter.Tema))
            {
                ThemeManager.SetTheme("Purple", this);
            }
            else
            {
                ThemeManager.SetTheme(volonter.Tema, this);
            }
        }
        private void setLanguage()
        {
            ResourceManager rm = volonter.GetResourceManagerLanguage();
            // Labels
            lbPol.Text = rm.GetString("Pol") + ":";
            lbDrzavljanstvo.Text = rm.GetString("Drzavljanstvo") + ":";
            lbPrezime.Text = rm.GetString("Prezime") + ":";
            lbIme.Text = rm.GetString("Ime") + ":";
            lbMjestoPrebivalista.Text = rm.GetString("Mjesto prebivalista") + ":";
            lbTipNesrece.Text = rm.GetString("Tip nesrece") + ":";
            lbJMB.Text = rm.GetString("JMB") + ":";
            lbDatumRodj.Text = rm.GetString("Datum rodjenja") + ":";
            lbOd.Text = rm.GetString("Od") + ":";
            lbDo.Text = rm.GetString("Do") + ":";
            lbStatus.Text = rm.GetString("Status") + ":";
            //    lbDobrodosliZaduzeniSte.Text = rm.GetString("label_VWWKK_Top") + ":";

            // Buttons
            btnDodajKorisnikaKampa.Text = rm.GetString("btn_VWWKK_DodajKorisnikaKampa");
            btnIzmijeniKorisnikaKampa.Text = rm.GetString("btn_VWWKK_IzmijeniKorisnikaKampa");
            btnObrisiKorisnikaKampa.Text = rm.GetString("btn_VWWKK_ObrisiKorisnikaKampa");
            btnOcisti.Text = rm.GetString("Ocisti");

            // ComboBox
            cbPol.Text = rm.GetString("Pol");

            // DataGridView Columns
            Ime.HeaderText = rm.GetString("Ime");
            Prezime.HeaderText = rm.GetString("Prezime");
            JMB.HeaderText = rm.GetString("JMB");
            Status.HeaderText = rm.GetString("Status");
            Drzavljanstvo.HeaderText = rm.GetString("Drzavljanstvo");
            Pol.HeaderText = rm.GetString("Pol");
            Dolazak.HeaderText = rm.GetString("Dolazak");
            Odlazak.HeaderText = rm.GetString("Odlazak");
        }
        private Boolean changesHappened()
        {
            if (tbJMB.Text != currentCickedKorisnikKamp.JMB ||
                     tbIme.Text != currentCickedKorisnikKamp.Ime ||
                     tbPrezime.Text != currentCickedKorisnikKamp.Prezime ||
                     dtpDatumRodjenja.Value != currentCickedKorisnikKamp.DatumRodjenja ||
                     cbPol.SelectedItem?.ToString().FirstOrDefault() != currentCickedKorisnikKamp.Pol ||
                     tbDrzavljanstvo.Text != currentCickedKorisnikKamp.Drzavljanstvo ||
                     tbMjestoPrebivalista.Text != currentCickedKorisnikKamp.MjestoPrebivalista ||
                     tbTipNesrece.Text != currentCickedKorisnikKamp.TipNesrece ||
                     cbStatus.SelectedItem?.ToString() != currentCickedKorisnikKamp.Status ||
                     dtpDO.Value != currentCickedKorisnikKamp.DatumDO ||
                     dtpOD.Value != currentCickedKorisnikKamp.DatumOD)
                return true;
            else return false;
        }
    }
}

