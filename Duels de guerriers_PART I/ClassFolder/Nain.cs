using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duels_de_guerriers_PART_I.ClassFolder
{
    internal class Nain : Guerrier
    {
        private bool portArmure;
        public Nain(string nom, int pointsDeVie, int nbDesAttaque, bool portArmure) : base(nom, pointsDeVie, nbDesAttaque)
        {
        }

        private bool ArmureLourde()
        {
            Random avecSans = new Random();
            int avecSansArmure = avecSans.Next(0, 2);
            return avecSansArmure == 1; // true si l'armure est portée (1), sinon false
        }

        // Réduit les points de vie
        public string SubirDegats(int degats)
        {
            if (ArmureLourde())
            {
                PointsDeVie -= degats / 2;
                return "A bénéficié d'un Armure de la mort et ";
            }
            else
            {
                PointsDeVie -= degats;
                return PointsDeVie.ToString();// Applique les dégâts normaux si l'armure n'est pas portée
            }

            
        }


        //private bool ArmureLourde()
        //{
        //    int armureLourde = 1;
        //    int avecSansArmure = 0;
        //    Random avecSans = new Random();
        //    for (int j = 0; j < armureLourde; j++)
        //    {
        //        Console.WriteLine(avecSans.Next(0, 2));
        //        avecSansArmure++;
        //    }
        //    return avecSansArmure;
        //}  





        // Réduit les points de vie
        //public int SubirDegats(int degats)
        //{
        //    bool portArmure = false;
        //    if (portArmure = true)
        //    {
        //        PointsDeVie -= degats / 2;

        //    }
        //    return degats;
        //}
        //private bool ArmureLourde()
        //{
        //    int degatsNain;
        //    bool portArmure;
        //    if (portArmure = true)
        //    {
        //        degatsNain = SubirDegats / 2 ;  
        //    }
        //    return true;
        //}

        //public override bool SubirDegats()
        //{
        //    int subirDegats = base.Attaquer();
        //    if (subirDegats > 0)
        //    {
        //        subirDegats += 2;
        //    }
        //    return degats;
        //}
    }
}
