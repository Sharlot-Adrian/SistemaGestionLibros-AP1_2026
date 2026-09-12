using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RegistroLibros.Models
{
    public class Libro
    {
        [Required(ErrorMessage = "Este campo es requerido.")]
        public int LibroId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Titulo { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string autor { get; set; } = null!;
        [Required(ErrorMessage ="Este campo es requerido.")]
        public DateTime AnoPublicacion { get; set; }
    }
}
