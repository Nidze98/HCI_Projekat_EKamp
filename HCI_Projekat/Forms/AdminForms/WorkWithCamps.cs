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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace HCI_Projekat.Forms.AdminForms
{
    public partial class WorkWithCamps : Form
    {
        List<Kamp> kampList=DBUtil.DBUtil.LoadCampsFromDatabase();
        List<Mjesto> mjestoList = DBUtil.DBUtil.LoadMjestoList();
        Administrator administrator;
        Kamp currentlyClickedKamp;
        ResourceManager rm;
        public WorkWithCamps(Osoba o)
        {
            InitializeComponent();
            administrator=(Administrator)o;
            rm=administrator.GetResourceManagerLanguage();
            setLanguage();
            setTheme();
            FillGrid();
            
        }

        private void FillGrid(string filter = null)
        {
            dataGridView1.Rows.Clear();
            kampList = GetKamps(filter);
            if (kampList != null) { 
                foreach (Kamp a in kampList)
                {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, a.ime, a.getMjesto().drzava, a.getMjesto().naziv, a.status, a.getVolonterName(), a.brojKorisnikaKampa);
                dataGridView1.Rows.Add(row);
                }
            }
        }
        private List<Kamp> FilterByName(string partialName, List<Kamp> kamps)
        {
            if (kamps == null)
            {
                // Handle the case where the list is null
                return null;
            }

            // Use LINQ to filter the list based on the partial name match
            var filteredList = kamps
                .Where(obj => obj.ime.ToLower().Contains(partialName.ToLower()))
                .ToList();

            return filteredList;
        }
        private List<Kamp> GetKamps(string filter = null)
        {
            kampList = DBUtil.DBUtil.LoadCampsFromDatabase();
         
            if (filter != null)
            {
                kampList = FilterByName(filter, kampList);
            }
            return kampList;
        }

        private void WorkWithCamps_Load(object sender, EventArgs e)
        {

        }

        private void WorkWithCamps_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (IsValidValues())
            {   
             
                // If all checks passed, proceed to add the administrator
                Kamp kamp = new Kamp()
                {
                    administratorJMB = administrator.JMB,
                    ime = tbIme.Text,
                    status = cbStatus.Text,
                 
                };
                Mjesto pom = new Mjesto()
                    {
                       naziv = tbGrad.Text,
                       drzava = tbDrzava.Text,
                   
                    };

                // Add the administrator to the database
                DBUtil.DBUtil.AddKamp(pom,kamp);
                MessageBox.Show(rm.GetString("Uspjesno dodano"));
                // Refresh the grid
                FillGrid();
            }
            else return;
        }
        private Boolean IsValidValues(bool addingNew = true)
        {
            // Check if any textbox is empty
            if (string.IsNullOrWhiteSpace(tbIme.Text) ||
                string.IsNullOrWhiteSpace(tbGrad.Text) ||
                string.IsNullOrWhiteSpace(tbDrzava.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text)) 
        
            {
                MessageBox.Show(rm.GetString("Sva polja moraju biti popunjena"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Exit the method
            }

            // Check if JMB is unique in the database
            if (addingNew)
            {
                foreach (Kamp a in kampList)
                {
                    if (a.ime.Equals(tbIme.Text)&&a.getMjesto().naziv == tbGrad.Text)
                    {
                        MessageBox.Show(rm.GetString("Kamp sa ovim nazivom vec postoji u bazi podataka"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                currentlyClickedKamp.ime = tbIme.Text;
                currentlyClickedKamp.status = cbStatus.Text;

               
                Mjesto mjesto = new Mjesto()
                {
                    naziv = tbGrad.Text,
                    drzava = tbDrzava.Text,

                };

                DBUtil.DBUtil.UpdateKamp(mjesto,currentlyClickedKamp);
                MessageBox.Show(rm.GetString("Uspjesno azurirano"));
                // Refresh the grid
                FillGrid();
                clearFields();
            }
            else return;

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (IsValidValues(false))
            { 
                DBUtil.DBUtil.DeleteCamp(currentlyClickedKamp);
                MessageBox.Show(rm.GetString("Uspjesno obrisano"));
                FillGrid();
                clearFields();
            }
            else return;

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid(tbFilter.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kampList = GetKamps();
            // Check if the clicked cell is not the header row
            if (e.RowIndex >= 0)
            {
                // Get the index of the clicked row
                int rowIndex = e.RowIndex;
                // Get the Kamp object associated with the clicked row
                currentlyClickedKamp = kampList[rowIndex];
                FillTextBoxes(currentlyClickedKamp); 
            }
        }
        private void FillTextBoxes(Kamp kamp)
        {
            if (kamp != null)
            {
                tbIme.Text = kamp.ime;
                tbGrad.Text = kamp.getMjesto().naziv;

                tbDrzava.Text = kamp.getMjesto().drzava;
                cbStatus.Text = kamp.status;

            }
        }
        private void clearFields()
        {
            tbIme.Text = string.Empty;
            tbGrad.Text = string.Empty;

            tbDrzava.Text = string.Empty;
            cbStatus.SelectedIndex = -1;
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

            // Set properties for buttons
            btnKreirajKamp.Text = rm.GetString("btn_WWC_KreirajKamp");
            btnIzmijeniKamp.Text = rm.GetString("btn_WWC_IzmijeniKamp");
            btnObrisiKamp.Text = rm.GetString("btn_WWC_ObrisiKamp");
            btnOcisti.Text = rm.GetString("Ocisti");
            button2.Text = rm.GetString("YourButton2Text");  // Replace with the actual name

            // Set properties for labels, textboxes, and comboboxes
            lbStatus.Text = rm.GetString("Status") + ":";
            lbGrad.Text = rm.GetString("Grad") + ":";
            lbNazivKampa.Text = rm.GetString("Naziv kampa") + ":";
            lbDrzava.Text = rm.GetString("Drzava") + ":";
            lbWorkWithCamps.Text = rm.GetString("label_WWC_Top");

            // Set properties for DataGridView columns without colon
            NazivKampa.HeaderText = rm.GetString("Naziv kampa");
            Drzava.HeaderText = rm.GetString("Drzava");
            Grad.HeaderText = rm.GetString("Grad");
            Status.HeaderText = rm.GetString("Status");
            ZaduzeniVolonter.HeaderText = rm.GetString("Zaduzeni volonter");
            BrojKorisnika.HeaderText = rm.GetString("Broj korisnika");

        }
    }
}
