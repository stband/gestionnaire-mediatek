using System.Collections.Generic;
using GestionnaireMediatek.Models;
using GestionnaireMediatek.dal;

namespace GestionnaireMediatek.Controllers
{
    /// <summary>
    /// Contrôleur pour la gestion des opérations sur le personnel.
    /// </summary>
    public static class PersonnelController
    {
        /// <summary>
        /// Récupère la liste du personnel.
        /// </summary>
        /// <returns>Liste du personnel.</returns>
        public static List<Personnel> GetPersonnel()
        {
            return Access.GetInstance().GetPersonnel();
        }

        /// <summary>
        /// Ajoute un nouveau membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet Personnel à ajouter.</param>
        public static void AddPersonnel(Personnel personnel)
        {
            Access.GetInstance().AddPersonnel(personnel);
        }

        /// <summary>
        /// Met à jour les informations d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet Personnel à mettre à jour.</param>
        public static void UpdatePersonnel(Personnel personnel)
        {
            Access.GetInstance().UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère la liste des services de l'entreprise.
        /// </summary>
        /// <returns>Liste des services.</returns>
        public static List<Service> GetServices()
        {
            return Access.GetInstance().GetServices();
        }

        /// <summary>
        /// Supprime un membre du personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel à supprimer.</param>
        public static void DeletePersonnel(int idPersonnel)
        {
            Access.GetInstance().DeletePersonnel(idPersonnel);
        }

        /// <summary>
        /// Récupère la liste des absences d'un personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel.</param>
        /// <returns>Liste des absences.</returns>
        public static List<Absence> GetAbsences(int idPersonnel)
        {
            return Access.GetInstance().GetAbsences(idPersonnel);
        }

        /// <summary>
        /// Récupère la liste des motifs d'absence.
        /// </summary>
        /// <returns>Liste des motifs.</returns>
        public static List<Motif> GetMotifs()
        {
            return Access.GetInstance().GetMotifs();
        }

        /// <summary>
        /// Ajoute une nouvelle absence à un personnel.
        /// </summary>
        /// <param name="absence">Objet Absence à ajouter.</param>
        public static void AddAbsence(Absence absence)
        {
            Access.GetInstance().AddAbsence(absence);
        }

        /// <summary>
        /// Met à jour une absence existante d'un personnel.
        /// </summary>
        /// <param name="absence">Objet Absence à mettre à jour.</param>
        /// <param name="oldDateDebut">Ancienne date de début de l'absence.</param>
        public static void UpdateAbsence(Absence absence, DateTime oldDateDebut)
        {

            Access.GetInstance().UpdateAbsence(absence, oldDateDebut);
        }

        /// <summary>
        /// Supprime une absence d'un personnel.
        /// </summary>
        /// <param name="absence">Objet Absence à supprimer.</param>
        public static void DeleteAbsence(Absence absence)
        {
            Access.GetInstance().DeleteAbsence(absence);
        }
    }
}
