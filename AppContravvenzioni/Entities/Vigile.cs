using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni.Entities
{
    public class Vigile
    {
        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public IList<Contravvenzione> ContravvenzioniEffettuate { get; set; } = new List<Contravvenzione>();

        public override string ToString()
        {
            return $" Matricola:{Matricola} - {Cognome} {Nome}";
        }
    }
}
