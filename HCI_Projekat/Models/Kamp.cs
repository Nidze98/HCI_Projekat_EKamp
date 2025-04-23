using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.Models
{
    public class Kamp
    {
        public Kamp() { }

        public int id {  get; set; }    
        public int mjestoID { get; set; }
        public string administratorJMB { get; set; }
        //public string volonterJMB { get; set; }
        public string ime { get; set; }
        public string status { get; set; } = "Aktivan";
        public int statusID { get; set; } = 1;
        public int brojKorisnikaKampa { get; set; } = 0;

        public string getAdminName()
        {
            List<Osoba> peopleList = DBUtil.DBUtil.LoadOsobeList("admin");
            List<Administrator> administratorsList = peopleList.OfType<Administrator>().ToList();
            Administrator admin = administratorsList.Where(a => a.JMB.Equals(administratorJMB)).FirstOrDefault();
            if (admin != null) return admin.KorisnickoIme;
            else return "Nije u bazi";
        }
        public Mjesto getMjesto()
        {
            List<Mjesto> mjestoList = DBUtil.DBUtil.LoadMjestoList();
            Mjesto mjesto = mjestoList.Where(a => a.id.Equals(mjestoID)).FirstOrDefault();
            if (mjesto != null) return mjesto;
            else return null; 

        }
        public int getStatusID()
        {
            if (("Aktivan").Equals(status)) return 1;
            else if(("Neaktivan").Equals(status)) return 0;
            else return -1;
        }
        public string getVolonterName()
        {
            List<Osoba> osobe = DBUtil.DBUtil.LoadOsobeList("volonter");
            List<Volonter> volonterList = osobe.OfType<Volonter>().ToList();
            volonterList.ForEach(a => a.setKamp());
            Volonter volonter = volonterList.Where(a => a.KampID==this.id).FirstOrDefault();
            if (volonter != null) return volonter.KorisnickoIme;
            else return string.Empty;

        }
    }
}
