using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICES_1_Fonctions_et_procédures
{
    internal class Program
    {

        static int difference(int a, int b)
        {
            int somme=a+b;
            int produit = a * b;
            return produit - somme;
            
        }
        static void Main(string[] args)
        {
           
            int a;
            int b;
            
                Console.WriteLine("Saisie un entier");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("la valeur est {0}", a);
                Console.WriteLine("Saisie un autre entier");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("la valeur est {0}", b);


                Console.WriteLine("La différence entre le produit et la somme est: {0}",difference (a,b));
                Console.ReadKey();

        }
    }
}
