using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICES_1_Fonctions_et_procédures
{
    internal class Program
    {

        static string adresse (string nom, string prenom, string domaine)
        {
            string a=".";
            string b = "@";
        return prenom +a   +nom +b +domaine;
            
        }
        static void Main(string[] args)
        {
           
            string nom;
            string prenom;
            string domaine;
            
                Console.WriteLine("Saisie ton nom");
                nom=Console.ReadLine();
                Console.WriteLine("le nom est {0}", nom);
                Console.WriteLine("Saisie ton prénom");
                prenom=Console.ReadLine();
                Console.WriteLine("le prenom est {0}", prenom);
                Console.WriteLine("Saisie ton domaine");
                domaine=Console.ReadLine();
                Console.WriteLine("la valeur est {0}", domaine);

                Console.WriteLine("L'adresse mail est: {0}",adresse(nom,prenom,domaine));
                Console.ReadKey();

        }
    }
}
