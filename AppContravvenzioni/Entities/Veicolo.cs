using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni.Entities
{
    public abstract class Veicolo
    {
        public string Targa { get; set; }
        public IList<Contravvenzione> Contravvenzioni { get; set; } = new List<Contravvenzione>();
        public override string ToString()
        {
            return $"Targa: {Targa}";
        }
    }
}
