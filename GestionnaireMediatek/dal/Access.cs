using GestionnaireMediatek.bddmanager;
using System;
using System.Configuration;

namespace GestionnaireMediatek.dal
{
    /// <summary>
    /// Singleton : gestionnaire d'accès à la base de données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// Nom de la chaîne de connexion dans le fichier de configuration
        /// </summary>
        private static readonly string connectionName = "GestionnaireMediatek.Properties.Settings.mediatekConnectionString";
        /// <summary>
        /// Instance unique de la classe Access
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Gestionnaire de base de données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Constructeur privé pour initialiser la connexion à la base de données
        /// </summary>
        private Access()
        {
            string connectionString = null;
            try
            {
                connectionString = GetConnectionStringByName(connectionName);
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Access.Access catch connectionString={connectionString} erreur={e.Message}");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Obtient l'instance unique de la classe Access
        /// </summary>
        /// <returns>Instance unique de la classe Access</returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        /// <summary>
        /// Récupère la chaîne de connexion par son nom dans le fichier de configuration
        /// </summary>
        /// <param name="name">Nom de la chaîne de connexion</param>
        /// <returns>Chaîne de connexion</returns>
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
    }
}
