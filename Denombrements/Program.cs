using System;

namespace Denombrements
{
    /// <summary>
    /// Interface de denombrement
    /// permet 3 type de calculs
    /// </summary>
    class Program
    {
        /// <summary>
        /// calcul de produit de plusieurs entiers successif, de nb1 à nbr2
        /// </summary>
        /// <param name="nbr1"></param>
        /// <param name="nbr2"></param>
        /// <returns></returns>
        static long calcul(int nbr1, int nbr2)
        {
            long r = 1;
            for (int k = nbr1; k <= nbr2; k++)
                r *= k;
            return r;
        }
        /// <summary>
        /// menu permettant le choix de permutation, arrangement, combinaison ou quitter
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string reponse = "1";
            while (reponse != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                reponse = Console.ReadLine();

                if (reponse == "1" || reponse == "2" || reponse == "3")
                {
                    try
                    {
                        if (reponse == "1")
                        {
                            // calcul de la permutation
                            Console.Write("nombre total d'éléments à gérer = ");
                            int n = int.Parse(Console.ReadLine());
                            long permutation = calcul(1, n);
                            Console.WriteLine(n + "! = " + permutation);
                        }
                        else
                        {
                            if (reponse == "2")
                            {
                                // Calcul de l'arrangement
                                Console.Write("nombre total d'éléments à gérer = ");
                                int t = int.Parse(Console.ReadLine());
                                Console.Write("nombre d'éléments dans le sous ensemble = ");
                                int n = int.Parse(Console.ReadLine());
                                long arrangement = calcul((t - n + 1), t);
                                Console.WriteLine("A(" + t + "/" + n + ") = " + arrangement);
                            }
                            else
                            {
                                // calcul de la combinaison
                                Console.Write("nombre total d'éléments à gérer = ");
                                int t = int.Parse(Console.ReadLine());
                                Console.Write("nombre d'éléments dans le sous ensemble = ");
                                int n = int.Parse(Console.ReadLine());
                                long combinaison1 = calcul((t - n + 1), t);
                                long combinaison2 = calcul(1, n);
                                Console.WriteLine("C(" + t + "/" + n + ") = " + (combinaison1 / combinaison2));
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("valeur non enregistré");
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
