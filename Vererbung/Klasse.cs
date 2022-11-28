using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Klasse : List<Schueler>
    {
        public Klasse(string id)
        {
            Id = id;
        }
        public string Id { get; }

        public Lehrer Kv { get; set; }

        
        public new void Add (Schueler s)
        {
            if(!this.Contains(s))
            {
              List<Schueler> sl = this;
              sl.Add(s);           
            } else
            {
                throw new InvalidOperationException();
            }
        }
       
        public override string ToString()
        {
            return $"Klasse {this.Id}, KV: {this.Kv.Zuname}, Schüleranzahl: {this.Count} ";
        }
    }
}
