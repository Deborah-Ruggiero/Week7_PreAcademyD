using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni.Entities
{
    public class Contravvenzione
    {
        public int Numero { get; set; }
        public Vigile Vigile { get; set; }
        public Veicolo Veicolo { get; set; } 
        public string Luogo { get; set; }
        public DateTime DataContravvenzione { get; set; }
        public Contravvenzione()
        {

        }
        public Contravvenzione(int numero, string luogo, DateTime data, Vigile vigile, Motociclo motociclo)
        {
            Numero = numero;
            Luogo = luogo;
            DataContravvenzione = data;
            Veicolo = motociclo;
            Vigile = vigile;
        }
        public Contravvenzione(int numero, string luogo, DateTime data, Vigile vigile, Automobile automobile)
        {
            Numero = numero;
            Luogo = luogo;
            DataContravvenzione = data;
            Veicolo = automobile;
            Vigile = vigile;
        }
        public override string ToString()
        {
            return $"Verbale n.{Numero} - Data:{DataContravvenzione.ToShortDateString()}, luogo: {Luogo} - Vigile:{Vigile.ToString()} - Veicolo:{Veicolo.ToString()}";
        }
    }
}
