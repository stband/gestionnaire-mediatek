using GestionnaireMediatek.bddmanager;
using GestionnaireMediatek.Models;
using System;
using System.Configuration;

namespace GestionnaireMediatek.dal
{
    /// <summary>
    /// Singleton : gestionnaire d'accès à la base de données
    /// Toutes les méthodes de cette classe permettent de préparer l'intéraction avec la base de données.
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

        /// <summary>
        /// Récupère la liste des responsables.
        /// </summary>
        /// <returns>Liste des responsables.</returns>
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

        /// <summary>
        /// Récupère la liste du personnel.
        /// </summary>
        /// <returns>Liste du personnel.</returns>
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

        /// <summary>
        /// Ajoute un nouveau membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet Personnel à ajouter.</param>
        public void AddPersonnel(Personnel personnel)
        {
            string query = "INSERT INTO personnel (nom, prenom, tel, mail, idService) VALUES (@nom, @prenom, @tel, @mail, @idService)";
            var parameters = new Dictionary<string, object>
            {
                { "@nom", personnel.Nom },
                { "@prenom", personnel.Prenom },
                { "@tel", personnel.Tel },
                { "@mail", personnel.Mail },
                { "@idService", personnel.IdService }
            };
            Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Met à jour les informations d'un membre du personnel.
        /// </summary>
        /// <param name="personnel">Objet Personnel à mettre à jour.</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            string query = "UPDATE personnel SET nom = @Nom, prenom = @Prenom, tel = @Tel, mail = @Mail, idService = @IdService WHERE idPersonnel = @IdPersonnel";
            var parameters = new Dictionary<string, object>
            {
                { "@Nom", personnel.Nom },
                { "@Prenom", personnel.Prenom },
                { "@Tel", personnel.Tel },
                { "@Mail", personnel.Mail },
                { "@IdService", personnel.IdService },
                { "@IdPersonnel", personnel.IdPersonnel }
            };

            Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Récupère la liste des services.
        /// </summary>
        /// <returns>Liste des services.</returns>
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            string query = "SELECT idservice, nom FROM service";
            var records = Manager.ReqSelect(query);
            foreach (var record in records)
            {
                services.Add(new Service(
                    (int)record[0],
                    (string)record[1]
                ));
            }
            return services;
        }

        /// <summary>
        /// Supprime un membre du personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel à supprimer.</param>
        public void DeletePersonnel(int idPersonnel)
        {
            string query = "DELETE FROM personnel WHERE idPersonnel = @IdPersonnel";
            var parameters = new Dictionary<string, object>
            {
                { "@IdPersonnel", idPersonnel }
            };

            Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Récupère la liste des absences d'un personnel.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel.</param>
        /// <returns>Liste des absences.</returns>
        public List<Absence> GetAbsences(int idPersonnel)
        {
            List<Absence> absences = new List<Absence>();
            string query = "SELECT idpersonnel, datedebut, datefin, idmotif FROM absence WHERE idpersonnel = @idpersonnel";
            var parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", idPersonnel }
            };
            var records = Manager.ReqSelect(query, parameters);
            foreach (var record in records)
            {
                absences.Add(new Absence
                {
                    IdPersonnel = (int)record[0],
                    DateDebut = (DateTime)record[1],
                    DateFin = record[2] == DBNull.Value ? (DateTime?)null : (DateTime)record[2],
                    IdMotif = (int)record[3]
                });
            }
            return absences;
        }

        /// <summary>
        /// Récupère la liste des motifs d'absence.
        /// </summary>
        /// <returns>Liste des motifs.</returns>
        public List<Motif> GetMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            string query = "SELECT idmotif, libelle FROM motif";
            var records = Manager.ReqSelect(query);
            foreach (var record in records)
            {
                motifs.Add(new Motif
                {
                    IdMotif = (int)record[0],
                    Libelle = (string)record[1]
                });
            }
            return motifs;
        }

        /// <summary>
        /// Ajoute une nouvelle absence.
        /// </summary>
        /// <param name="absence">Objet Absence à ajouter.</param>
        public void AddAbsence(Absence absence)
        {
            string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";
            var parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", absence.IdPersonnel },
                { "@datedebut", absence.DateDebut },
                { "@datefin", absence.DateFin },
                { "@idmotif", absence.IdMotif }
            };

            Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Met à jour une absence existante.
        /// </summary>
        /// <param name="absence">Objet Absence à mettre à jour.</param>
        /// <param name="oldDateDebut">Ancienne date de début de l'absence.</param>
        public void UpdateAbsence(Absence absence, DateTime oldDateDebut)
        {
            string query = "UPDATE absence SET datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel AND DATE(datedebut) = DATE(@olddatedebut)";
            var parameters = new Dictionary<string, object>
            {
                { "@datedebut", absence.DateDebut },
                { "@datefin", absence.DateFin },
                { "@idmotif", absence.IdMotif },
                { "@idpersonnel", absence.IdPersonnel },
                { "@olddatedebut", oldDateDebut.Date }
            };

            Manager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Supprime une absence.
        /// </summary>
        /// <param name="absence">Objet Absence à supprimer.</param>
        public void DeleteAbsence(Absence absence)
        {
            string query = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND DATE(datedebut) = DATE(@datedebut)";
            var parameters = new Dictionary<string, object>
            {
                { "@idpersonnel", absence.IdPersonnel },
                { "@datedebut", absence.DateDebut.Date }
            };

            Manager.ReqUpdate(query, parameters);
        }
    }
}
