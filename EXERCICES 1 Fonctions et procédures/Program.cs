using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICES_1_Fonctions_et_procédures
{
    internal class Program
    {

        static int absolue(int a)
        {
            if (a >= 0) return a;
            else return -a;
        }
        static void Main(string[] args)
        {
           
                int a;

                Console.WriteLine("Saisie le valeur entière d'un nombre");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("la valeur est {0}", a);   
                
                Console.WriteLine("La valeur absolu est: {0}",absolue (a));
                Console.ReadKey();

        }
    }
}
