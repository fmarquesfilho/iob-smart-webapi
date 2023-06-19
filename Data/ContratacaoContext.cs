using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iob_smart_webapi.Models;

    public class ContratacaoContext : DbContext
    {
        public ContratacaoContext (DbContextOptions<ContratacaoContext> options)
            : base(options)
        {
        }

        public DbSet<iob_smart_webapi.Models.Contratacao> Contratacao { get; set; } = default!;
    }
