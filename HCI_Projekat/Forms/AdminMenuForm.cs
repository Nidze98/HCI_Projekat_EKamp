using HCI_Projekat.Forms.AdminForms;
using HCI_Projekat.Forms.VolonterForms;
using HCI_Projekat.Models;
using HCI_Projekat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Projekat.Forms
{
    public partial class AdminMenuForm : Form
    {
        private Administrator o;
        public AdminMenuForm(Administrator o)
        {
            InitializeComponent();
            this.o = o;
            setLanguage();
            setTheme();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkWithCamps workWithCamps = new WorkWithCamps(o);
            this.Hide();
            workWithCamps.ShowDialog(); 
            this.Show();
        } 

        private void button4_Click(object sender, EventArgs e)
        {
            
          WorkWithVolonters workWithVolonters = new VolonterForms.WorkWithVolonters(o);
            this.Hide();
            workWithVolonters.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            AdminForms.WorkWithAdmins workWithAdmins = new AdminForms.WorkWithAdmins( o);
            this.Hide();
            workWithAdmins.ShowDialog();
            this.Show();
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ChangeOsobaSettingFrom cs = new ChangeOsobaSettingFrom(o);
            this.Hide();
            cs.ShowDialog();
            setLanguage();
            setTheme();
            this.Show();
        }
        private void setLanguage()
        {
            ResourceManager rm = o.GetResourceManagerLanguage();
            labelTopAdminMenuForm.Text = rm.GetString("lbl_AMF_top") + o.KorisnickoIme;
            btnWorkWithCamps.Text = rm.GetString("btn_AMF_WorkWIthCamps");
            btnWorkWithVolonter.Text = rm.GetString("btn_AMF_WorkWIthVolonters");
            btnWorkWithAdmin.Text = rm.GetString("btn_AMF_WorkWIthAdmins");
            btnSettings.Text = rm.GetString("btn_VMF_Podesavanja");
        }
        private void setTheme()
        {
            if ("".Equals(o.Tema))
            {
                ThemeManager.SetTheme("Purple", this);
            }
            else
            {
                ThemeManager.SetTheme(o.Tema, this);
            }
        }

    }
}
