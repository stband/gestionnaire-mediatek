namespace GestionnaireMediatek.Models
{
    public class Absence
    {
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int IdMotif { get; set; }
    }
}
