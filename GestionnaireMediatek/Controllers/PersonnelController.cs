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

    }
}
