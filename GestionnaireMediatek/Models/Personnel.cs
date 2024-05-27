namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Représente un membre du personnel.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Identifiant unique du personnel.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Nom du personnel.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du personnel.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Adresse email du personnel.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Indique si le personnel a des droits administratifs.
        /// </summary>
        public int IdAdmin { get; set; }

        /// <summary>
        /// Identifiant du service auquel le personnel est rattaché.
        /// </summary>
        public int IdService { get; set; }
    }
}
