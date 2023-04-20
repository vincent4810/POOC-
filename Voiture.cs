namespace poo
{
    

    public class Voiture : Vehicule
    {
        private int VolumeCoffre { get; set; }

        public Voiture(string marque, string modele, DateOnly anneeFab, DateOnly anneeMiseEnCirculation, int numeroSerie, string typeCarburant, int poids, Immatriculation imat, int volCoffre) : base(marque, modele, anneeFab, anneeMiseEnCirculation, numeroSerie, typeCarburant, poids, imat)
        {
            this.VolumeCoffre = volCoffre;
        }
    }
}
