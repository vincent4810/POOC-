using System;

namespace poo
{
    public class Vehicule{
        private string Marque { get; set; }
        private string Modele { get; set; }
        private DateOnly AnneeFabrication { get; set; }
        private DateOnly AnneeMiseEnCirculation { get; set; }
        private int NumeroSerie { get; set; }
        private string TypeCarburant { get; set; }
        private int Poids { get; set; }
        private Immatriculation Immat { get; set; }

        public Vehicule(string marque, string modele, DateOnly anneeFab, DateOnly anneeMiseEnCirculation, int numeroSerie, string carburant, int poids, Immatriculation immat)
        {
            this.Marque = marque;
            this.Modele = modele;
            this.AnneeFabrication = anneeFab;
            this.AnneeMiseEnCirculation = anneeMiseEnCirculation;
            this.NumeroSerie = numeroSerie;
            this.TypeCarburant = carburant;
            this.Poids = poids;
            this.Immat = immat;
        }

        public static void Avancer(){
            Console.WriteLine("Avancer");
        }

        public static void Reculer(){
            Console.WriteLine("Reculer ");
        }

        public static void Demarer(){
            Console.WriteLine("demarer");
        }

        public static void Tourner()
        {
            
        }
    }
}