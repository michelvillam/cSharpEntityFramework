using System;
using Microsoft.EntityFrameworkCore;
using ReadData.Data;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the application. ");

            var db = new AppVentaCursoContext();

            var cursos = db.Curso.Include(p => p.PrecioPromocion)
                                 .Include(c => c.ComentarioLista)
                                 .Include(i => i.CursoInstructors)
                                    .ThenInclude(ci => ci.Instructor);// returns array IQuerable

            foreach (var curso in cursos)
            {
                Console.WriteLine(curso.Titulo + " ---- " + curso.Description + " " + curso.PrecioPromocion.PrecioActual);

                foreach (var comment in curso.ComentarioLista)
                {
                    Console.WriteLine(comment.Alumno + ": " + comment.ComentarioTexto);
                }

                foreach (var cursoInstructor in curso.CursoInstructors)
                {
                    Console.WriteLine( "Instructor: " + cursoInstructor.Instructor.Nombre + " " + cursoInstructor.Instructor.Apellidos);
                }

            }



        }
    }
}
