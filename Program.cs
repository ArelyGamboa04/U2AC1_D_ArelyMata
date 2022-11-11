using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace U2AC1_D_ArelyMata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreAlumno, matricula, carrera, grupoSeccion;
            byte u1, u2, u3, u4, u5;

            Console.WriteLine("Ingresa el nombre del alumno");
            nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingresa numero de matricula");
            matricula = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera");
            carrera = Console.ReadLine();
            Console.WriteLine("ingrese su grupo y seccion");
            grupoSeccion = Console.ReadLine();
            Console.WriteLine("Ingrese calificacion de la Unidad 1");
            u1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion de la Unidad 2");
            u2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion de la Unidad 3");
            u3 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion de la Unidad 4");
            u4 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion de la Unidad 5");
            u5 = Convert.ToByte(Console.ReadLine());

            if (u1 > 7)
            {
                Console.WriteLine("El alumno acredito la unidad");
                Console.WriteLine("\n Informacion del alumno");
                Console.WriteLine("Nombre del alumno: {0}, matricula: {1}, carrera: {2}, Grupo y Seccion {3}", nombreAlumno, matricula, carrera, grupoSeccion);
            }
            else
            {
                Console.WriteLine("Recursaras la materia");
            }

            if (u2 > 7)
            {
                Console.WriteLine("El alumno acredito la unidad");
                Console.WriteLine("\n Informacion del alumno");
                Console.WriteLine("Nombre del alumno: {0}, matricula: {1}, carrera: {2}, Grupo y Seccion {3}", nombreAlumno, matricula, carrera, grupoSeccion);
            }
            else
            {
                Console.WriteLine("Recursaras la materia");
            }
         
            if (u3 > 7)
            {
                Console.WriteLine("El alumno acredito la unidad");
                Console.WriteLine("\n Informacion del alumno");
                Console.WriteLine("Nombre del alumno: {0}, matricula: {1}, carrera: {2}, Grupo y Seccion {3}", nombreAlumno, matricula, carrera, grupoSeccion);
            }

            else
            {
                Console.WriteLine("Recursaras la materia");
            }

            if (u4 > 7)
            {
                Console.WriteLine("El alumno acredito la unidad");
                Console.WriteLine("\n Informacion del alumno");
                Console.WriteLine("Nombre del alumno: {0}, matricula: {1}, carrera: {2}, Grupo y Seccion {3}", nombreAlumno, matricula, carrera, grupoSeccion);

            }

            else
            {
                Console.WriteLine("Recursaras la materia");
            }

            if (u5 > 7)
            {
                Console.WriteLine("El alumno acredito la unidad");
                Console.WriteLine("\n Informacion del alumno");
                Console.WriteLine("Nombre del alumno: {0}, matricula: {1}, carrera: {2}, Grupo y Seccion {3}", nombreAlumno, matricula, carrera, grupoSeccion);
            }
            else
            {
                Console.WriteLine("Recursaras la materia");
               
            }

            Console.ReadKey();
        }
    }
}
