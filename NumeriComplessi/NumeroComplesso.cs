using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeriComplessi
{
    class NumeroComplesso
    {
        //a + ib
        public double ParteReale { get; set; }
        public double ParteImmaginaria { get; set; }


        public NumeroComplesso Divisione(NumeroComplesso value)
        {
            //a + ib
            //c + id
            // ((ac + bd)/(c^2+d^2)) + i((bc-ad)/(c^2 + d^2))

            try
            {
                //c^2+d^2
                double denom = Math.Pow(value.ParteReale, 2) + Math.Pow(value.ParteImmaginaria, 2);

                if (denom == 0)
                {
                    //lancio Eccezione personalizzata "NumeroComplessoException"
                    throw new NumeroComplessoException("Non è possibile realizzare questa divisione perchè il divisore è uguale a zero")
                    {
                        PrimoOperatore = this,
                        SecondoOperatore = value
                    };
                }


                // (ac + bd)/denom
                double parteRealeRisultato = ((this.ParteReale * value.ParteReale) + (this.ParteImmaginaria * value.ParteImmaginaria)) / denom;

                //i(bc-ad)/denom
                double parteImmaginariaRisultato = ((this.ParteImmaginaria * value.ParteReale) - (this.ParteReale * value.ParteImmaginaria)) / denom;

                return new NumeroComplesso
                {
                    ParteReale = parteRealeRisultato,
                    ParteImmaginaria = parteImmaginariaRisultato
                };
            }
            catch (NumeroComplessoException ncex)
            {
                Console.WriteLine(ncex.Message);
                Console.WriteLine($"Dividendo: {ncex.PrimoOperatore} - Divisore: {ncex.SecondoOperatore}");
                return null;
            }

        }

        public override string ToString()
        {
            if (ParteImmaginaria < 0)
            {
                return $"{ParteReale} - {Math.Abs(ParteImmaginaria)}i";
            }
            return $"{ParteReale} + {ParteImmaginaria}i";
        }

    }
}
