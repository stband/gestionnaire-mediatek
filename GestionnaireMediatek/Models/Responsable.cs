namespace GestionnaireMediatek.Models
{
    public class Responsable
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Responsable(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}

