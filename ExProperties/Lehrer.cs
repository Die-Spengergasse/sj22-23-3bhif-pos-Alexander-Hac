using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties
{
    class Lehrer
    {
        public string Vorname { get; set; } = "";

        public string Zuname { get; set; } = default(string);

        private decimal? bruttogehalt = default(decimal?);

        public decimal? Bruttogehalt
        {
            get { return bruttogehalt; }
            set { bruttogehalt = bruttogehalt ?? value; } 
        }

        public string Kuerzel
        {
            get { return Zuname?.ToUpper().Substring(0, 3) ?? "";}
        }

        public decimal? Nettogehalt
        {
            get { return Bruttogehalt * 0.8M ?? 0M; }
        }


    }
}
    