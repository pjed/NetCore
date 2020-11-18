using System;
using static Conexion;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new Conexion()){
                var cursos = db.curso.AsNoTracking();//arreglo IQueryable
                foreach (var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                }
            }
        }
    }
}
