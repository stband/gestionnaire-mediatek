using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace GestionnaireMediatek
{
    public class BddManager
    {
        private static BddManager instance = null;
        private readonly MySqlConnection connection;

        private BddManager()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
                connection = new MySqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Connexion réussie à la base de données.");
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Erreur de configuration : " + ex.Message);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erreur de connexion à la base de données MySQL : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur inconnue : " + ex.Message);
            }
        }

        public static BddManager GetInstance()
        {
            if (instance == null)
            {
                instance = new BddManager();
            }
            return instance;
        }

        public void ReqControle(string stringQuery)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            command.ExecuteNonQuery();
        }

        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
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
            command.ExecuteNonQuery();
        }

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

        public void TestConnection()
        {
            try
            {
                string query = "SELECT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Test de connexion réussi !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Échec du test de connexion.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur inconnue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    }
}

