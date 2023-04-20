namespace poo;

public class Moto : Vehicule
{
    private int Cylindree { get; set; }
    
    private int HauteurSelle { get; set; }
    
    public Moto(string marque, string modele, DateOnly anneeFab, DateOnly anneeMiseEnCirculation, int numeroSerie, string typeCarburant, int poids, Immatriculation immat, int cylindree, int hauteurSelle) : base(marque, modele, anneeFab, anneeMiseEnCirculation, numeroSerie, typeCarburant, poids, immat)
    {
        this.Cylindree = cylindree;
        this.HauteurSelle = hauteurSelle;
    }
}