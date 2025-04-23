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
    public partial class VolonterMenuForm : Form
    {
        private Volonter volonter;
        public VolonterMenuForm(Osoba o)
        {
            volonter=(Volonter)o;
         
            
            InitializeComponent(); 
            setTheme();
            setLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void VolonterMenuForm_Load(object sender, EventArgs e)
        {

        }
        private void setLanguage()
        {
            ResourceManager rm=volonter.GetResourceManagerLanguage();
            labelTopVolonterMenuForm.Text = rm.GetString("lbl_AMF_top") + "" + volonter.KorisnickoIme;
            btnSettings.Text = rm.GetString("btn_VMF_Podesavanja");
            btnWorkWithKorisnici.Text = rm.GetString("btn_VMF_RadSaKorisnicima");
        }

        private void btnWorkWithKorisnici_Click(object sender, EventArgs e)
        {
           
            volonter.setKamp();
            if (volonter.Kamp != null)
            { 
                VolonterWorkWithKorisniciKampa vm = new VolonterWorkWithKorisniciKampa(volonter);
                this.Hide();

                vm.ShowDialog();
                
                this.Show();
            }
            else
            {
                ResourceManager rm = volonter.GetResourceManagerLanguage();
                string msg = rm.GetString("label_VWWKK_Top_Negative");
                MessageBox.Show(msg);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeOsobaSettingFrom cs = new ChangeOsobaSettingFrom(volonter);
            this.Hide();
            cs.ShowDialog();
            setLanguage();
            setTheme();
            this.Show();
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

    }
}
