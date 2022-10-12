using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties
{
    class Rechteck
    {

        public Rechteck()
        {

        }   

        private int laenge, breite;


        public int Laenge
        {
            get { return laenge; }
            set { laenge = value >= 0 ? value : throw new ArgumentException("Ungültige Länge"); }
        }

        public int Breite
        {
            get { return breite; }
            set { breite = value >= 0 ? value : throw new ArgumentException("Ungültige Länge"); }
        }

        public int Flaeche
        {
            get { return Laenge * Breite; }
        }


    }
}
    