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

namespace HCI_Projekat.Forms.AdminForms
{
    public partial class AssignVolonterToKamp : Form
    {
        Volonter volonter;
        List<Kamp> kamps=DBUtil.DBUtil.LoadCampsFromDatabase();
        Administrator administrator;
        ResourceManager rm;
       
        public AssignVolonterToKamp(Models.Volonter volonter,Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
            rm=administrator.GetResourceManagerLanguage();
            this.volonter = volonter;
            FillGrid();
            setTheme();
            setLanguage();
           

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AssignVolonterToKamp_Load(object sender, EventArgs e)
        {

        }

        private void cbKampsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Kamp getSelectedKamp()
        {
            Kamp selectedKamp = null;
            int selectedIndex = cbKampsList.SelectedIndex;
            if (selectedIndex != -1)
            {
                string selectedText = cbKampsList.SelectedItem.ToString();
                foreach (Kamp kamp in kamps)
                {
                    string kampInfo = kamp.ime + ", " + kamp.getMjesto().naziv + ", " + kamp.getMjesto().drzava;
                    if (selectedText == kampInfo)
                    { 
                        selectedKamp = kamp;
                        break;
                    }
                }
            }
            if (selectedKamp != null)
            {
                return selectedKamp;
            }
            else
            {
                MessageBox.Show(rm.GetString("Niste odabrali kamp u koji zelite rasporediti volontera"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return selectedKamp;
        }

        private void btnRasporediUKamp_Click(object sender, EventArgs e)
        {
            if (getSelectedKamp() != null)
            {
                volonter.Kamp=getSelectedKamp();
                volonter.StartDate = dtpOD.Value;
                volonter.EndDate=dtpDO.Value;
                DBUtil.DBUtil.AssignVolonterToKamp(getSelectedKamp(), volonter, dtpOD.Value, dtpDO.Value);
                MessageBox.Show(rm.GetString("Volonter je uspjesno rasporedjen"));
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
            lbRadSaVolonterima.Text = rm.GetString("label_AVTK_Top");
            lbKamp.Text = rm.GetString("Kamp") + ":";
            lbOd.Text = rm.GetString("Od") + ":";
            lbDo.Text = rm.GetString("Do") + ":";
            btnRasporediUKamp.Text = rm.GetString("btn_AVTK_RasporediUKamp");
        }
        private void FillGrid()
        {
            List<Osoba> list1 = DBUtil.DBUtil.LoadOsobeList("volonter");
            List<Volonter> volontersList = list1.OfType<Volonter>().ToList();
            Volonter pom = volontersList.Where(a => a.JMB == volonter.JMB).FirstOrDefault();
            if (pom != null)
            {
                volonter = pom;
            }

            volonter.setKamp();
            List<string> names = new List<string>();
            foreach (Kamp kamp in kamps)
            {
                names.Add(kamp.ime + ", " + kamp.getMjesto().naziv + ", " + kamp.getMjesto().drzava);
            }

            cbKampsList.DataSource = names;
            if (volonter.Kamp == null)
            {
                cbKampsList.SelectedIndex = -1;
            }
            else
            {
                string selectedText = volonter.Kamp.ime + ", " + volonter.Kamp.getMjesto().naziv + ", " + volonter.Kamp.getMjesto().drzava;
                foreach (string name in names)
                {
                    if (selectedText.Equals(name))
                    {
                        cbKampsList.SelectedIndex = names.IndexOf(name);
                        break;
                    }
                }

                dtpDO.Text = volonter.EndDate.ToShortDateString() ?? string.Empty;
                dtpOD.Text = volonter.StartDate.ToShortDateString() ?? string.Empty;


            }
        }

    }
}
