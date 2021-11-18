using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni.Entities
{
    public class Automobile : Veicolo
    {
        public int Potenza { get; set; }
        //public override string ToString()
        //{
        //    return $"Targa Auto: {Targa} - Potenza:{Potenza}";
        //}
    }
}
