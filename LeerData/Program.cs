using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new Conexion()){
                /*var cursos = db.Curso.Include(c => c.InstructorLink).ThenInclude(ci => ci.Instructor);

                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var insLink in curso.InstructorLink)
                    {
                        Console.WriteLine("**********"+insLink.Instructor.Nombre);
                    }
                }*/
                // Migracion de clases a SQL en Net Core
                Console.WriteLine("Inicia la migracion a MYSQL");
                db.Database.SetCommandTimeout(10000);
                db.Database.Migrate();
            }
        }
    }
}
