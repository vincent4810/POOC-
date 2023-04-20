namespace poo;

public class Immatriculation
{
    private string Numero { get; set; }
    
    private string Pays { get; set; }

    public Immatriculation(string numero, string pays)
    {
        this.Numero = numero;
        this.Pays = pays;
    }
}