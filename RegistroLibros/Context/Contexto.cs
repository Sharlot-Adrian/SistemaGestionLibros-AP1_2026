namespace RegistroLibros.Context;
using Microsoft.EntityFrameworkCore;
using RegistroLibros.Models;

public class Contexto: DbContext 
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Libro> Libros { get; set; }


}

