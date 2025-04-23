using HCI_Projekat.DBUtil;
using HCI_Projekat.Models;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HCI_Projekat.Forms.AdminForms
{
    public partial class WorkWithAdmins : Form
    {
        List<Administrator> administratorsList;
        Administrator administrator;
        Administrator currentlyClickedAdministrator;
        ResourceManager rm;
        public WorkWithAdmins(Administrator a)
        {
            InitializeComponent();
            this.administrator = a;
            rm=a.GetResourceManagerLanguage();
            setLanguage();
            setTheme();
            

            FillGrid();

 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkWithAdmins_Load(object sender, EventArgs e)
        {

        }

        private void lbFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lbGroup_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbFilter_Click(object sender, EventArgs e)
        {

        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid(tbFilter.Text);
        }
        private void FillGrid(string filter=null)
        {
            dataGridView1.Rows.Clear();
            administratorsList = GetAdministrators(filter);
            foreach (Administrator a in administratorsList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, a.KorisnickoIme, a.Ime, a.Prezime, (a.DatumRodjenja).ToShortDateString(), a.Pol, a.Drzavljanstvo, a.MjestoPrebivalista, a.JMB);
                dataGridView1.Rows.Add(row);
            }
        }
        private List<Administrator> FilterByName(string partialName, List<Administrator> administrators)
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
        private List<Administrator> GetAdministrators(string filter=null)
        {
            List<Osoba> peopleList = DBUtil.DBUtil.LoadOsobeList("admin");
            List<Administrator> administratorsList = peopleList.OfType<Administrator>().ToList();
            if (filter != null) {
                administratorsList = FilterByName(filter, administratorsList);
            }
            return administratorsList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             administratorsList = GetAdministrators();

            // Check if the clicked cell is not the header row
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                currentlyClickedAdministrator = administratorsList[rowIndex];
                FillTextBoxes(currentlyClickedAdministrator);
            }
        }
        private void FillTextBoxes(Administrator administrator)
        {
            if (administrator != null)
            {
                tbIme.Text = administrator.Ime;
                tbPrezime.Text = administrator.Prezime;
   
                dtpDatumRodjenja.Text = administrator.DatumRodjenja.ToShortDateString();
                cbPol.Text = administrator.Pol.ToString();
                tbDrzavljanstvo.Text = administrator.Drzavljanstvo;
                tbMjestoPrebivalista.Text = administrator.MjestoPrebivalista;
                tbKorisnickoIme.Text=administrator.KorisnickoIme;
                tbSifra.Text = administrator.Lozinka;
                tbJMB.Text = administrator.JMB; 
  
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
          
            if (IsValidValues())
            {
                // If all checks passed, proceed to add the administrator
                Administrator administrator = new Administrator()
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
                DBUtil.DBUtil.AddOsoba(administrator);
                MessageBox.Show(rm.GetString("Uspjesno dodano"));
                clearFields();
                // Refresh the grid
                FillGrid();
            }
            else return;

          
        }
        private Boolean IsValidValues(bool addingNew=true)
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
                foreach (Administrator a in administratorsList)
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

               // Administrator admin = administratorsList.Where(a => (a.JMB.Equals(tbJMB.Text)) || (a.KorisnickoIme.Equals(tbKorisnickoIme.Text))).FirstOrDefault();
                // If all checks passed, proceed to add the administrator
                if (changesHappened(currentlyClickedAdministrator))
                {
                    //  admin.JMB = tbJMB.Text;
                    currentlyClickedAdministrator.Ime = tbIme.Text;
                    currentlyClickedAdministrator.Prezime = tbPrezime.Text;
                    currentlyClickedAdministrator.DatumRodjenja = dtpDatumRodjenja.Value;
                    currentlyClickedAdministrator.Pol = cbPol.SelectedItem.ToString().FirstOrDefault();
                    currentlyClickedAdministrator.Drzavljanstvo = tbDrzavljanstvo.Text;
                    currentlyClickedAdministrator.MjestoPrebivalista = tbMjestoPrebivalista.Text;
                    currentlyClickedAdministrator.KorisnickoIme = tbKorisnickoIme.Text;
                    currentlyClickedAdministrator.Lozinka = tbSifra.Text;
                    // Add the administrator to the database

                    DBUtil.DBUtil.UpdateOsoba(currentlyClickedAdministrator);
                    MessageBox.Show("Uspjesno azurirano");
                    clearFields();
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
               // Administrator admin = administratorsList.Where(a => (a.JMB.Equals(tbJMB.Text)) || (a.KorisnickoIme.Equals(tbKorisnickoIme.Text))).FirstOrDefault();
                // If all checks passed, proceed to add the administrator
                if (currentlyClickedAdministrator.SuperAdmin)
                {
                    MessageBox.Show(rm.GetString("Nije moguce obrisati glavnog admina"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
               
                    // Add the administrator to the database
                    DBUtil.DBUtil.DeleteOsoba(currentlyClickedAdministrator);
                    MessageBox.Show(rm.GetString("Uspjesno obrisano"));
                    clearFields();
                    // Refresh the grid
                    FillGrid();
                }
            }
            else return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
        private void setLanguage()
        {
            ResourceManager rm = administrator.GetResourceManagerLanguage();
            // GroupBox Elements
            lbRadSaAdministratorimaTop.Text = rm.GetString("label_WWA_Top");
            btnDodajAdmina.Text = rm.GetString("btn_WWA_DodajAdmina");
            btnIzmijeniAdmina.Text = rm.GetString("btn_WWA_IzmijeniAdmina");
            btnObrisiAdmina.Text = rm.GetString("btn_WWA_ObrisiAdmina");
            btnOcisti.Text = rm.GetString("Ocisti");

            // Labels within the GroupBox
            lbPol.Text = rm.GetString("Pol") + ":";
            lbDrzavljanstvo.Text = rm.GetString("Drzavljanstvo") + ":";
            lbPrezime.Text = rm.GetString("Prezime") + ":";
            lbIme.Text = rm.GetString("Ime") + ":";
            lbMjestoPrebivalista.Text = rm.GetString("Mjesto prebivalista") + ":";
            lbSifra.Text = rm.GetString("Sifra") + ":";
            lbKorisnickoIme.Text = rm.GetString("Korisnicko ime") + ":";
            lbJMB.Text = rm.GetString("JMB") + ":";
            lbDatumRodj.Text = rm.GetString("Datum rodjenja") + ":";

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
        private Boolean changesHappened(Administrator admin)
        {
            if(tbIme.Text != admin.Ime ||
            tbPrezime.Text != admin.Prezime ||
            dtpDatumRodjenja.Value != admin.DatumRodjenja ||
            cbPol.SelectedItem?.ToString().FirstOrDefault() != admin.Pol ||
            tbDrzavljanstvo.Text != admin.Drzavljanstvo ||
            tbMjestoPrebivalista.Text != admin.MjestoPrebivalista ||
            tbKorisnickoIme.Text != admin.KorisnickoIme ||
            tbSifra.Text != admin.Lozinka)
                return true;
            else return false;
        }
        private void clearFields()
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
