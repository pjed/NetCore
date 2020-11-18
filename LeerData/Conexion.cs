using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData.Class
{
    public class Conexion : DbContext
    {
        //Metodo OnConfiguring para configurar el motor de la bbdd
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Constructor para iniciar la conexion de la bbdd
            optionsBuilder.UseSqlServer(Constantes.Constantes.connectionString);
        }

        // Objeto curso con el cual trastearemos 
        public DbSet<Curso> Curso { get; set; }
    }
}