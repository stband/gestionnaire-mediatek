namespace GestionnaireMediatek.Models
{
    public class Personnel
    {
        public int IdPersonnel { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int IdAdmin { get; set; }
        public int IdService { get; set; }
    }
}
