using HCI_Projekat.Forms.AdminForms;
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

namespace HCI_Projekat.Forms.VolonterForms
{
    public partial class WorkWithVolonters : Form
    {
        List<Volonter> volontersList;
        Volonter currentlyClickedVolonter;
        Administrator administrator;
        ResourceManager rm;
        public WorkWithVolonters(Administrator v)
        {  
            InitializeComponent();
            this.administrator = v;
            rm=administrator.GetResourceManagerLanguage();
            v.GetResourceManagerLanguage();
            setLanguage();
            setTheme();
          
           


            FillGrid();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WorkWithVolonters_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (IsValidValues())
            {
                // If all checks passed, proceed to add the administrator
                Volonter volonter = new Volonter()
                {
                    JMB = tbJMB.Text,
                    Ime = tbIme.Text,
                    Prezime = tbPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Pol = cbPol.SelectedItem.ToString().FirstOrDefault(),
                    Drzavljanstvo = tbDrzavljanstvo.Text,
                    MjestoPrebivalista = tbMjestoPrebivalista.Text,
                    KorisnickoIme = tbKorisnickoIme.Text,
                    Lozinka = tbSifra.Text
                };

                // Add the administrator to the database
                DBUtil.DBUtil.AddOsoba(volonter);
                clear();
                // Refresh the grid
                FillGrid();
            }
            else return;
        }
        private void FillGrid(string filter = null)
        {
            dataGridView1.Rows.Clear();
            volontersList = GetVolonters(filter);
            foreach (Volonter a in volontersList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, a.KorisnickoIme, a.Ime, a.Prezime, (a.DatumRodjenja).ToShortDateString(), a.Pol, a.Drzavljanstvo, a.MjestoPrebivalista, a.JMB);
                dataGridView1.Rows.Add(row);
            }
        }
        private List<Volonter> GetVolonters(string filter = null)
        {
            List<Osoba> peopleList = DBUtil.DBUtil.LoadOsobeList("volonter");
            List<Volonter> volontersList = peopleList.OfType<Volonter>().ToList();
            if (filter != null)
            {
                volontersList = FilterByName(filter, volontersList);
            }
            return volontersList;
        }
        private List<Volonter> FilterByName(string partialName, List<Volonter> administrators)
        {
            if (administrators == null)
            {
                // Handle the case where the list is null
                return null;
            }

            // Use LINQ to filter the list based on the partial name match
            var filteredList = administrators
                .Where(obj => obj.Ime.ToLower().Contains(partialName.ToLower()))
                .ToList();

            return filteredList;
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid(tbFilter.Text);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            volontersList = GetVolonters();
            // Check if the clicked cell is not the header row
            if (e.RowIndex >= 0)
            {
              
                int rowIndex = e.RowIndex;
                currentlyClickedVolonter = volontersList[rowIndex];
                FillTextBoxes(currentlyClickedVolonter);
            }
        }
        private void FillTextBoxes(Volonter volonter)
        {
            if (volonter != null)
            {
                tbIme.Text = volonter.Ime;
                tbPrezime.Text = volonter.Prezime;

                dtpDatumRodjenja.Text = volonter.DatumRodjenja.ToShortDateString();
                cbPol.Text = volonter.Pol.ToString();
                tbDrzavljanstvo.Text = volonter.Drzavljanstvo;
                tbMjestoPrebivalista.Text = volonter.MjestoPrebivalista;
                tbKorisnickoIme.Text = volonter.KorisnickoIme;
                tbSifra.Text = volonter.Lozinka;
                tbJMB.Text = volonter.JMB;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        private Boolean IsValidValues(bool addingNew = true)
        {
            // Check if any textbox is empty
            if (string.IsNullOrWhiteSpace(tbJMB.Text) ||
                string.IsNullOrWhiteSpace(tbIme.Text) ||
                string.IsNullOrWhiteSpace(tbPrezime.Text) ||
                string.IsNullOrWhiteSpace(tbDrzavljanstvo.Text) ||
                string.IsNullOrWhiteSpace(tbMjestoPrebivalista.Text) ||
                string.IsNullOrWhiteSpace(tbKorisnickoIme.Text) ||
                string.IsNullOrWhiteSpace(cbPol.Text) ||
                string.IsNullOrWhiteSpace(tbSifra.Text))
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
                foreach (Volonter a in volontersList)
                {
                    if (a.JMB.Equals(tbJMB.Text))
                    {
                        MessageBox.Show(rm.GetString("JMB vec postoji u bazi podataka"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Exit the method
                    }
                    else if (a.KorisnickoIme.Equals(tbKorisnickoIme.Text))
                    {
                        MessageBox.Show(rm.GetString("Korisnicko ime je zauzeto"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                //Volonter volonter = volontersList.Where(a => (a.JMB.Equals(tbJMB.Text)) || (a.KorisnickoIme.Equals(tbKorisnickoIme.Text))).FirstOrDefault();
                if (changesHappened(currentlyClickedVolonter))
                {
                    currentlyClickedVolonter.JMB = tbJMB.Text;
                    currentlyClickedVolonter.Ime = tbIme.Text;
                    currentlyClickedVolonter.Prezime = tbPrezime.Text;
                    currentlyClickedVolonter.DatumRodjenja = dtpDatumRodjenja.Value;
                    currentlyClickedVolonter.Pol = cbPol.SelectedItem.ToString().FirstOrDefault();
                    currentlyClickedVolonter.Drzavljanstvo = tbDrzavljanstvo.Text;
                    currentlyClickedVolonter.MjestoPrebivalista = tbMjestoPrebivalista.Text;
                    currentlyClickedVolonter.KorisnickoIme = tbKorisnickoIme.Text;
                    currentlyClickedVolonter.Lozinka = tbSifra.Text;


                    DBUtil.DBUtil.UpdateOsoba(currentlyClickedVolonter);
                    MessageBox.Show(rm.GetString("Uspjesno azurirano"));
                    clear();
                    // Refresh the grid
                    FillGrid();
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
              //  Volonter volonter = volontersList.Where(a => (a.JMB.Equals(tbJMB.Text)) || (a.KorisnickoIme.Equals(tbKorisnickoIme.Text))).FirstOrDefault();
                // If all checks passed, proceed to add the administrator
                currentlyClickedVolonter.setKamp();
                List<Volonter> list = GetVolonters();
                list.ForEach(a => a.setKamp());
                if (currentlyClickedVolonter.Kamp != null)
                {
                    Volonter v = list.Where(a => a.Kamp != null && currentlyClickedVolonter.Kamp.id == a.Kamp.id && (!currentlyClickedVolonter.JMB.Equals(a.JMB))).FirstOrDefault();
                    if (v == null)
                    {
                        MessageBox.Show(rm.GetString("Nije moguce obrisati volontera jer je jedini zaduzen za kamp")+" "+ currentlyClickedVolonter.Kamp.ime); 
                        return;
                    }
                    List<KorisnikKampa> list2 = DBUtil.DBUtil.LoadKorisnikKampaList(currentlyClickedVolonter.Kamp);
                    foreach (KorisnikKampa k in list2)
                    {
                        if (k.VolonterJMB == currentlyClickedVolonter.JMB)
                        {
                            k.VolonterJMB = v.JMB;
                            DBUtil.DBUtil.UpdateKorisnikKampa(k);
                        }
                    }
                }

                // Add the administrator to the database
                DBUtil.DBUtil.DeleteOsoba(currentlyClickedVolonter);
                MessageBox.Show(rm.GetString("Uspjesno obrisano"));
                clear();
                // Refresh the grid
                FillGrid();
            }
            else return;
        }

        private void btnIzmijeni_Click_1(object sender, EventArgs e)
        {

        }

      

        private void WorkWithVolonters_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRasporediUKamp_Click(object sender, EventArgs e)
        {
            if (IsValidValues(false))
            {
                if (currentlyClickedVolonter == null)
                {
                    MessageBox.Show(rm.GetString("Morate kliknuti na volontera kojeg zelite rasporediti"));
          
                }
                else
                {
                    AssignVolonterToKamp assignVolonterToKamp = new AssignVolonterToKamp(currentlyClickedVolonter, administrator);
                    this.Hide();

                    assignVolonterToKamp.ShowDialog();
                    this.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void setLanguage()
        {
            ResourceManager rm = administrator.GetResourceManagerLanguage();
            lblWorkWithVolonter.Text = rm.GetString("label_WWV_Top");

            // Set properties for buttons

            btnDodaj.Text = rm.GetString("btn_WWV_DodajVolontera");
            btnIzmijeni.Text = rm.GetString("btn_WWV_IzmijeniVolontera");
            btnObrisi.Text = rm.GetString("btn_WWV_ObrisiVolontera");
            btnOcisti.Text = rm.GetString("Ocisti");
            btnRasporediUKamp.Text = rm.GetString("btn_WWV_RasporediUKamp");

            // Set properties for labels and textboxes
            lbPol.Text = rm.GetString("Pol") + ":";
            lbDrzavljanstvo.Text = rm.GetString("Drzavljanstvo") + ":";
            lbPrezime.Text = rm.GetString("Prezime") + ":";
            lbIme.Text = rm.GetString("Ime") + ":";
            lbMjestoPrebivalista.Text = rm.GetString("Mjesto prebivalista") + ":";
            lbSifra.Text = rm.GetString("Sifra") + ":";
            lblKorisnickoIme.Text = rm.GetString("Korisnicko ime") + ":";
            lbDatumRodjenja.Text = rm.GetString("Datum rodjenja") + ":";
            lbJMB.Text = rm.GetString("JMB") + ":";

            // Set properties for DataGridView columns
            KorisnickoIme.HeaderText = rm.GetString("Korisnicko ime");
            Ime.HeaderText = rm.GetString("Ime");
            Prezime.HeaderText = rm.GetString("Prezime");
            DatumRodjenja.HeaderText = rm.GetString("Datum rodjenja");
            Pol.HeaderText = rm.GetString("Pol");
            Drzavljanstvo.HeaderText = rm.GetString("Drzavljanstvo");
            Prebivaliste.HeaderText = rm.GetString("Prebivaliste");
            JMB.HeaderText = rm.GetString("JMB");
        }
        private void setTheme()
        {
            if ("".Equals(administrator.Tema))
            {
                ThemeManager.SetTheme("Purple", this);
            }
            else
            {
                ThemeManager.SetTheme(administrator.Tema, this);
            }

            
        }
        private Boolean changesHappened(Volonter volonter)
        {
            if (tbJMB.Text != volonter.JMB ||
                tbIme.Text != volonter.Ime ||
                tbPrezime.Text != volonter.Prezime ||
                dtpDatumRodjenja.Value != volonter.DatumRodjenja ||
                cbPol.SelectedItem?.ToString().FirstOrDefault() != volonter.Pol ||
                tbDrzavljanstvo.Text != volonter.Drzavljanstvo ||
                tbMjestoPrebivalista.Text != volonter.MjestoPrebivalista ||
                tbKorisnickoIme.Text != volonter.KorisnickoIme ||
                tbSifra.Text != volonter.Lozinka)
                return true;
            else return false;
        }
        private void clear()
        {
            tbIme.Text = string.Empty;
            tbPrezime.Text = string.Empty;
            dtpDatumRodjenja.Text = string.Empty;
            cbPol.SelectedIndex = -1;
            tbDrzavljanstvo.Text = string.Empty;
            tbMjestoPrebivalista.Text = string.Empty;
            tbKorisnickoIme.Text = string.Empty;
            tbSifra.Text = string.Empty;
            tbJMB.Text = string.Empty;
        }
    }
}
