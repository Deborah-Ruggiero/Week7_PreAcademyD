using System;

namespace NumeriComplessi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisione tra numeri complessi!");
            Console.WriteLine("Inserisci parte reale del primo numero complesso");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Inserisci parte immaginaria del primo numero complesso");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Inserisci parte reale del secondo numero complesso");
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine("Inserisci parte immaginaria del secondo numero complesso");
            double.TryParse(Console.ReadLine(), out double d);

            NumeroComplesso primo = new NumeroComplesso { ParteReale = a, ParteImmaginaria = b };
            NumeroComplesso secondo = new NumeroComplesso { ParteReale = c, ParteImmaginaria = d };
            //try
            //{
            NumeroComplesso risultato = primo.Divisione(secondo);
            Console.WriteLine(risultato);
            //}
            //catch(NumeroComplessoException ncex)
            //{
            //    Console.WriteLine(ncex.Message);
            //    Console.WriteLine($"Dividendo: {ncex.PrimoOperatore} - Divisore: {ncex.SecondoOperatore}");

        }
    }
 
}
