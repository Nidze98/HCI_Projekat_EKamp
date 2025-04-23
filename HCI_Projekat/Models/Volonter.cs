using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HCI_Projekat.Models
{
    public class Volonter:Osoba
    {
        public Volonter() { 
         
        }
      
        
        
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Status { get; set; }
        public int KampID {  get; set; } 
        public Kamp Kamp { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Jezik { get; set; }= String.Empty;
        public string Tema { get; set; } = String.Empty;
        public ResourceManager rm { get; set; }=null;
        public void setKamp()
        {
            Console.WriteLine(this.JMB);
            List<Kamp> kampList = DBUtil.DBUtil.LoadCampsFromDatabase();
            Kamp kamp = kampList.Where(a => this.KampID==a.id).FirstOrDefault();
            if (kamp != null)
            {
                KampID = kamp.id;
                this.Kamp=kamp;
            }
        }
        public  ResourceManager GetResourceManagerLanguage()
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



    }
}
