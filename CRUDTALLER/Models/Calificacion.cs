using System.ComponentModel.DataAnnotations;

namespace CRUDTALLER.Models
{
    public class Calificacion
    {
        public int Id { get; set; }

        [Required]
        public int PeliculaId { get; set; }   // FK a película
        public Pelicula Pelicula { get; set; }  // Relación con Pelicula

        [Range(1, 5)]
        public int Score { get; set; }  // Puntuación de 1 a 5 estrellas

        public DateTime RatedAt { get; set; } = DateTime.Now;
    }

}
