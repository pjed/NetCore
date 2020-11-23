using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace LeerData
{
    public class Conexion : DbContext
    {
        public Conexion (){
            DatabaseGenerateAttribute.SetCommandTimeout(150000);
        }

        //Metodo OnConfiguring para configurar el motor de la bbdd
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Constructor para iniciar la conexion de la bbdd
            //optionsBuilder.UseSqlServer(Constantes.Constantes.connectionString);
            optionsBuilder.UseMySQL(Constantes.Constantes.connectionStringMySql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.CursoId, ci.InstructorId});
        }

        //Almacen curso
        public DbSet<Curso> Curso { get; set; }

        //Almacen precio
        public DbSet<Precio> Precio { get; set; }

        //Almacen Comentario
        public DbSet<Comentario> Comentario { get; set; }

        //Almacen Instructores
        public DbSet<Instructor> Instructor { get; set; }

        //Almacen CursoInstructor
        public DbSet<CursoInstructor> CursoInstructor { get; set; }
    }
}