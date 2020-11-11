using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ReadData.Data
{
    public class AppVentaCursoContext : DbContext
    {
        //Data to connect to the DB
        private const string connectionString = @"Server=localhost;Port=32768; User Id=postgres;Password=postgres;Database = CursosOnline";

        //Overriding method OnConfiguring to connect to the DB.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        //Configuring model to do N-M relation with curso and instructor.
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        public DbSet<Curso> Curso { get; set; }

        public DbSet<Precio> Precio { get; set; }

        public DbSet<Comentario> Comentario { get; set; }

        public DbSet<Instructor> Instructor { get; set; }

        public DbSet<CursoInstructor> CursoInstructor { get; set; }
    }
}