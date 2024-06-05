using System.Security.Cryptography;
using System.Text;
using GestionnaireMediatek.dal;
using GestionnaireMediatek.Models;
using System.Collections.Generic;

namespace GestionnaireMediatek.Controllers
{
    /// <summary>
    /// Contrôleur pour la gestion des opérations concernant le responsable de l'entreprise.
    /// </summary>
    public static class ResponsableController
    {
        /// <summary>
        /// Authentifie un responsable en vérifiant son identifiant et son mot de passe.
        /// </summary>
        /// <param name="identifiant">Identifiant du responsable.</param>
        /// <param name="motDePasse">Mot de passe du responsable.</param>
        /// <returns>Objet Responsable si l'authentification est réussie, sinon null.</returns>
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

        /// <summary>
        /// Hash un mot de passe en utilisant l'algorithme SHA-256.
        /// Le mot de passe du responsable dans la bdd doit être chiffré avec le même algorithme.
        /// Sinon il faut changer cette méthode.
        /// </summary>
        /// <param name="password">Mot de passe en clair.</param>
        /// <returns>Mot de passe haché en tant que chaîne hexadécimale.</returns>
        private static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Calculer le hash - retourne un tableau de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir le tableau de bytes en chaîne hexadécimale
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
