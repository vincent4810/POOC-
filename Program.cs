// See https://aka.ms/new-console-template for more information

namespace poo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            InformationsAuth vincent = new InformationsAuth("vincek2", "azerty");
            InformationsAuth olivier = new InformationsAuth("olivier", "ytreza");
            InformationsAuth alex = new InformationsAuth("michouka", "pouik");

            Role apprenant = new Role("apprenant");
            Role formateur = new Role("formateur");

            List<Role> roleVincent = new List<Role>();
            roleVincent.Add(apprenant);

            List<Role> roleOlivier = new List<Role>();
            roleOlivier.Add(apprenant);
            roleOlivier.Add(formateur);

            List<Role> roleAlexandre = new List<Role>();
            roleAlexandre.Add(formateur);
            Utilisateur user1 = new Utilisateur("MICHEL", "Vincent", "vincent.michel1989@gmail.com", vincent, roleVincent);
            Formateur userFormateur = new Formateur("azerty", "olivier", "olivier@gmail.com", olivier, roleOlivier, 15, "OpenClassRoom");
            Apprenant userApprenant =
                new Apprenant("MICHEL", "Alexandre", "alexandre.michel@gmail.com", alex, roleAlexandre, "AURA", "bon");
            
            Utilisateur.afficher(user1);
            Formateur.afficher(userFormateur);
            Utilisateur.afficher(userApprenant);

        }
    }

}







