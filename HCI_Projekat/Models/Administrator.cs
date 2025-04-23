using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.Models
{
    public class Administrator : Osoba
    {
        public Administrator() { }

        public string KorisnickoIme { get; set; }

        [Browsable(false)]
        public string Lozinka { get; set; }

        public string Jezik {  get; set; }=String.Empty;  
        public string Tema {  get; set; }= String.Empty;
        public ResourceManager rm { get; set; } = null;
        public Boolean SuperAdmin {  get; set; }

        public ResourceManager GetResourceManagerLanguage()
        {
            if ("Srpski".Equals(this.Jezik) || "".Equals(this.Jezik))
            {
                rm = new ResourceManager("HCI_Projekat.ResourceSRB", typeof(ResourceSRB).Assembly);
            }
            else if ("English".Equals(this.Jezik))
            {
                rm = new ResourceManager("HCI_Projekat.ResourceEN", typeof(ResourceEN).Assembly);
            }
            return rm;

        }

        //create Camp method
    }
}
