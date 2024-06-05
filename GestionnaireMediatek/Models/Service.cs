namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Classe métier liée à la table Service.
    /// Représente les services dans l'organisation.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Identifiant unique du service.
        /// </summary>
        public int IdService { get; set; }

        /// <summary>
        /// Libellé du service.
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Constructeur d'un service.
        /// Initialise une nouvelle instance de la classe <see cref="Service"/> avec des paramètres spécifiés.
        /// </summary>
        /// <param name="idService">Identifiant unique du service.</param>
        /// <param name="libelle">Libellé du service.</param>
        public Service(int idService, string libelle)
        {
            IdService = idService;
            Libelle = libelle;
        }

        /// <summary>
        /// Constructeur d'un service sans params pour les cas spécifiques.
        /// Initialise une nouvelle instance de la classe <see cref="Service"/> sans params.
        /// </summary>
        public Service() { }
    }
}
