using System;

namespace nombre_magique
{
    internal class Program
    {
        static int DemanderNombre (int min, int max)
        {
            
            int nombreUtilisateur = max + 1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.WriteLine("Rentrer un nombre entre " + min + " et " + max + " : " );
                string reponse = Console.ReadLine();
                try
                {
                    nombreUtilisateur = int.Parse(reponse);


                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("Erreur: le nombre doit être entre " + min + " et " + max );
                        nombreUtilisateur = 0; // pour forcer a reboucler
                    }
                }

                catch
                {
                    Console.WriteLine("Erreur: rentrer un nombre valide");
                }
            }
            
         
            return nombreUtilisateur;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX+1);


            int nombre = NOMBRE_MAGIQUE +1;
           // int nbVies = 4;
            
            //while (nbVies > 0)
            for(int nbVies = 4; nbVies>0;  nbVies --)
            {

                Console.WriteLine(" Vies restantes:" + nbVies);
                 nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);


                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("Le nombre est plus grand");

                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouver le nombre magique");
                    break;
                }
                    
                
            }
           
            if(nombre != NOMBRE_MAGIQUE)
            {
                    Console.WriteLine("Vous avez perdu, le nombre magique etait " + NOMBRE_MAGIQUE);

            }





            }
    }
}