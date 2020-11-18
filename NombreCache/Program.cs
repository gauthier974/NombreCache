/**
 * Jeu du nombre caché
 * author : Emds
 * date : 23/05/2020
 */
using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace NombreCache
{
    class Program
    {
        static int saisie(string message, int borneMin, int borneMax) // test modification de code
        {
            Console.Write(message + " entre " + borneMin + " et " + borneMax + " = ");
            int nombre = 0;
            bool correct = false;
            while (!correct || nombre > borneMax || nombre < borneMin)
            {
                try
                {
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez une nombre entier");
                }
            }
            return nombre;
        }
        static void Main(string[] args)
        {

            // déclaration
            int valeur = 0, nbre = 1;
            int essai = 0;
            int min = 0, max = 100;
            // saisie du nombre à chercher
            valeur = saisie("Entrez une valeur", min, max);
            Console.Clear();
            // saisie du premier essai
            essai = saisie("Entrez un essai", min, max);
            // boucle sur les essais
            while (essai != valeur)
            {
                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)
                {
                    Console.WriteLine(" --> trop grand !");
                }
                else if (essai < valeur)
                {
                    Console.WriteLine(" --> trop petit !");
                }
                // saisie d'un nouvel essai
                essai = saisie("Entrez un essai", min, max);
                // compteur d'essais
                nbre++;
            }
            // valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois !");
            Console.ReadLine();
        }
    }
}
