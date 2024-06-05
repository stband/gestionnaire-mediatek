namespace GestionnaireMediatek.Models
{
    /// <summary>
    /// Classe métier liée à la table Absence de la bdd.
    /// Représente les caractéritiques d'une absence.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant du personnel concerné par l'absence.
        /// </summary>
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Date de début de l'absence.
        /// </summary>
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence, si applicable.
        /// </summary>
        public DateTime? DateFin { get; set; }

        /// <summary>
        /// Identifiant du motif de l'absence.
        /// </summary>
        public int IdMotif { get; set; }
    }
}
