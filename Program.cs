using System;
using Microsoft.EntityFrameworkCore;
using ReadData.Data;
using System.Linq;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the application. ");

            var db = new AppVentaCursoContext();

            Instructor instructor = new Instructor
            {
                Nombre = "Lorenzo",
                Apellidos = "Lopez",
                Grado = "Master en computacion"
            };

            //***** SAVING INSTRUCTOR ********
            //se añade el nuevo instructor al contexto
            //db.Add(instructor);
            //se inserta en BD. Devuelve el numero de transactiones que se han ejecutado en DB.
            //int estadoTransaction = db.SaveChanges();

            var instructorDB = db.Instructor.Single(p => p.Nombre == "Lorenzo");

            //***** UPDATING INSTRUCTOR ********
            /* if (instructorDB != null)
            {
                instructorDB.Grado = "Nuevo titulo";
                db.SaveChanges();
                Console.WriteLine("Update correctly");
            } */

            //***** DELETING INSTRUCTOR ********
            if (instructorDB != null)
            {
                db.Remove(instructorDB);
                db.SaveChanges();
            }

        }
    }
}
