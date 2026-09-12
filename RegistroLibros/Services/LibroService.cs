using Microsoft.EntityFrameworkCore;
using RegistroLibros.Context;
using RegistroLibros.Models;

namespace RegistroLibros.Services
{
    public class LibroService(IDbContextFactory<Contexto> DbFactory)
    {
        private async Task<bool> Existe(int LibroId)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            return await contexto.Libros.AnyAsync(l => l.LibroId == LibroId);
        }
        private async Task<bool> Insertar(Libro libro)
        {
            await using var contexto = await DbFactory.CreateDbContextAsync();
            contexto.Libros.Add(libro);
            return await contexto.SaveChangesAsync() > 0;
        }
       
    }
}

