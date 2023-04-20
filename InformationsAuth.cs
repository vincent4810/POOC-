using poo;
namespace poo;

public class InformationsAuth
{
    public string Login { get; set; }
    public string Mdp { get; set; }

    public InformationsAuth(string login, string mdp)
    {
        this.Login = login;
        this.Mdp = mdp;
    }

    
}