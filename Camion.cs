namespace poo
{
    
    public class Camion : Vehicule
    {
        private int Contenance { get; set; }
        
        private int ChargeUtileMax { get; set; }
        
        public Camion(string marque, string modele, DateOnly anneeFab, DateOnly anneeMiseEnCirculation, int numeroSerie, string typeCarburant, int poids, Immatriculation immat, int contenance, int chargeUtileMax) : base(marque, modele, anneeFab, anneeMiseEnCirculation, numeroSerie, typeCarburant, poids, immat)
        {
            this.Contenance = contenance;
            this.ChargeUtileMax = chargeUtileMax;
        }
    }
}
