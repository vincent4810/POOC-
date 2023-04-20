// See https://aka.ms/new-console-template for more information
using poo;

namespace poo
{
    
    public class Utilisateur{
        

        private string Nom { get; set;}

        private string Prenom {get; set;}
        private string Email { get; set;}
        private InformationsAuth Auth { get; set; }
        private List<Role> Role { get; set; }

        public Utilisateur(string nom, string prenom, string email, InformationsAuth auth, List<Role> Role){
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Auth = auth;
            this.Role = Role;
        }

        // protected Utilisateur()
        // {
        //     throw new NotImplementedException();
    
        // }
/// <summary>
/// Permet d'afficher la partie Utilisateur
/// </summary>
/// <param name="user1">Objet d'un utilisateur</param>
        public static void afficher(Utilisateur user1){
            Console.WriteLine($"L'utilisateur est {user1.Nom} {user1.Prenom}, son email est {user1.Email}");
        }

       
    }
}