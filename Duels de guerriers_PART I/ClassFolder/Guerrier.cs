using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duels_de_guerriers_PART_I.ClassFolder
{
    internal class Guerrier
    {
        //valeur par défaut
        private const int PvParDefaut = 100;
        private const int PvMin = 1;
        private const int PvMax = 10;

       
        //Attributs
        private string _nomGuerrier;
        private int _pointsDeVie;
        private int _nbAttaque;



        //Propriétées
        public string NomGuerrier { get{  return _nomGuerrier;} set{ _nomGuerrier = value;}}
        
        public int PointsDeVie
        {
            get => _pointsDeVie;

            set
            {
                //if (_pointsDeVie < PvMin)
                //{
                //    throw new ArgumentOutOfRangeException(nameof(value), $"Vos point de vie sont à {value}. Vous ne pouvez plus jouer. Bye bye...");
                //}
                //else
                //{
                //    _pointsDeVie = value;
                //}
                _pointsDeVie = value;

            }

        }
         
        public int NbAttaque { get => _nbAttaque; set { _nbAttaque = value; } }

        //Constructeur (méthodes)

        public Guerrier(string nom, int pointsDeVie, int nbDesAttaque)
        {
            NomGuerrier = nom;
            PointsDeVie = pointsDeVie;
            NbAttaque = nbDesAttaque;
        }

        public static int pointsDeVie { get; private set; } = 0;
        public int nbDesAttaque { get; private set; } = 0;

        //Getter
        public string GetNom()
        {  return NomGuerrier; }

        public int GetPointsDeVie()
        { return _pointsDeVie; }        

        //Setter
        public void SetPointsDeVie()
        {  _pointsDeVie = 0; }        


        //Methodes essentielles
        public void AfficherInfos()
        {
            Console.WriteLine($"{NomGuerrier} --> PV = {PointsDeVie} ");
        }

        public int GetNbDesAttaque()
        {
            return nbDesAttaque;

            //Console.WriteLine($"Nombres de coups --> {nbDesAttaque}");
        }

        //Simuler une attaque en lançant des dés (valeurs aléatoires entre 1 et 6

        private Random lancerDe = new Random();


        public int Attaquer()
        {            
            int degat = lancerDe.Next(1, 7);
            nbDesAttaque++; // Incrémente le compteur de coups
            Console.WriteLine($"{NomGuerrier} attaque et inflige {degat} dégâts.");
            

            return degat;
        }

        // Réduit les points de vie
        public void SubirDegats(int degats)
        {
            PointsDeVie -= degats;
            


            Console.WriteLine($"{NomGuerrier} subit {degats} dégâts et a maintenant {PointsDeVie} PV.");
        }

        private Random duel = new Random();

        //public string ChoixGuerrier(string gerriers)
        //{
        //    gerriers = duel.Next(1, 7);
        //}



    }
}
