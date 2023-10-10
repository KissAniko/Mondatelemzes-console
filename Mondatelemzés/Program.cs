using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Mondatelemzés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kérjen be egy mondatot, ami ha nem felel meg az alábbiaknak, akkor ismételje meg!
             * A  - Mondat végén legyen a következők valamelyike [ . ? ! ]!
             * B  - A mondat nagybetűvel kezdődjön!
             * C  - A mondat legalább 3 szóból álljon!  Megjegyzés: szóköz a szóelválasztó.
             * Ha megfelel, akkor legyen vége a mondatnak.  */



            // REFAKTORÁLÁS ---> rövidebb lesz a kód.
            /*

                        // A feltétel:

                        bool joMondat; 

                        do
                        {

                            joMondat = true;
                            Console.WriteLine("Kérem a mondatot");
                            string mondat = Console.ReadLine();            */

            /*
            Char utolsoKarakter = mondat[mondat.Length - 1];
            if (utolsoKarakter != '.' && utolsoKarakter != '?' && utolsoKarakter != '!')
            {
                joMondat = false;                  
                continue;
            }
            */

            /*
                // A feltétel másképp:
                if(!mondat.EndsWith(".") && !mondat.EndsWith("?") && !mondat.EndsWith("!"))
                
                {

                    joMondat = false;
                    Console.WriteLine("Nem tett a mondat végére írásjelet! Próbálja újra!");
                    continue;

                }

                //B feltétel:
                if (mondat[0].ToString().ToUpper() != mondat[0].ToString())
                {
                    joMondat = false;
                    Console.WriteLine("Nem nagybetűvel kezdte a mondatot! Próbálja Újra!");
                    continue;
                }

                // C feltétel:
                if(mondat.Split().Length < 3)
                {
                    joMondat = false;
                    Console.WriteLine("Három vagy több szóból állhat a mondat! Próbálja újra!");
                    continue;
                }               

            } while(!joMondat);

        }   */
            //-----------------------------------------------------------------------------------------------------------------


        // ----   bool joMondat;
            string mondat;
            do
            {

              // ---- joMondat = true;
                Console.WriteLine("Kérem a mondatot");
                mondat = Console.ReadLine();

/*
                // A feltétel:
                if (!VanMondatvegiIrasjel(mondat))

                {
                    joMondat = false;
                    Console.WriteLine("Nem tett a mondat végére írásjelet! Próbálja újra!");
                    continue;
                }

                //B feltétel:
                if (!NagybetuvelKezdodik(mondat))
                {
                    joMondat = false;
                    Console.WriteLine("Nem nagybetűvel kezdte a mondatot! Próbálja Újra!");
                    continue;
                }

                // C feltétel:
                if (!HaromSzobolAll(mondat))
                {
                    joMondat = false;
                    Console.WriteLine("Három vagy több szóból állhat a mondat! Próbálja újra!");
                    continue;
                }  */

            } while (!VanMondatvegiIrasjel(mondat) || !NagybetuvelKezdodik(mondat) || !HaromSzobolAll(mondat));
        }

             private static bool VanMondatvegiIrasjel (string mondat)
             {
               return mondat.EndsWith(".") || !mondat.EndsWith("?") || !mondat.EndsWith("!");
             }

             private static bool NagybetuvelKezdodik (string mondat)
             {
               return mondat[0].ToString().ToUpper() == mondat[0].ToString();
             }
        private static bool HaromSzobolAll(string mondat)
        {
            return mondat.Split().Length >= 3;
        }
      }
    }
     
