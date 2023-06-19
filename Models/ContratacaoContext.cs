using Microsoft.EntityFrameworkCore;

namespace iob_smart_webapi.Models;

public class ContratacaoContext : DbContext
{
    public ContratacaoContext(DbContextOptions<ContratacaoContext> options)
        : base(options)
    {
    }

    public DbSet<Contratacao> Contratacoes { get; set; } = null!;
}