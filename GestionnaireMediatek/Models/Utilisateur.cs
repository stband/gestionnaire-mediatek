namespace GestionnaireMediatek.Models
{
    public class Utilisateur
    {
        public int IdUtilisateur { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdPersonnel { get; set; }
    }
}
