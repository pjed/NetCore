using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new Conexion()){
                var nuevoInstructor = new Instructor{
                    Nombre = "Lorenzo",
                    Apellidos = "Lopez Arias",
                    Grado = "Master en Computacion"
                };
                db.Add(nuevoInstructor);

                var nuevoInstructor2 = new Instructor{
                    Nombre = "Jose",
                    Apellidos = "Mariano",
                    Grado = "Master en Computacion"
                };
                db.Add(nuevoInstructor2);

                var estadoTransaccion = db.SaveChanges();

                if(estadoTransaccion == 1){
                    Console.WriteLine("Transaccion correcta");
                }else{
                    Console.WriteLine("Transaccion incorrecta");
                }
                
            }
        }
    }
}
