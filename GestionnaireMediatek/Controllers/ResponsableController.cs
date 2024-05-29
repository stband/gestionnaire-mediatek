using System.Security.Cryptography;
using System.Text;
using GestionnaireMediatek.dal;
using GestionnaireMediatek.Models;
using System.Collections.Generic;

namespace GestionnaireMediatek.Controllers
{
    public static class ResponsableController
    {
        public static Responsable Authentifier(string identifiant, string motDePasse)
        {
            List<Responsable> responsables = Access.GetInstance().GetResponsables();
            string hashedPassword = HashPassword(motDePasse);

            foreach (Responsable responsable in responsables)
            {
                if (responsable.Login == identifiant && responsable.Password == hashedPassword)
                {
                    return responsable;
                }
            }
            return null;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
