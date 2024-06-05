using System.Collections.Generic;
using GestionnaireMediatek.Models;
using GestionnaireMediatek.dal;

namespace GestionnaireMediatek.Controllers
{
    public static class PersonnelController
    {
        public static List<Personnel> GetPersonnel()
        {
            return Access.GetInstance().GetPersonnel();
        }

        public static void AddPersonnel(Personnel personnel)
        {
            Access.GetInstance().AddPersonnel(personnel);
        }

        public static void UpdatePersonnel(Personnel personnel)
        {
            Access.GetInstance().UpdatePersonnel(personnel);
        }
        public static List<Service> GetServices()
        {
            return Access.GetInstance().GetServices();
        }

        public static void DeletePersonnel(int idPersonnel)
        {
            Access.GetInstance().DeletePersonnel(idPersonnel);
        }

        public static List<Absence> GetAbsences(int idPersonnel)
        {
            return Access.GetInstance().GetAbsences(idPersonnel);
        }

        public static List<Motif> GetMotifs()
        {
            return Access.GetInstance().GetMotifs();
        }

        public static void AddAbsence(Absence absence)
        {
            Access.GetInstance().AddAbsence(absence);
        }

        public static void UpdateAbsence(Absence absence, DateTime oldDateDebut)
        {

            Access.GetInstance().UpdateAbsence(absence, oldDateDebut);
        }

        public static void DeleteAbsence(Absence absence)
        {
            Access.GetInstance().DeleteAbsence(absence);
        }
    }
}
