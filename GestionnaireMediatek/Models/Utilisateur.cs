namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Représente un utilisateur de l'application.
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Identifiant unique de l'utilisateur.
        /// </summary>
        public int IdUtilisateur { get; set; }

        /// <summary>
        /// Nom de connexion de l'utilisateur.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Mot de passe de l'utilisateur.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Identifiant du personnel associé à l'utilisateur.
        /// </summary>
        public int IdPersonnel { get; set; }
    }
}
