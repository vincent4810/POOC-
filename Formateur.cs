    
namespace poo
{
    class Formateur : Utilisateur
    {
        //Attribut
        public int Ancienneté { get; set; }
        
        public string AncienOF { get; set; }
        // Constructeur de class
        public Formateur(string nom, string prenom, string email,InformationsAuth auth, List<Role> role, int ancienneté, string ancienOf ) : base(nom, prenom, email, auth, role)
        {
            this.Ancienneté = ancienneté;
            this.AncienOF = ancienOf;
        }
        
        //Methode
        
    }
}