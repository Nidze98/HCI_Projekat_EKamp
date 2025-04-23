using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.Models
{
    internal class KorisnikKampa : Osoba
    {
        public string TipNesrece { get; set; }
        public string Status { get; set; }
        public string VolonterJMB { get; set; }
        public DateTime DatumDO { get; set; }
        public DateTime DatumOD { get; set; }
        public string KorisnikKampaJMB { get; set; }
        public int KampID { get; set; }


    }
}