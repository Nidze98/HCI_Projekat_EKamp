using HCI_Projekat.DBUtil;
using HCI_Projekat.Models;
using HCI_Projekat.Properties;
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
    public partial class Login : Form
    {
        string loginLanguage = "Srpski";
        string loginTheme = "Purple";
        ResourceManager rm;
        public Login()
        {
            InitializeComponent();
            ThemeManager.SetTheme(loginTheme,this);

            // Apply the theme to the form
           // ThemeManager.ApplyTheme(this);

            setupTextlanguage(loginLanguage);
            cbLanguage.Text= loginLanguage;
            cbTheme.Text = loginTheme;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Models.Osoba o=  DBUtil.DBUtil.LogInUser(username, password);

            if (o is Models.Administrator){
            
                Administrator administrator = (Administrator)o;

                AdminMenuForm fm = new AdminMenuForm(administrator);
                this.Hide();
                fm.ShowDialog();
 
                tbPassword.Text = String.Empty;
                tbUsername.Text = String.Empty;
                this.Show();
            }
            else if (o is Models.Volonter) {

                Volonter volonter = (Volonter)o;
           
                VolonterForms.VolonterMenuForm vm = new VolonterForms.VolonterMenuForm(volonter);
                this.Hide();
                vm.ShowDialog();

                tbPassword.Text = String.Empty;
                tbUsername.Text = String.Empty;

                this.Show();
            }
            else if (o == null)
            {
                MessageBox.Show(rm.GetString("Pogresni podaci"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelTop_Click(object sender, EventArgs e)
        {

        }
        private void setupTextlanguage(string s)
        {
      
            if ("Srpski".Equals(s))
            {
                 rm = new ResourceManager("HCI_Projekat.ResourceSRB", typeof(ResourceSRB).Assembly);
            }
            else if ("English".Equals(s))
            {
                 rm = new ResourceManager("HCI_Projekat.ResourceEN", typeof(ResourceEN).Assembly);
            }
            labelTop.Text = rm.GetString("labelTopLogin");
            labelUsername.Text = rm.GetString("labelUsername");
            labelPassword.Text = rm.GetString("labelPassword");
            btnLogin.Text = rm.GetString("btn_Login_Login");
            lbLanguage.Text = rm.GetString("Jezik");
            lbTheme.Text = rm.GetString("Tema");
            
            
        }
        
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupTextlanguage(cbLanguage.SelectedIndex == -1 ? loginLanguage : cbLanguage.Text);

        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeManager.SetTheme(cbTheme.Text, this);
        }
    }
}
