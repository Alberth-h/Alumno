using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = "Alberto";
            alumno.Matricula = "189180";
            alumno.FechaNacimiento = "25/07/00";
            alumno.Direccion = "Cuauhtemoc #80 Laureles";
            alumno.Telefono = "6421122188";

            Console.WriteLine("Alumno:");
            Console.WriteLine("Nombre: " + alumno.Nombre);
            Console.WriteLine("Matricula: " + alumno.Matricula);
            Console.WriteLine("Fecha de Nacimiento: " + alumno.FechaNacimiento);
            Console.WriteLine("Direccion: " + alumno.Direccion);
            Console.WriteLine("Telefono: " + alumno.Telefono);

            Console.Read();
        }
    }
}
