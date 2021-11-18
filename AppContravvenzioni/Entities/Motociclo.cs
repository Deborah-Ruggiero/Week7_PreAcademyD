using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni.Entities
{
    public class Motociclo : Veicolo
    {
        public string NumeroTelaio { get; set; }
        //public override string ToString()
        //{
        //    return $"Targa Moto: {Targa} - Telaio n. {NumeroTelaio}";
        //}
    }
}
