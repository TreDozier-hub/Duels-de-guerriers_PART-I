
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
            Nain gimli = new Nain("Gimli", 40, 2, true);

            Console.WriteLine("Début du duel !");
            guerrier_1.AfficherInfos();
            guerrier_2.AfficherInfos();
            gimli.AfficherInfos();

            // Duel jusqu'à ce qu'un des guerriers n'ait plus de PV
            while (guerrier_1.GetPointsDeVie() > 0 && gimli.GetPointsDeVie() > 0)
            {
                // guerrier_1 attaque guerrier_2
                int degats = guerrier_1.Attaquer();
                gimli.SubirDegats(degats);

                //Vérification si guerrier_2 est encore en vie
                if (guerrier_2.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine($"{guerrier_1.GetNom()} a gagné le duel  en {guerrier_1.GetNbDesAttaque()} coups !!");
                    break;
                }

                // guerrier_2 attaque guerrier_1
                degats = gimli.Attaquer();
                guerrier_1.SubirDegats(degats);

                string resultatAvecArmure = gimli.SubirDegats(degats);
                // Vérification si guerrier_1 est encore en vie
                if (guerrier_1.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine($"{gimli.GetNom()} {resultatAvecArmure} a gagné le duel en {gimli.GetNbDesAttaque()} coups !");
                    
                    break;
                }

                // Simuler des dégâts
                // Simuler des dégâts
                //int degats = 20;
                //nain.SubirDegats(degats);
                //Console.WriteLine($"{nain.Nom} a maintenant {nain.PointsDeVie} points de vie.");
                
            }
            
            Console.WriteLine("Fin du duel !");
        }
    }
}
