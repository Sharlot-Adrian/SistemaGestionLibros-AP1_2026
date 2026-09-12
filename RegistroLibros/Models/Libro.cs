namespace RegistroLibros.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }

        public string autor {  get; set; }

        public DateTime AnoPublicacion { get; set; }
    }
}
