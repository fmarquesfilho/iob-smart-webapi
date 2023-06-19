using Microsoft.EntityFrameworkCore;

namespace iob_smart_webapi.Models;

public class NotaContext : DbContext
{
    public NotaContext(DbContextOptions<NotaContext> options)
        : base(options)
    {
    }

    public DbSet<Nota> Notas { get; set; } = null!;
}