using Microsoft.EntityFrameworkCore;
using FormularioAPI.Models;

namespace FormularioAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // DbSet que representa la tabla de usuarios en la base de datos

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la tabla para el modelo User
            modelBuilder.Entity<User>().ToTable("users_test_carlosdanielhernandez");
        }
    }
}
