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
                var instructor = db.Instructor.Single(p => p.InstructorId == 5);

                if(instructor != null){
                    db.Remove(instructor);
                    
                    var estadoTransaccion = db.SaveChanges();

                    if(estadoTransaccion == 1){
                        Console.WriteLine("Eliminado correctamente el registro "+instructor.InstructorId);
                    }else{
                        Console.WriteLine("No se ha podido eliminar el registro");
                    }
                }
            }
        }
    }
}
