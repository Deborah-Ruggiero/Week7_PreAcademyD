using System;
using System.IO;

namespace Week7_PreAcademyD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //try
            //{
            //    int a = 8;
            //    int b = 0;
            //    int c = a / b;
            //    Console.WriteLine($"Risultao della divisione: {c}");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Errore. Non puoi dividere per zero!!");
            //    Console.WriteLine(e.ToString());
            //}
            //catch (ArithmeticException eccezioneAritmetica)
            //{
            //    Console.WriteLine("Errore aritmetico!!");
            //    Console.WriteLine(eccezioneAritmetica.ToString());
            //}
            //catch (Exception eccezione)
            //{
            //    Console.WriteLine("Errore generico!!");
            //    Console.WriteLine(eccezione.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("Ciao");
            //}

            //LeggiFile();

            //Metodo1();

            InserisciDatiArray();

        }

        private static void InserisciDatiArray()
        {
            try
            {
                int[] array = new int[10];
                Console.WriteLine("Inserisci un numero");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci la posizione in cui va inserito");
                int posizione = int.Parse(Console.ReadLine());

                array[posizione] = numero;
                Console.WriteLine("L'array è:");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException )
            {
                Console.WriteLine("Errore dimesione array");
                InserisciDatiArray();
            }
            catch (FormatException )
            {
                Console.WriteLine("Errore formato");
            }
            catch (Exception )
            {
                Console.WriteLine("Errore generico");
            }
           
            
        }

        private static void Metodo1()
        {
            try
            {
                Console.WriteLine("Metodo1");
                ChiediNumeri();
            }catch(Exception ex)
            {
                Console.WriteLine($"Eccezione catturata nel metodo 1:{ex.ToString()} ");
            }
            
        }

        private static void ChiediNumeri()
        {
            try
            {
                Console.WriteLine("Inserisci numero1");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci numero2");
                int n2 = int.Parse(Console.ReadLine());

                int risultato = DividiNumeri(n1, n2);
                Console.WriteLine($"Il risultato della divisione è :{risultato}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore gestito nel metodo Chiedi Numero: {ex.ToString()}");
            }

        }

        private static int DividiNumeri(int n1, int n2)
        {
            return n1 / n2;
        }




        private static void LeggiFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Users\RenataCarriero\source\repos\Week7_PreAcademyD\Week7_PreAcademyD\FileDaLeggere.txt");
                string contenutoDelFile = sr.ReadToEnd();
                Console.WriteLine(contenutoDelFile);
            }catch(FileNotFoundException ex)
            {
                Console.WriteLine($"file non trovato. Errore: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Errore generico {ex.ToString()}");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
