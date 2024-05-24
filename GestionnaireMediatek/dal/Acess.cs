using GestionnaireMediatek.bddmanager;
using System;
using System.Configuration;

namespace GestionnaireMediatek.dal
{
    public class Access
    {
        private static readonly string connectionName = "GestionnaireMediatek.Properties.Settings.mediatekConnectionString";
        private static Access instance = null;
        public BddManager Manager { get; }

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

        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

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
