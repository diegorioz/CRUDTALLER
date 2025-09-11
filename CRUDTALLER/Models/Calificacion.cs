namespace CRUDTALLER.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int Puntuacion { get; set; } // 1 a 5 estrellas
        public DateTime Fecha { get; set; }
    }
}
