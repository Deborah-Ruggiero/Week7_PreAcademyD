using AppContravvenzioni.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContravvenzioni
{
    static class Menu
    {
        static IRepository<Contravvenzione> repo = new RepoContravvenzione();
        static public void Start()
        {
            Console.WriteLine("Benvenuto nella getstione delle Contravvenzioni\n");
            
            bool continua = true;
            do
            {
                Console.WriteLine("\n**************MENU******************\n");
                Console.WriteLine("Premi 1 per visualizzare contravvenzioni");                
                Console.WriteLine("Premi 0 per uscire");

                int scelta=Scegli();
                //do
                //{
                //    Console.WriteLine("Fai la tua scelta tra le possibili opzioni");
                //} while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 5));

                switch (scelta)
                {
                    case 1: //if(scelta==1)
                        VisualizzaMulte();
                        break;
                    case 0:
                        Console.WriteLine("Arrivederci!");
                        continua = false;
                        break;
                    case -1:
                        Console.WriteLine("Scelta errata");
                        break;                        
                }
            } while (continua == true);
        }

        private static int Scegli()
        {
            try
            {
                Console.WriteLine("Fai la tua scelta tra le possibili opzioni");
                int scelta = int.Parse(Console.ReadLine());
                return scelta;
            }
            catch
            {
                Console.WriteLine("Errore!!");
                return -1;
            }
            
        }

        private static void VisualizzaMulte()
        {
            List<Contravvenzione> multe= repo.GetAll();
            foreach (var item in multe)
            {
                Console.WriteLine(item);
            }

        }
    }

}
