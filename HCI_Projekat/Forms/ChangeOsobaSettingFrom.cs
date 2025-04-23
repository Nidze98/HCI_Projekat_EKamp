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
    public partial class ChangeOsobaSettingFrom : Form
    {
        private Osoba osoba;
        public ChangeOsobaSettingFrom(Osoba o)
        {
            this.osoba = o; 
            InitializeComponent();
            if(o is Volonter)
            {
                Volonter volonter = (Volonter)o;
               
                cbLanguage.Text = volonter.Jezik;
                cbTheme.Text = volonter.Tema;
            }
            if (o is Administrator)
            {
                Administrator administrator = (Administrator)o;

                cbLanguage.Text = administrator.Jezik;
                cbTheme.Text = administrator.Tema;
            }
            if (cbLanguage.Text == "") cbLanguage.Text = "Srpski";
            if (cbTheme.Text == "") cbTheme.Text = "Purple";


            ChangeLanguage();
        }

        private void lbLanguage_Click(object sender, EventArgs e)
        {

        }

        private void ChangeOsobaSettingFrom_Load(object sender, EventArgs e)
        {

        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (osoba is Volonter)
            {
                Volonter volonter = (Volonter)osoba;

               volonter.Jezik = cbLanguage.Text;
            }
            if (osoba is Administrator)
            {
                Administrator administrator = (Administrator)osoba;

                administrator.Jezik = cbLanguage.Text;
            }
            DBUtil.DBUtil.UpdateOsoba(osoba);
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            if (osoba is Volonter)
            {
                Volonter volonter = (Volonter)osoba;

               ResourceManager rm=volonter.GetResourceManagerLanguage();
                lbLanguage.Text = rm.GetString("Jezik");
                labelTopChangeSettingsForm.Text=rm.GetString("label_COSF_Top")+" "+volonter.KorisnickoIme;
                lbTheme.Text = rm.GetString("Tema");
            }
            if (osoba is Administrator)
            {
                Administrator administrator = (Administrator)osoba;

                ResourceManager rm = administrator.GetResourceManagerLanguage();
                lbLanguage.Text = rm.GetString("Jezik");
                labelTopChangeSettingsForm.Text = rm.GetString("label_COSF_Top") + " " + administrator.KorisnickoIme;
                lbTheme.Text = rm.GetString("Tema");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (osoba is Volonter)
            {
                Volonter volonter = (Volonter)osoba;
                volonter.Tema=cbTheme.Text;
                ThemeManager.SetTheme(volonter.Tema, this);
            }
            if (osoba is Administrator)
            {
                Administrator administrator = (Administrator)osoba;
                administrator.Tema = cbTheme.Text;
                ThemeManager.SetTheme(administrator.Tema, this);
            }
            DBUtil.DBUtil.UpdateOsoba(osoba);

        }
    }
}
