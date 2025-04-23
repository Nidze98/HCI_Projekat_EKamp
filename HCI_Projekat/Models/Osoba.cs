using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat.Models
{
    public class Osoba

    {
        public Osoba() { }
        public string JMB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public char Pol { get; set; }
        public string Drzavljanstvo { get; set; }
        public string MjestoPrebivalista { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Osoba other = (Osoba)obj;
            return JMB.Equals(other.JMB);
        }

    }
}
