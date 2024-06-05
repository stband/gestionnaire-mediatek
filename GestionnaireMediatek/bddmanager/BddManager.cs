using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionnaireMediatek.bddmanager
{
    /// <summary>
    /// Singleton : connexion à la base de données et exécution des requêtes
    /// </summary>
    public class BddManager
    {
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;

        /// <summary>
        /// Constructeur pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        /// <returns>instance unique de la classe</returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Exécution d'une requête de type LCT (begin transaction...)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécution d'une requête de type LMD (insert, update, delete)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictionnaire contenant les paramètres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            Logger.Log($"Executing command: {command.CommandText}");
            foreach (MySqlParameter param in command.Parameters)
            {
                Logger.Log($"{param.ParameterName}: {param.Value}");
            }
            int rowsAffected = command.ExecuteNonQuery();
            Logger.Log($"Command executed successfully. Rows affected: {rowsAffected}");
        }

        /// <summary>
        /// Exécution d'une requête de type LID (select)
        /// </summary>
        /// <param name="stringQuery">requête</param>
        /// <param name="parameters">dictionnaire contenant les paramètres</param>
        /// <returns>liste de tableaux d'objets contenant les valeurs des colonnes</returns>
        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            int nbCols = reader.FieldCount;
            List<object[]> records = new List<object[]>();
            while (reader.Read())
            {
                object[] attributs = new object[nbCols];
                reader.GetValues(attributs);
                records.Add(attributs);
            }
            reader.Close();
            return records;
        }
    }
}
