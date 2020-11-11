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

        }
    }
}
