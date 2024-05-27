namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Classe métier liée à la table Service. Représente un service dans l'organisation.
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
    }
}
