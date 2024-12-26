
using Duels_de_guerriers_PART_I.ClassFolder;

namespace Duels_de_guerriers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création de deux guerriers
            Guerrier guerrier_1 = new Guerrier("Lancelot", 10, 4);
            Guerrier guerrier_2 = new Guerrier("Galahad", 10, 4);

            Console.WriteLine("Début du duel !");
            guerrier_1.AfficherInfos();
            guerrier_2.AfficherInfos();

            // Duel jusqu'à ce qu'un des guerriers n'ait plus de PV
            while (guerrier_1.GetPointsDeVie() > 0 && guerrier_2.GetPointsDeVie() > 0)
            {
                // guerrier_1 attaque guerrier_2
                int degats = guerrier_1.Attaquer();
                guerrier_2.SubirDegats(degats);

                //Vérification si guerrier_2 est encore en vie
                if (guerrier_2.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine($"{guerrier_1.GetNom()} a gagné le duel  en {guerrier_1.NbCoups()} coups !!");
                    break;
                }

                // guerrier_2 attaque guerrier_1
                degats = guerrier_2.Attaquer();
                guerrier_1.SubirDegats(degats);

                // Vérification si guerrier_1 est encore en vie
                if (guerrier_1.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine($"{guerrier_2.GetNom()} a gagné le duel en {guerrier_2.NbCoups()} coups !");
                    
                    break;
                }
            }

            Console.WriteLine("Fin du duel !");
        }
    }
}
