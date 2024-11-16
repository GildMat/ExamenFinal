namespace apiexamen.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }
        public ICollection<InformacionGeneral> InformacionGeneral { get; set; }
    }
}
