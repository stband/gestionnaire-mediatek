namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Classe métier liée à la table responsable.
    /// Représente les informations du personnel pour la connexion à l'application.
    /// </summary>
    public class Responsable
    {
        /// <summary>
        /// Identifiant du responsable.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Mot de passe du responsable.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Responsable"/>.
        /// </summary>
        /// <param name="login">Identifiant du responsable.</param>
        /// <param name="password">Mot de passe du responsable.</param>
        public Responsable(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}

