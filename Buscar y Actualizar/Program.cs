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
                var instructor = db.Instructor.Single(p => p.Nombre == "Lorenzo");

                if(instructor != null){
                    instructor.Apellidos = "Castro de Roma";
                    instructor.Grado = "Biologo con Experiencia";
                    var estadoTransaccion = db.SaveChanges();

                    if(estadoTransaccion==1){
                        Console.WriteLine("Guardado correctamente");
                    }else{
                        Console.WriteLine("No se ha guardado");
                    }
                }
            }
        }
    }
}
