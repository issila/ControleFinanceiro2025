using Apoio.Models;
using Microsoft.EntityFrameworkCore;

namespace Apoio.Data
{
    public class ApoioContext : DbContext
    {
        public ApoioContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Instituicao> Instituicoes { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
