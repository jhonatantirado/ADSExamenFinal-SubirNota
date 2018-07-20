
namespace Common.Infrastructure.Repository
{
    using Locations.Domain;
    using Estudiantes.Domain.Entity;
    using Microsoft.EntityFrameworkCore;

    public class PracticaExamenContext : DbContext
    {
        public PracticaExamenContext()
        {
        }

        public PracticaExamenContext(DbContextOptions<PracticaExamenContext> options) : base(options)
        {
        }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
