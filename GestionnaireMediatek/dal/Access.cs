using GestionnaireMediatek.bddmanager;
using GestionnaireMediatek.Models;
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

        public List<Responsable> GetResponsables()
        {
            List<Responsable> responsables = new List<Responsable>();
            string query = "SELECT * FROM responsable";
            var records = Manager.ReqSelect(query);
            foreach (var record in records)
            {
                responsables.Add(new Responsable((string)record[0], (string)record[1]));
            }
            return responsables;
        }

        public List<Personnel> GetPersonnel()
        {
            List<Personnel> personnelList = new List<Personnel>();
            string query = "SELECT idPersonnel, nom, prenom, tel, mail, idService FROM personnel";
            var records = Manager.ReqSelect(query);
            foreach (var record in records)
            {
                personnelList.Add(new Personnel(
                    (int)record[0],
                    (string)record[1],
                    (string)record[2],
                    (string)record[3],
                    (string)record[4],
                    (int)record[5]
                ));
            }
            return personnelList;
        }

    }
}
