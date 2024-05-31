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

        public static void UpdatePersonnel(Personnel personnel)
        {
            Access.GetInstance().UpdatePersonnel(personnel);
        }
    }
}
