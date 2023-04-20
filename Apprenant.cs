namespace poo
{
    

    public class Apprenant : Utilisateur
    {
        public string Region { get; set; }
        
        public string Niveau { get; set; }

        public Apprenant(string nom, string prenom, string email,InformationsAuth auth,List<Role> role, string region, string niveau) : base(nom, prenom, email, auth, role)
        {
            this.Region = region;
            this.Niveau = niveau;
        }
    }
}
